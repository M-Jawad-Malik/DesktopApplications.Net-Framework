CREATE TABLE [dbo].[MonInstStat] (
    [AcNo]      INT    NULL,
    [TPrice]    BIGINT NOT NULL,
    [advnc]     INT    NOT NULL,
    [MInstall]  INT    NOT NULL,
    [DateofReg] DATE   NOT NULL,
    [RePrice]   BIGINT NOT NULL,
    [Discount]  BIGINT NOT NULL,
    [ProRcptNo] INT    NOT NULL,
    PRIMARY KEY CLUSTERED ([ProRcptNo] ASC)
);

