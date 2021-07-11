CREATE TABLE [dbo].[Maintenance]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VehicleId] INT NOT NULL,
    [MaintenanceTypeId] INT NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [FrequencyTypeId] INT NOT NULL, 
    [Frequency] INT NOT NULL, 
    [CreatedDate] DATETIME NOT NULL, 
    [IsRecurring] BIT NOT NULL, 
    CONSTRAINT [FK_Maintenance_MaintenanceType] FOREIGN KEY ([MaintenanceTypeId]) REFERENCES [MaintenanceType]([Id]), 
    CONSTRAINT [FK_Maintenance_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id])
)

GO


CREATE INDEX [IX_Maintenance_VehicleId_CreatedDate] ON [dbo].[Maintenance] ([VehicleId], [CreatedDate] DESC)
