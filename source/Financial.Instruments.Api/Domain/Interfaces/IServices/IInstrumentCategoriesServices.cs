using Financial.Instruments.Api.Domain.Interfaces.IServices;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;
using System.Linq.Expressions;

namespace Financial.Instruments.Api.Domain.Interfaces.IServices
{
    public interface IInstrumentCategoriesServices
    {
        Task<IEnumerable<InstrumentCategoriesGetResultDto>> Find(Expression<Func<InstrumentCategoriesGetDto, bool>> predicate = null);
        Task<InstrumentCategoriesGetResultDto> Find(int Id);
        Task<InstrumentCategoriesPostDto> Insert(InstrumentCategoriesPostDto product);
        Task<InstrumentCategoriesUpdateDto> Update(InstrumentCategoriesUpdateDto product);
        Task<bool> Delete(int Id);
    }
}
