CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] NVARCHAR(450) NOT NULL, 
    [FriendlyName] VARCHAR(50) NOT NULL, 
    [Make] NCHAR(50) NOT NULL, 
    [Model] NCHAR(50) NOT NULL, 
    [Odometer] BIGINT NOT NULL, 
    CONSTRAINT [FK_Vehicle_AspNetUsers] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]) 
)
