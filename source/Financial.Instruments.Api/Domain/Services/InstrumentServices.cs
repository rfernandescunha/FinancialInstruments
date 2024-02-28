using AutoMapper;
using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Entities;
using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Domain.Interfaces.IServices;

namespace Financial.Instruments.Api.Domain.Services
{
    public class InstrumentServices : IInstrumentServices
    {
        private readonly IMapper _mapper;
        private readonly IInstrumentRepository _repository;
        private readonly IInstrumentCategoriesServices _categoriesServices;

        public InstrumentServices(IMapper mapper, IInstrumentRepository repository, IInstrumentCategoriesServices categoriesServices)
        {
            _mapper = mapper;
            _repository = repository;
            _categoriesServices = categoriesServices;
        }

        public async Task<InstrumentPostDto> Insert(InstrumentPostDto product)
        {
            var obj = _mapper.Map<Instrument>(product);

            var result = await _repository.Insert(obj);

            return _mapper.Map<InstrumentPostDto>(result);
        }

        public async Task<IntrumentGetCategoriesResultDto> GetCategories(InstrumentGetDto dtos)
        {
            var result = new IntrumentGetCategoriesResultDto();

            foreach (var item in dtos.Instruments) 
            {
                var category = await GetCategoryAsync(item);

                var obj = new InstrumentPostDto()
                {
                    MarketValue = item.MarketValue,
                    Type        = item.Type,
                    Category    = category != null ? category : "Not Found Category"
                };

                await Insert(obj);

                result.instrumentCategories.Add(obj.Category);
            }

            return result;
        }

        private async Task<string> GetCategoryAsync(InstrumentDto dto)
        {
            var categories = await _categoriesServices.Find();

            foreach (var category in categories.OrderBy(v => v.MaxValue))
            {
                if (dto.MarketValue < category.MaxValue)
                    return category.Description;
            }

            return "High Value";
        }

    }
}
