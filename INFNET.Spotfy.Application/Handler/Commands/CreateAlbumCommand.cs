using INFNET.Spotfy.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Handler.Commands
{
    public class CreateAlbumCommand : IRequest<CreateAlbumCommandResponse>
    {
        public AlbumInputDTO Album { get; set; }

        public CreateAlbumCommand(AlbumInputDTO album)
        {
            Album = album;
        }
    }
}
