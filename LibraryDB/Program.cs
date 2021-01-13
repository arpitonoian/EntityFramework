using System;
using System.Linq;

namespace LibraryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book Name:");
            var input = Console.ReadLine();

            using (var context = new LibraryContext())
            {
                {
                    var query = context.Books.Join(context.BookAuthors,
                             b1 => b1.Id,
                             b2 => b2.BookId,
                             (b1, b2) => new { b1, b2 }).Join(context.Authors,
                             a => a.b2.AuthorId,
                             b => b.Id,
                             (b, a) => new { b, a }).Where(nam => nam.b.b1.Name.StartsWith(input)).ToList();

                    var t = 0;
                    foreach (var q in query)
                    {

                        if (t != q.b.b1.Id)
                        {
                            Console.WriteLine();
                            Console.Write(q.b.b1.Name + ": ");
                        }

                        Console.WriteLine(q.a.FirstName + " " + q.a.LastName);
                        t = q.b.b1.Id;
                    }
                }
            }
        }
    }
}