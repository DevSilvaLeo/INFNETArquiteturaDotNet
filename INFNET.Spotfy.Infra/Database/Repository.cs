using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Infra.Database
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly DbContext _context;
        protected DbSet<T> _set;

        protected Repository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public async Task Salvar(T entity)
        {
            _set.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(T entity)
        {
            _set.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(T entity)
        {
            _set.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> ListarTodos()
        {
            return await Task.FromResult(_set.AsEnumerable());
        }

        public async Task<IEnumerable<T>> ListarTodosComQuery(Expression<Func<T, bool>> expression)
        {
            return await Task.FromResult(_set.Where(expression));
        }

        public async Task<T> ListarPorID(object id)
        {
            return await _set.FindAsync(id);
        }

        public async Task<T> ListarItemComQuery(Expression<Func<T, bool>> expression)
        {
            return await _set.FirstOrDefaultAsync(expression);
        }
    }
}
