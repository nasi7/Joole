CREATE TABLE [dbo].[Products]
(
	[ModelNumber] VARCHAR NOT NULL PRIMARY KEY,
	[Category] VARCHAR(16),
	[SubCategory] VARCHAR(16),
	[Weight] VARCHAR(8),
	[ModelYear] DATETIME,
	[ManufacturerName] VARCHAR(32),
	[ProductName] VARCHAR(64),
	[UseType] VARCHAR(32),
	[Application] VARCHAR(32),
	[Accessories] VARCHAR(32)
)
