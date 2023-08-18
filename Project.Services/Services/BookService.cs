using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetBookById(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book == null)
            {
                throw new NotFoundException("Book not found");
            }
            return book;
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public void AddBook(Book book)
        {
            // Implement validation and business rules here
            _bookRepository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            // Implement validation and business rules here
            _bookRepository.Update(book);
        }

        public void DeleteBook(int id)
        {
            var book = _bookRepository.GetById(id);
            if (book == null)
            {
                throw new NotFoundException("Book not found");
            }
            _bookRepository.Delete(id);
        }
    }
}
