CREATE TABLE [dbo].[Vacumms]
(
	[ModelNumber] VARCHAR(64) NOT NULL PRIMARY KEY,
	[HasBag] BIT,
	[Power] VARCHAR(8),
	[Voltage] VARCHAR(8),
	[Amperes] VARCHAR(8),
	[CordLength] VARCHAR(8),
	[Capacity] VARCHAR(8),
	[Dimension] VARCHAR(32)
)
