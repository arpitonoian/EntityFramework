using System;
using System.Linq;

namespace LibraryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            using (var context = new LibraryContext())
            {
                var books = context.Books.Select(s => s).ToList();
                var authors = context.Authors.Select(a => a).ToList();
                var bookauthor = context.BookAuthors.Select(s => s).ToList();

                var quar = context.Books.Join(context.BookAuthors,
                      b1 => b1.ID,
                      b2 => b2.BookId,
                      (b1, b2) => new { b1, b2 }).Join(context.Authors,
                      a => a.b2.AuthorId,
                      b => b.ID,
                      (a, b) => new { a, b }).Where(nam => nam.b.FirstName == input).ToList();

                foreach (var a in quar)
                {
                    Console.WriteLine(a.a.b1.Name);
                }
            }
        }
    }
}