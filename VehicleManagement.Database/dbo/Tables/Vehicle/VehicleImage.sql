CREATE TABLE [dbo].[VehicleImage]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NULL, 
    [ImageData] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [FK_VehicleImage_Vehicle] FOREIGN KEY (VehicleID) REFERENCES [Vehicle]([Id])
)

GO

CREATE INDEX [IX_VehicleImage_VehicleId] ON [dbo].[VehicleImage] ([VehicleId])
