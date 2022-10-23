CREATE TABLE [dbo].[MonInstVar] (
    [AcNo]      INT  NULL,
    [RcptNo]    INT  NOT NULL,
    [blnc]      INT  NOT NULL,
    [DateofRec] DATE NOT NULL,
    [AmntRec]   INT  NOT NULL
);


GO
create trigger Sales_MonInstVar on MonInstVar
after delete  
as begin
Delete  dbo.Sales from dbo.Sales a inner join deleted d on a.amnt=d.AmntRec and a.DateofSl=d.DateofRec and a.RcptNo=d.RcptNo 
end