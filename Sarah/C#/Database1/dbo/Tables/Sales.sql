CREATE TABLE [dbo].[Sales] (
    [DateofSl]   DATE          NOT NULL,
    [RcptNo]     INT           NOT NULL,
    [CusNm]      NVARCHAR (30) NOT NULL,
    [CshInst]    VARCHAR (20)  NOT NULL,
    [PrdctNm]    NVARCHAR (35) NOT NULL,
    [PrdctCmpny] NVARCHAR (35) NOT NULL,
    [PrdctCtgry] NVARCHAR (35) NULL,
    [amnt]       BIGINT        NOT NULL
);

