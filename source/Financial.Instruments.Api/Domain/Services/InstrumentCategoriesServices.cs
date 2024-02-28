using AutoMapper;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;
using Financial.Instruments.Api.Domain.Entities;
using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Domain.Interfaces.IServices;
using System.Linq.Expressions;

namespace Financial.Instruments.Api.Domain.Services
{
    public class InstrumentCategoriesServices : IInstrumentCategoriesServices
    {
        private readonly IMapper _mapper;
        private readonly IInstrumentCategoriesRepository _repository;

        public InstrumentCategoriesServices(IMapper mapper, IInstrumentCategoriesRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<InstrumentCategoriesPostDto> Insert(InstrumentCategoriesPostDto product)
        {
            var obj = _mapper.Map<InstrumentCategories>(product);

            var result = await _repository.Insert(obj);

            return _mapper.Map<InstrumentCategoriesPostDto>(result);
        }

        public async Task<bool> Delete(int Id)
        {
            var result = await _repository.Delete(Id);

            return result;
        }

        public async Task<IEnumerable<InstrumentCategoriesGetResultDto>> Find(Expression<Func<InstrumentCategoriesGetDto, bool>> predicate = null)
        {

            var result = await _repository.Find(null);

            return _mapper.Map<IEnumerable<InstrumentCategoriesGetResultDto>>(result);
        }

        public async Task<InstrumentCategoriesGetResultDto> Find(int Id)
        {            

            var result = await _repository.Find(Id);

            return _mapper.Map<InstrumentCategoriesGetResultDto>(result);
        }

        public async Task<InstrumentCategoriesUpdateDto> Update(InstrumentCategoriesUpdateDto product)
        {
            var obj = _mapper.Map<InstrumentCategories>(product);

            var result = await _repository.Update(obj);

            return _mapper.Map<InstrumentCategoriesUpdateDto>(result);
        }
    }
}
