using DATABASEE.Context;
using DATABASEE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Repository
{
     public  class Repository<T> : IRepository<T> where T : BaseModels

     {

        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)

        {
            _context = context;

        }

        public async Task<T> Add(T entity)
        {

            _context.Set<T>().Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public Task Delete(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public async Task<T?> Get(int id, CancellationToken token)
        {
          return await  _context.Set<T>().FirstOrDefaultAsync(f => f.Id==id ,token);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();

        }

        public Task SaveAsynk(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
