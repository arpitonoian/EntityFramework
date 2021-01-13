namespace LibraryDB.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LibraryDB.LibraryContext";
        }

        protected override void Seed(LibraryContext context)
        {
            context.Books.Add(new Book() { Name = "Design Patterns" });
            context.Books.Add(new Book() { Name = "Introduction to Object Orient Design in C++" });
            context.Books.Add(new Book() { Name = "Contributing to Eclipse: Principles, Patterns, and Plug-ins" });
            context.Books.Add(new Book() { Name = "A Lost Age" });
            context.Books.Add(new Book() { Name = "T-SQL Fundamentals" });
            context.Books.Add(new Book() { Name = "T-SQL Querying" });
            context.Books.Add(new Book() { Name = "Murach's C# 2015" });
            context.Books.Add(new Book() { Name = "Murach'S Visual Basic 2008" });
            context.Books.Add(new Book() { Name = "Design Patterns in .NET" });

           
            context.Authors.Add(new Author { FirstName = "Erich", LastName = "Gamma" });
            context.Authors.Add(new Author { FirstName = "Ralph", LastName = "Johnson" });
            context.Authors.Add(new Author { FirstName = "Richard", LastName = "Richard" });
            context.Authors.Add(new Author { FirstName = "Anne", LastName = "Boehm" });
            context.Authors.Add(new Author { FirstName = "Joel", LastName = "Murach" });
            context.Authors.Add(new Author { FirstName = "Itzik", LastName = "Ben-Gan" });
            context.Authors.Add(new Author { FirstName = "Adam", LastName = "Machanic" });
            context.Authors.Add(new Author { FirstName = "Kevin", LastName = "Farlee" });
            context.Authors.Add(new Author { FirstName = "Dmitri", LastName = "Nesteruk" });

            context.BookAuthors.Add(new BookAuthor() { BookId = 1, AuthorId = 1 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 1, AuthorId = 2 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 1, AuthorId = 3 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 2, AuthorId = 1 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 2, AuthorId = 3 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 3, AuthorId = 1 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 4, AuthorId = 2 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 4, AuthorId = 1 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 5, AuthorId = 4 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 5, AuthorId = 7 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 6, AuthorId = 4 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 7, AuthorId = 4 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 7, AuthorId = 5 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 8, AuthorId = 8 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 8, AuthorId = 7 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 8, AuthorId = 6 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 9, AuthorId = 9 });
            context.BookAuthors.Add(new BookAuthor() { BookId = 9, AuthorId = 6 });
        }
    }
}