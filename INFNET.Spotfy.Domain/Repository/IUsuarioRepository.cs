using INFNET.Spotfy.Domain.Entities;
using INFNET.Spotfy.Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Domain.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> GetUserByCredencial(string login, string password);
    }
}
