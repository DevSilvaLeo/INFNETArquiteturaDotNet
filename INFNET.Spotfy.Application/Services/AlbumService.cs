using AutoMapper;
using INFNET.Spotfy.Application.DTO;
using INFNET.Spotfy.Application.Services.Interface;
using INFNET.Spotfy.Domain.Entities;
using INFNET.Spotfy.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application.Services
{
    public class AlbumService : IAlbumServices
    {
        private readonly IAlbumRepository _repository;
        private readonly IMapper _mapper;
        public AlbumService(IAlbumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AlbumOutputDTO> Create(AlbumInputDTO album)
        {
            var result = _mapper.Map<Album>(album);
            await _repository.Salvar(result);
            return _mapper.Map<AlbumOutputDTO>(result);
        }

        public async Task<List<AlbumOutputDTO>> GetAll()
        {
            var result = await _repository.GetAll();
            return _mapper.Map<List<AlbumOutputDTO>>(result);
        }
    }
}
