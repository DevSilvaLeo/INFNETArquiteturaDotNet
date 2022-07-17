using INFNET.Spotfy.Application.Handler.Commands;
using INFNET.Spotfy.Application.Handler.Query;
using INFNET.Spotfy.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Handler
{
    public class AlbumHandler : IRequestHandler<CreateAlbumCommand, CreateAlbumCommandResponse>, IRequestHandler<AlbumQueryCommand, GetAlbumResponse>
                                
    {
        private AlbumService _service;

        public AlbumHandler(AlbumService service)
        {
            _service = service;
        }

        public async Task<CreateAlbumCommandResponse> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await _service.Create(request.Album);
            return new CreateAlbumCommandResponse(result);
        }

        public async Task<GetAlbumResponse> Handle(AlbumQueryCommand request, CancellationToken cancellationToken)
        {
            var result = await _service.GetAll();
            return new GetAlbumResponse(result);
        }
    }
}
