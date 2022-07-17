using INFNET.Spotfy.Domain.Entities;
using INFNET.Spotfy.Domain.Repository;
using INFNET.Spotfy.Infra.Database;
using INFNET.Spotfy.Repository.SqlServer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Repository.SqlServer.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SpotifyContext context) 
            : base(context)
        {

        }

        public async Task<Usuario> GetUserByCredencial(string login, string password)
        {
            return await this.ListarItemComQuery(x=>x.Email.Value == login 
                                                    && x.Senha.Value == password);
        }
    }
}
