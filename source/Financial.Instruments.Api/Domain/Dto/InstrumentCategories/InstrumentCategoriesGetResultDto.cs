namespace Financial.Instruments.Api.Domain.Dto.InstrumentCategories
{
    public class InstrumentCategoriesGetResultDto
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public double MinValue { get; set; }

        public double MaxValue { get; set; }
    }
}
