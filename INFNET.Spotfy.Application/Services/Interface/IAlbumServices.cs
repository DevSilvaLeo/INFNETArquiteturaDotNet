using INFNET.Spotfy.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Services.Interface
{
    public interface IAlbumServices
    {
        Task<AlbumOutputDTO> Create(AlbumInputDTO album);
        Task<List<AlbumOutputDTO>> GetAll();
    }
}
