using DocumentStore.Data.Entities.Document;
using DocumentStore.Domain.Models.Document;
using DocumentStore.Data.Entities;
using DocumentStore.Domain.Models;
using AutoMapper;

namespace DocumentStore.Application.Mapper
{
    public class PofileMapper : Profile
    {
        public PofileMapper()
        {
            CreateMap<UserModel, UserEntity>().ReverseMap();
            CreateMap<DocumentModel, DocumentEntity>().ReverseMap();
        }
    }
}
