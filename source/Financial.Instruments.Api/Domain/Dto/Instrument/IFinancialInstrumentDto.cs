namespace Financial.Instruments.Api.Domain.Dto.Instrument
{
    interface IFinancialInstrumentDto
    {
        double MarketValue { get; }
        string Type { get; }
    }
}
