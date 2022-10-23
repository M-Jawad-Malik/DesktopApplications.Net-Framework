CREATE TABLE [dbo].[loginifo] (
    [usrnm] VARCHAR (30) NULL,
    [pass]  VARCHAR (30) NOT NULL,
    UNIQUE NONCLUSTERED ([usrnm] ASC)
);

