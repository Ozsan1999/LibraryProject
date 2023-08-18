using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ProyectoDbContext _dbContext;

        public AuthorRepository(ProyectoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.FirstOrDefault(author => author.Id == id);
        }

        public List<Author> GetAll()
        {
            return _dbContext.Authors.ToList();
        }

        public void Add(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public void Update(Author author)
        {
            _dbContext.Entry(author).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = _dbContext.Authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
            }
        }
    }
}
