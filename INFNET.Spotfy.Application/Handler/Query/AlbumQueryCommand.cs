using INFNET.Spotfy.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Handler.Query
{
    public class AlbumQueryCommand : IRequest<GetAlbumResponse>
    {
    }

    public class GetAlbumResponse
    {
        public List<AlbumOutputDTO> Albums { get; set; }

        public GetAlbumResponse()
        {

        }
        public GetAlbumResponse(List<AlbumOutputDTO> albums)
        {
            this.Albums = albums;
        }
    }
}
