using DocumentStore.API.DTO.Document.Request;
using DocumentStore.Domain.Models.Document;
using AutoMapper;

namespace DocumentStore.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DocumentRequestDTO, DocumentModel>()
                .ConstructUsing(x => DocumentModel.Create(
                    x.CreatedAt, 
                    x.DocumentName, 
                    ContentModel.Create(
                        x.ContentRequest.Title,
                        x.ContentRequest.CarName,
                        x.ContentRequest.CarModel,
                        x.ContentRequest.CarYear,
                        x.ContentRequest.CarColor,
                        x.ContentRequest.CarPrice)))
                .ReverseMap();
        }
    }
}
