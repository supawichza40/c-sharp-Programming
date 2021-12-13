using System;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = ProductFactory.createSQL();
            ProductCatalog productCatalog = new ProductCatalog(productRepository);
            productCatalog.ListAllProducts();
            productRepository = ProductFactory.createMangoDB();
            productCatalog = new ProductCatalog(productRepository);
            productCatalog.ListAllProducts();
        }
        public class ProductCatalog
        {
            private ProductRepository productRepository;
            public ProductCatalog(ProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }
            public void ListAllProducts()
            {
                
                productRepository.getAllProductNames();
                //SQLProductRepository sqlProductRepository = new SQLProductRepository();
                //sqlProductRepository.getAllProductNames();
                //display product name
            }
            
        }
        public class SQLProductRepository:ProductRepository
        {
            public List<string> getAllProductNames()
            {
                Console.WriteLine("This is from SQLProductRepo");
                return new List<string>() { "soap", "toothpaste" };
            }
        }
        public interface ProductRepository
        {
            public List<string> getAllProductNames();
        }
        public class ProductFactory
        {
            public static ProductRepository createSQL()
            {
                return new SQLProductRepository();
            }
            public static ProductRepository createMangoDB()
            {
                return new MangoDBProductRepository();
            }
        }
        public class MangoDBProductRepository : ProductRepository
        {
            public List<string> getAllProductNames()
            {
                Console.WriteLine("This is from MangoDBProductRepo");
                return new List<string> { "hello","world"};
            }
        }
    }

}
