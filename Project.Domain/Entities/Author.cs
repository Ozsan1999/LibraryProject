using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CityOfOrigin { get; set; }
        public string Email { get; set; }
    }
}
