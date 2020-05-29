CREATE TABLE [dbo].[Fans]
(
	[ModelNumber] VARCHAR(64) NOT NULL PRIMARY KEY,
	[Airflow] VARCHAR(8),
	[Power] VARCHAR(8),
	[Voltage] VARCHAR(8),
	[Speed] VARCHAR(8),
	[NumberOfSpeeds] VARCHAR(8),
	[SweepDiameter] VARCHAR(8),
	[SpeedSound] VARCHAR(8),
	[Height] VARCHAR(8)
)
