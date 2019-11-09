using System;
using System.Collections.Generic;

namespace librarygraphql.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Country Country { get; set; }
        public virtual Language Language { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
