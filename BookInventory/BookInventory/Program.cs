using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {


            BookContext context = new BookContext();


            context.Database.EnsureCreated();

            // ask the user for a book to add
            Console.WriteLine("Enter book name, author");
            String BookInfo = Console.ReadLine();

            // split the input into parts, and make sure 
            // we have 2 parts only
            String[] parts = BookInfo.Split(',');
            if (parts.Length == 2)
            {

                BookInventory newbook = new BookInventory(parts[0], parts[1]);

                // add the newly created student instance to the context
                // notice how similar this is to adding a item to a list,
                context.books.Add(newbook);

                // ask the context to save any changes to the database 
                context.SaveChanges();
                Console.WriteLine("Added the books list.");
            }
            else
            {
                Console.WriteLine("Invalid book info, did not add book");
            }

            Console.WriteLine("The Current List of Books are: ");
            
            foreach (BookInventory s in context.books)
            {
                Console.WriteLine("{0} - {1} {2}",
                     s.Id, s.BookName, s.AuthorName);
            }

        }
    }
}
