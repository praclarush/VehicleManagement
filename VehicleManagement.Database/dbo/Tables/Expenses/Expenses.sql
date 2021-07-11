CREATE TABLE [dbo].[Expenses]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [VehicleId] INT NOT NULL, 
    [Expense] VARCHAR(100) NOT NULL,     
    [ExpenseDate] DATETIME NOT NULL,
    [Cost] MONEY NOT NULL, 
    [Notes] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Expenses_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicle]([Id])
)

GO

CREATE INDEX [IX_Expenses_VehicleId_ExpenseDate] ON [dbo].[Expenses] ([VehicleId], [ExpenseDate] DESC)
