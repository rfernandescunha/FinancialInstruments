namespace Financial.Instruments.Api.Domain.Dto.Instrument
{
    public class InstrumentDto : IFinancialInstrumentDto
    {
        public double MarketValue { get; set; }

        public string Type { get; set; }
    }
}
