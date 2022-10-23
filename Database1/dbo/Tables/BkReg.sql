CREATE TABLE [dbo].[BkReg] (
    [DateReg] DATE          DEFAULT (getdate()) NULL,
    [AcNo]    INT           NOT NULL,
    [Appnm]   NVARCHAR (30) NOT NULL,
    [Amnt]    BIGINT        NOT NULL,
    [PltNo]   VARCHAR (30)  NOT NULL,
    [Rcvd]    VARCHAR (5)   NOT NULL,
    PRIMARY KEY CLUSTERED ([AcNo] ASC)
);

