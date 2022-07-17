using AutoMapper;
using INFNET.Spotfy.Application.DTO;
using INFNET.Spotfy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<MusicaInputDTO, Musica>()
                .ForPath(x=>x.Duracao.Value, f=>f.MapFrom(m=>m.Duracao));

            CreateMap<Musica, MusicaOutputDTO>()
                .ForMember(x => x.Duracao, f => f.MapFrom(m => m.Duracao.FormatValue));

            CreateMap<AlbumInputDTO, Album>()
                .ForPath(x => x.Banda.Nome, f => f.MapFrom(m => m.Banda));

            CreateMap<Album, AlbumOutputDTO>()
                .ForMember(x => x.Banda, f => f.MapFrom(m => m.Banda.Nome));

        }
    }
}
