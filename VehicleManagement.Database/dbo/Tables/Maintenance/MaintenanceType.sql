CREATE TABLE [dbo].[MaintenanceType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [VehicleId] INT NOT NULL,
    [TypeName] VARCHAR(50) NOT NULL, 
    [FriendlyName] VARCHAR(50) NOT NULL,
    [IsDeletable ] BIT NOT NULL, 
    [IsDeleted] BIT NOT NULL, 
    CONSTRAINT [FK_MaintenanceType_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id])
)

GO

CREATE INDEX [IX_MaintenanceType_VehicleId] ON [dbo].[MaintenanceType] ([VehicleId])
