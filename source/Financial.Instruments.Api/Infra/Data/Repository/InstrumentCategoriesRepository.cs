using Financial.Instruments.Api.Domain.Entities;
using Financial.Instruments.Api.Domain.Interfaces.IRepository;
using Financial.Instruments.Api.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Financial.Instruments.Api.Infra.Data.Repository
{
    public class InstrumentCategoriesRepository : BaseRepository<InstrumentCategories>, IInstrumentCategoriesRepository
    {
        private readonly FinancialContext _context;
        public InstrumentCategoriesRepository(FinancialContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }

        public override async Task<IEnumerable<InstrumentCategories>> Find(Expression<Func<InstrumentCategories, bool>> predicate = null)
        {

            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
            _context.ChangeTracker.LazyLoadingEnabled = false;

            if (predicate != null)
            {
                IQueryable<InstrumentCategories> resut = _context.Set<InstrumentCategories>().Where(predicate).AsNoTracking();

                return resut;
            }
            else
            {
                IQueryable<InstrumentCategories> resut = _context.Set<InstrumentCategories>().AsNoTracking();

                return resut;
            }

        }
    }
}
