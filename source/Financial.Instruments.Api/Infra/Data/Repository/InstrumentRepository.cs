using Financial.Instruments.Api.Domain.Entities;
using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Infra.Data.Context;

namespace Financial.Instruments.Api.Infra.Data.Repository
{
    public class InstrumentRepository : BaseRepository<Instrument>, IInstrumentRepository
    {
        private readonly FinancialContext _context;
        public InstrumentRepository(FinancialContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }
   }
}
