using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;

namespace Financial.Instruments.Api.Domain.Interfaces.IServices
{
    public interface IInstrumentServices
    {
        Task<InstrumentPostDto> Insert(InstrumentPostDto product);
        Task<IntrumentGetCategoriesResultDto> GetCategories(InstrumentGetDto dto);
    }
}
