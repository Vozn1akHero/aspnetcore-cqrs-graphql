using System;
using System.Collections.Generic;

namespace librarygraphql.Models
{
    public partial class Country
    {
        public Country()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
