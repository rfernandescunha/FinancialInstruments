using AutoMapper;
using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;
using Financial.Instruments.Api.Domain.Entities;

namespace Financial.Instruments.Api.Infra.CrossCutting.AutoMapper
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<Instrument, InstrumentPostDto>().ReverseMap();


            CreateMap<InstrumentCategories, InstrumentCategoriesGetDto>().ReverseMap();
            CreateMap<InstrumentCategories, InstrumentCategoriesGetResultDto>().ReverseMap();
            CreateMap<InstrumentCategories, InstrumentCategoriesPostDto>().ReverseMap();
            CreateMap<InstrumentCategories, InstrumentCategoriesUpdateDto>().ReverseMap();
        }
    }
}
