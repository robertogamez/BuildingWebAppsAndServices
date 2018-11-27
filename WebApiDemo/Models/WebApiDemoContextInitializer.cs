using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class WebApiDemoContextInitializer
        : DropCreateDatabaseAlways<WebApiDemoContext>
    {
        protected override void Seed(WebApiDemoContext context)
        {
            var books = new List<Book>
            {
                new Book{ Name = "Roberto", Author = "Roberto G.", Price = 19.9m },
                new Book{ Name = "Book one", Author = "Author1", Price = 19.9m },
                new Book{ Name = "Book two", Author = "Author2", Price = 15.60m },
                new Book{ Name = "Book three", Author = "Author3", Price = 29.9m }
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();



            base.Seed(context);
        }
    }
}