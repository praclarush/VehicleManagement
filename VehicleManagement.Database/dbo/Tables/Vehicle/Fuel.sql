CREATE TABLE [dbo].[Fuel]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NOT NULL,
    [FuelTypeId] INT NOT NULL, 
    [FuelDate] DATETIME NOT NULL, 
    [Gallons] INT NOT NULL, 
    [CostPerGallon] MONEY NOT NULL, 
    [Notes] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Fuel_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id])
)

GO

CREATE INDEX [IX_Fuel_VehicleID_FuelDate] ON [dbo].[Fuel] ([VehicleId], [FuelDate] DESC)
