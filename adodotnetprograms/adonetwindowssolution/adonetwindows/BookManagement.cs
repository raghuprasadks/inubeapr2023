using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetwindows
{
    class BookManagement
    {

        internal static List<Book> getBookDetails()
        {
            /**
            Book book1 = new Book();
            book1.ISBNNumber = 1;
            book1.Title = "3 Idiots";
            book1.Author = "Chetan Bhagat";
            **/
            // Book book2 = new Book { ISBNNumber = 1, Title = "A Better World", Author = "Narayana Murthy", Category = "drama", Price = 1000, Stock = 10 };
            //  Book book3 = new Book(2,"test 1","Chethan Bhagat");
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book { ISBNNumber = 1, Title = "A Better World", Author = "Narayana Murthy", Category = "drama", Price = 1000, Stock = 10 });
            bookList.Add(new Book { ISBNNumber = 2, Title = "A Revenue Stamp", Author = "Amrita Pritam", Category = "drama", Price = 1000, Stock = 10 });
            bookList.Add(new Book { ISBNNumber = 3, Title = "Pinjar", Author = "Amrita Pritam", Category = "drama", Price = 2000, Stock = 8 });
            bookList.Add(new Book { ISBNNumber = 4, Title = "A Tale of Two Cities", Author = "Charles Darwin", Category = "Fiction", Price = 3000, Stock = 5 });
            bookList.Add(new Book { ISBNNumber = 5, Title = "Devdas", Author = "Chetan Baghat", Category = "Fiction", Price = 1000, Stock = 7 });
            bookList.Add(new Book { ISBNNumber = 6, Title = "Crime and Punishment", Author = "Sarat Chandra Chaterjee", Category = "Fiction", Price = 2000, Stock = 6 });
            bookList.Add(new Book { ISBNNumber = 7, Title = "Faust", Author = "Goethe", Category = "Scientific", Price = 4000, Stock = 4 });
            bookList.Add(new Book { ISBNNumber = 8, Title = "India", Author = "Chetan Baghat", Category = "Scientific", Price = 2000, Stock = 10 });
            bookList.Add(new Book { ISBNNumber = 9, Title = "Paradise Lost", Author = "John Miton", Category = "Scientific", Price = 3000, Stock = 9 });
            return bookList;
        }

        internal static void printDetails()
        {
            List<Book> details = getBookDetails();
            var result = from p in details
                         select p;
            Console.WriteLine("Using query :");
            foreach (var res in result)
            {
                Console.WriteLine("ISBNNumber :" + res.ISBNNumber + " ,Title :" + res.Title + " ,Author :" + res.Author + " ,Category :" + res.Category + " ,Price : " + res.Price + " , Stock : " + res.Stock);
            }
            Console.WriteLine();
            Console.WriteLine("Using method :");
            var result1 = details.Select(p => p);
            foreach (var res in result1)
            {
                Console.WriteLine("ISBNNumber :" + res.ISBNNumber + " ,Title :" + res.Title + " ,Author :" + res.Author + " ,Category :" + res.Category + " ,Price : " + res.Price + " , Stock : " + res.Stock);
            }
        }

        internal static void MaxPrice()
        {
            List<Book> details = getBookDetails();
            var result = from p in details
                         select p.Price;
            Console.WriteLine("Using query :");
            Console.WriteLine("book with max price :" + result.Max());
            Console.WriteLine();
            Console.WriteLine("Using method :");
            var result1 = details.Max(p => p.Price);
            Console.WriteLine("book with max price :" + result1);
        }

        internal static void groupCategory()
        {
            List<Book> details = getBookDetails();
            var result = from p in details
                         group p by p.Category;
            Console.WriteLine("Using query :");
            foreach (var res in result)
            {
                Console.WriteLine("Category : " + res.Key);
                foreach (var grp in res)
                {

                    Console.WriteLine("title :" + grp.Title + " , Author :" + grp.Author);
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("Using method :");
            var result1 = details.GroupBy(p => p.Category);
            foreach (var res in result1)
            {
                Console.WriteLine("Category :" + res.Key);
                foreach (var grp in res)
                {
                    Console.WriteLine("title :" + grp.Title + " ,Author :" + grp.Author);
                }
                Console.WriteLine();
            }

        }
        internal static void chetanBooks()
        {
            List<Book> details = getBookDetails();
            var result = from p in details
                         where p.Author.Contains("Chetan Baghat")
                         select p;
            Console.WriteLine("Using query :");
            foreach (var res in result)
            {
                Console.WriteLine("book :" + res.Title + " ,Author : " + res.Author);
            }

            Console.WriteLine();
            Console.WriteLine("Using method :");
            var result1 = details.Where(p => p.Author.Contains("Chetan Baghat"));
            foreach (var res in result1)
            {
                Console.WriteLine("book :" + res.Title + " ,Author : " + res.Author);
            }


        }
        internal static void titleIndia()
        {
            List<Book> details = getBookDetails();
            var result = from p in details
                         where p.Title.Contains("India")
                         select p;
            Console.WriteLine("Using query :");
            foreach (var res in result)
            {
                Console.WriteLine("book :" + res.Title + " ,Author : " + res.Author);
            }


            Console.WriteLine("Using method :");
            var result1 = details.Where(p => p.Title.Contains("India"));
            foreach (var res in result1)
            {
                Console.WriteLine("book :" + res.Title + " ,Author : " + res.Author);
            }


        }



    }

    class Book
    {
        /**
        public Book()
        {

        }

        public Book (int ISBNNumber, string Title, string Author, string Category, int Price, int Stock)
         {
            this.ISBNNumber = ISBNNumber;
            this.Title = Title;



         }
           **/ 

        public int ISBNNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

    }
}
