CREATE TABLE [dbo].[TVs]
(
	[ModelNumber] VARCHAR(64) NOT NULL PRIMARY KEY,
	[Power] VARCHAR(8),
	[Voltage] VARCHAR(8),
	[ScreenSize] VARCHAR(8),
	[Dimension] VARCHAR(32),
	[Resolution] VARCHAR(8),
	[InputTypes] VARCHAR(32),
	[OutputTypes] VARCHAR(32)
)
