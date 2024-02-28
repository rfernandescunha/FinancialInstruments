namespace Financial.Instruments.Api.Domain.Dto.InstrumentCategories
{
    public class InstrumentCategoriesUpdateDto
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public decimal MinValue { get; set; }

        public decimal MaxValue { get; set; }
    }
}
