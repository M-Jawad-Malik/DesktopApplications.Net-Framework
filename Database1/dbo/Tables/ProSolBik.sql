CREATE TABLE [dbo].[ProSolBik] (
    [AcNo]      INT           NOT NULL,
    [EngnNo]    NVARCHAR (35) NOT NULL,
    [ChsNo]     NVARCHAR (35) NOT NULL,
    [RegNo]     NVARCHAR (35) NULL,
    [ProRcptNo] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([AcNo] ASC, [ProRcptNo] ASC)
);

