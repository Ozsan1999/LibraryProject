using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }

        // Navigation property
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
