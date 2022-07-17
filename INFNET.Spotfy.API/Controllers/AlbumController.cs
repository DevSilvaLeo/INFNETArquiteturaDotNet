using INFNET.Spotfy.Application.DTO;
using INFNET.Spotfy.Application.Handler.Commands;
using INFNET.Spotfy.Application.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INFNET.Spotfy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "user-policy")]
    public class AlbumController : ControllerBase
    {
        public IMediator Handler { get; }
        public AlbumController(IMediator handler)
        {
            Handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> Inserir(AlbumInputDTO album)
        {
            var result = await this.Handler.Send(new CreateAlbumCommand(album));
            return Created($"/{result.Album.Id}", result.Album);
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var result = await this.Handler.Send(new AlbumQueryCommand());
            return Ok(result.Albums);
        }
    }
}
