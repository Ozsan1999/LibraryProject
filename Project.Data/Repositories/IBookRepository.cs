using System;
using Project.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public interface IBookRepository
    {
        Book GetById(int id);
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
