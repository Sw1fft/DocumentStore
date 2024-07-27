using DocumentStore.Domain.Models.Document;
using DocumentStore.API.DTO.Document;
using AutoMapper;

namespace DocumentStore.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DocumentRequest, DocumentModel>().ReverseMap();
        }
    }
}
