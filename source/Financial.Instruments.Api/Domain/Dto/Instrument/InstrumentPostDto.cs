namespace Financial.Instruments.Api.Domain.Dto.Instrument
{
    public class InstrumentPostDto : IFinancialInstrumentDto
    {
        public double MarketValue { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }
    }
}
