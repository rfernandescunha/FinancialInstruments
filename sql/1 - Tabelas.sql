USE [dbFinancial]
GO

CREATE TABLE [dbo].[tb_instrument](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MarketValue] [money] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tb_instrument_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[tb_instrument_categories](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[MaxValue] [money] NOT NULL,
	[MinValue] [money] NOT NULL,
 CONSTRAINT [PK_tb_instrument_categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TYPE [dbo].[instrument_list_type] AS TABLE(
	[MarketValue] [money] NOT NULL,
	[Type] [varchar](50) NOT NULL
)
GO