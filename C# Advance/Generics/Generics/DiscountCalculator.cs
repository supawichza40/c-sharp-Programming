namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    //Instead of 

    public class DiscountCalculatorNormal
    {
        public float CalculateDiscount(Product product)
        {
            return product.Price;
        }
    }
}