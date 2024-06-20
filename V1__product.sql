SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[quantity] [int] NULL,
	[description] [varchar](50) NULL,
	[price] [decimal] NULL
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT INTO Product (name, quantity, description, price) VALUES ('Laranja', 2500, 'Fruta', 7.50);

SELECT * FROM Product WHERE id = 2;

ALTER TABLE Product DROP COLUMN price;

ALTER TABLE Product ADD price DECIMAL(10, 2);