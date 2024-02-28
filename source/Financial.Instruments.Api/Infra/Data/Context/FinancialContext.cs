using Financial.Instruments.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Financial.Instruments.Api.Infra.Data.Context
{

    public class FinancialContext : DbContext
    {
        public FinancialContext() { }
        public FinancialContext(DbContextOptions<FinancialContext> options) : base(options) { }

        public DbSet<InstrumentCategories> InstrumentCategories { get; set; }

        public DbSet<Instrument> Instruments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SEED DATA
            modelBuilder.Entity<InstrumentCategories>().HasData(new InstrumentCategories
            {
                Id = 1,
                Description = "Low Value",
                MinValue = 0,
                MaxValue = 999999
            });
            modelBuilder.Entity<InstrumentCategories>().HasData(new InstrumentCategories
            {
                Id = 2,
                Description = "Medium Value",
                MinValue = 1000000,
                MaxValue = 5000000
            });
            modelBuilder.Entity<InstrumentCategories>().HasData(new InstrumentCategories
            {
                Id = 3,
                Description = "High Value",
                MinValue = 5000001,
                MaxValue = 1000000000
            });

        }

    }
    
}
