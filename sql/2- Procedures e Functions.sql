USE [SimpleTests]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[func_instrument_get]
(
	@MarketValue AS money,
	@Type AS varchar(50)
)
RETURNS varchar(50)
AS
BEGIN
	DECLARE @result varchar(50)	 
	
	SELECT TOP 1 @result = [Description]
	FROM [dbo].[tb_instrument_categories]
	WHERE @MarketValue >= MinValue AND @MarketValue <= MaxValue

	RETURN @result
END
GO

CREATE PROCEDURE [dbo].[sp_get_instruments_category]
	@Instruments [dbo].[instrument_list_type] READONLY
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [MarketValue], [Type], dbo.func_instrument_get([MarketValue], [Type]) AS Category
	INTO #InstrumentCategories
	FROM @Instruments

	INSERT INTO [dbo].[tb_instrument]([MarketValue], [Type], [Category])
	SELECT [MarketValue], [Type], [Category]
	FROM #InstrumentCategories

	SELECT [MarketValue], [Type], [Category]
	FROM #InstrumentCategories
END
GO



