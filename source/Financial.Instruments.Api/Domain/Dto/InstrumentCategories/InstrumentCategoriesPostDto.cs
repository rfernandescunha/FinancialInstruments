namespace Financial.Instruments.Api.Domain.Dto.InstrumentCategories
{
    public class InstrumentCategoriesPostDto
    {
        public string Description { get; set; }

        public decimal MinValue { get; set; }

        public decimal MaxValue { get; set; }
    }
}
