DECLARE @finantialInstruments [dbo].[FinancialInstrumentListType]

INSERT @finantialInstruments ([MarketValue], [Type]) VALUES (800000, 'Stock')
INSERT @finantialInstruments ([MarketValue], [Type]) VALUES (1500000, 'Bond')
INSERT @finantialInstruments ([MarketValue], [Type]) VALUES (6000000, 'Derivative')
INSERT @finantialInstruments ([MarketValue], [Type]) VALUES (300000, 'Stock')

EXEC [dbo].[sp_classify_financial_instruments] @finantialInstruments