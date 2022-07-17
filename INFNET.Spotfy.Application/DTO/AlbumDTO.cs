using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.DTO
{
    public record AlbumInputDTO(string Nome, string Descricao, string Banda, DateTime DataLancamento, string Capa);
    public record AlbumOutputDTO(Guid Id, string Nome, string Banda, string Descricao, DateTime DataLancamento, string Capa);
    public record MusicaInputDTO(string Nome, int Duracao);
    public record MusicaOutputDTO(string Nome, string Duracao);
}
