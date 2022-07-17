using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Infra.Database
{
    public interface IRepository<T>
        where T : class
    {
        Task Salvar(T entity);
        Task Remover(T entity);
        Task Atualizar(T entity);
        Task<IEnumerable<T>> ListarTodos();
        Task<T> ListarPorID(object id);
        Task<IEnumerable<T>> ListarTodosComQuery(Expression<Func<T, bool>> expression);
        Task<T> ListarItemComQuery(Expression<Func<T, bool>> expression);

    }
}
