using System.Collections.Generic;

namespace LibraryDB
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public override string ToString()
        {
            return Id + " " + Name;
        }
    }
}