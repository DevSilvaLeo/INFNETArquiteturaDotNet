using INFNET.Spotfy.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Handler.Commands
{
    public class CreateAlbumCommandResponse
    {
        public AlbumOutputDTO Album { get; set; }
        public CreateAlbumCommandResponse(AlbumOutputDTO album)
        {
            Album = Album;
        }
    }
}
