CREATE TABLE [dbo].[ProPurPri] (
    [DateofPur] DATE          NOT NULL,
    [Dlrnm]     NVARCHAR (30) NULL,
    [billno]    INT           NOT NULL,
    [amnt]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([billno] ASC)
);

