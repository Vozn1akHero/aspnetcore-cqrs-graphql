using System;
using System.Collections.Generic;

namespace librarygraphql.Models
{
    public partial class Category
    {
        public Category()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
