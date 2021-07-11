CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(450) NOT NULL, 
    [FriendlyName] VARCHAR(50) NOT NULL, 
    [VehicleTypeId] int NOT NULL,
    [Make] NCHAR(50) NOT NULL, 
    [Model] NCHAR(50) NOT NULL, 
    [Odometer] BIGINT NOT NULL, 
    [VIN] VARCHAR(17) NULL, 
    [LicensePlate] VARCHAR(20) NULL, 
    [Notes] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Vehicle_AspNetUsers] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]) 
)

GO

CREATE INDEX [IX_Vehicle_UserId] ON [dbo].[Vehicle] ([UserId])

GO