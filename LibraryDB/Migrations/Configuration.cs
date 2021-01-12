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

            context.Authors.Add(new Author { FirstName = "Erich", LastName = "Gamma" });
            context.Authors.Add(new Author { FirstName = "Ralph", LastName = "Johnson" });
            context.Authors.Add(new Author { FirstName = "Richard", LastName = "Richard" });

            context.BookAuthors.Add(new BookAuthor() { AuthorId = 1, BookId = 1 });
            context.BookAuthors.Add(new BookAuthor() { AuthorId = 1, BookId = 2 });
            context.BookAuthors.Add(new BookAuthor() { AuthorId = 1, BookId = 4 });
            context.BookAuthors.Add(new BookAuthor() { AuthorId = 2, BookId = 1 });
            context.BookAuthors.Add(new BookAuthor() { AuthorId = 3, BookId = 1 });
            context.BookAuthors.Add(new BookAuthor() { AuthorId = 3, BookId = 2 });
        }
    }
}