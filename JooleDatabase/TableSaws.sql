CREATE TABLE [dbo].[TableSaws]
(
	[ModelNumber] VARCHAR(64) NOT NULL PRIMARY KEY,
	[Power] VARCHAR(8),
	[Voltage] VARCHAR(8),
	[Amperes] VARCHAR(8),
	[Dimension] VARCHAR(32),
	[BladeHeight] VARCHAR(8)
)
