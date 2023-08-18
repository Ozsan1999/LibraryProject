using System;
using Project.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public interface IAuthorRepository
    {
        Author GetById(int id);
        List<Author> GetAll();
        void Add(Author author);
        void Update(Author author);
        void Delete(int id);
    }
}
