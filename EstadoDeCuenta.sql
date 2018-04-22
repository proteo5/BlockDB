
/****** Object:  Table [dbo].[EstadoDeCuenta]    Script Date: 4/21/2018 8:22:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EstadoDeCuenta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta] [nvarchar](50) NULL,
	[Entrada] [decimal](18, 4) NULL,
	[Salida] [decimal](18, 4) NULL,
	[Saldo] [decimal](18, 4) NULL,
	[Fecha] [datetime2](0) NULL,
	[Nonce] [int] NULL,
	[Hash] [nvarchar](500) NULL,
 CONSTRAINT [PK_EstadoDeCuenta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

