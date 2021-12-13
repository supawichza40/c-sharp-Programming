using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq
            var books = new BookRepository().GetBooks();

            var cheapBooks = new List<Book>();
            foreach (var item in books)
            {
                if (item.Price <10)
                {
                    cheapBooks.Add(item);
                }
                
            }
            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Title + " "+item.Price);
            }
            //Version2 Linq function
            //Linq is like a filter element.
            Console.WriteLine("Version2:Linq Where method");
            var cheapBooks2 = books.Where(b => b.Price < 10).OrderBy(b=>b.Price);
            foreach (var item in cheapBooks2)
            {
                Console.WriteLine(item.Title +" " + item.Price);
            }

            //Version3 Linq and OrderBy function
            Console.WriteLine("Version3:Linq OrderBy Function");
            var cheapBooks3 = cheapBooks2.OrderBy(b => b.Price);
            foreach (var item in cheapBooks3)
            {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            //Get only a Title from a book list.
            var cheapBooks4 = cheapBooks2.Select(b => b.Title);
            foreach (var item in cheapBooks4)
            {
                Console.WriteLine(item);
            }
            //Make the Linq more readable, convention way.
            //LINQ Extension method.
            //Good for group by
            var cheapBooks5 = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Price)
                                .Select(b=>b.Title);


            //LINQ Query operator
            //More powerful
            var cheaperBook = from b in books
                              where b.Price < 10
                              orderby b.Title
                              select b.Title;

            //Linq select a single element from a list
            //if there is no object, will return error so use singleordefault.
            var specific_book = books.Single(b => b.Title == "ASP.NET MVC");

            //single or default
            var specific_book2 = books.SingleOrDefault(b => b.Title.ToLower() == "asp.net mvcc");
            Console.WriteLine(specific_book.Title +" " +specific_book.Price);

            var specific_book3 = books.FirstOrDefault(b => b.Title.ToLower() == "asp.net mvc");
            if (specific_book3==null)
            {
                Console.WriteLine("Invalid null");
            }
            else
            {
                Console.WriteLine(specific_book3.Title +"" + specific_book3.Price);
            }

            if (specific_book2 ==null)
            {
                Console.WriteLine("Invalid title find");
            }
            else
            {

                Console.WriteLine(specific_book2.Title + " " + specific_book2.Price);
            }
            Console.ReadKey();
            //Lambda Expression
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));

            Console.WriteLine("Skip and Take");
            var specific_book4 = books.Skip(2).Take(3);
            foreach (var item in specific_book4)
            {
                Console.WriteLine(item.Title +" " + item.Price);
            }
            //Count number of book
            var numberOfBook = books.Count();
            Console.WriteLine(numberOfBook);
            var maxPriceOfBook = books.Max(b=>b.Price); //This implies that use the book object itself.
            var minPriceOfBook = books.Min(b => b.Price);
            var sumOfThePrice = books.Sum(b => b.Price);
            Console.WriteLine(maxPriceOfBook);
            Console.WriteLine(minPriceOfBook);
            Console.WriteLine(sumOfThePrice);

            //Test linq skill
            var book_repo = new BookRepository();
            var list_of_books = book_repo.GetBooks();
            //return specific book.
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("SECOND TRIAL OF LINQ");
            var mvc_book = list_of_books.Where(b => b.Title.ToLower() == "asp.net mvc");
            Console.WriteLine(mvc_book);
            Console.WriteLine("Cheapest book under £10 ");
            var cheap_book_list = list_of_books.Where(b => b.Price < 10);
            foreach (var item in cheap_book_list)
            {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            Console.WriteLine("Cheapest book in ascending order under £10");
            var cheap_book_list_ascend = list_of_books.Where(b => b.Price < 10).OrderBy(b => b.Price);
            foreach (var item in cheap_book_list_ascend)
            {
                Console.WriteLine(item.Title +" " + item.Price);
            }


        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }

    
    }
}
