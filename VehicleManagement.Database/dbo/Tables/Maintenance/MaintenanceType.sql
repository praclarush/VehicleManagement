CREATE TABLE [dbo].[MaintenanceType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TypeName] VARCHAR(50) NOT NULL, 
    [FriendlyName] VARCHAR(50) NOT NULL,
    [IsDeletable ] BIT NOT NULL, 
    [IsDeleted] BIT NOT NULL
)
