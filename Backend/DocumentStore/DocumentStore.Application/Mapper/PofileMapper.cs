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
            CreateMap<UserEntity, UserModel>()
                .ConstructUsing(x => UserModel.Create(x.UserName, x.Email, x.PasswordHash))
                .ReverseMap();
            CreateMap<DocumentEntity, DocumentModel>().ReverseMap();
        }
    }
}
