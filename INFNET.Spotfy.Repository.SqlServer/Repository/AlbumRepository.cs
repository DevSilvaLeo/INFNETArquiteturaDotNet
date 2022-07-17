using INFNET.Spotfy.Domain.Entities;
using INFNET.Spotfy.Domain.Repository;
using INFNET.Spotfy.Infra.Database;
using INFNET.Spotfy.Repository.SqlServer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Repository.SqlServer.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context) 
            : base(context)
        {

        }

        public async Task<IEnumerable<Album>> GetAll()
        {
            return await Task.FromResult(this._set.Include(x=>x.Musicas).AsEnumerable());
        }
    }
}
