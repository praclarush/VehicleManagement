CREATE TABLE [dbo].[VehicleImage]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VehicleId] INT NULL, 
    [ImageData] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [FK_VehicleImage_Vehicle] FOREIGN KEY (VehicleID) REFERENCES [Vehicle]([Id])
)
