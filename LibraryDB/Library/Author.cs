using System.Collections.Generic;

namespace LibraryDB
{
    public class Author
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public override string ToString()
        {
            return Id+ " " + FirstName + " " + LastName;
        }
    }
}