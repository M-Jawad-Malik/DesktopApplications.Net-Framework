CREATE TABLE [dbo].[ProSolBas] (
    [AcNo]       INT           NULL,
    [PrdctNm]    NVARCHAR (35) NOT NULL,
    [PrdctCmpny] NVARCHAR (35) NOT NULL,
    [PrdctCtgry] NVARCHAR (35) NULL,
    [DateofSl]   DATE          NOT NULL,
    [quantity]   INT           NOT NULL,
    [ProRcptNo]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ProRcptNo] ASC)
);

