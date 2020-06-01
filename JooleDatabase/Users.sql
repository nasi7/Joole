CREATE TABLE [dbo].[Users]
(
	[Username] VARCHAR(128) NOT NULL PRIMARY KEY,
	[Email] VARCHAR(256),
	[Password] VARCHAR(256) NOT NULL,
	[Image] IMAGE
)
