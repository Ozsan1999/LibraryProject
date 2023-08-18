using System;
using Project.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
    public interface IBookService
    {
        Book GetBookById(int id);
        List<Book> GetAllBooks();
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
