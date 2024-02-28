using AutoMapper;
using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;
using Financial.Instruments.Api.Domain.Entities;

namespace Financial.Instruments.Api.Infra.CrossCutting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<InstrumentPostDto, Instrument>().ReverseMap();

            CreateMap<InstrumentCategoriesGetDto, InstrumentCategories>().ReverseMap();
            CreateMap<InstrumentCategoriesGetResultDto, InstrumentCategories>().ReverseMap();
            CreateMap<InstrumentCategoriesPostDto, InstrumentCategories>().ReverseMap();
            CreateMap<InstrumentCategoriesUpdateDto, InstrumentCategories>().ReverseMap();


        }
    }
}
