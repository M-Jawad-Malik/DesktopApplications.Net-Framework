CREATE TABLE [dbo].[CusPerInfo] (
    [AcNo]      INT             NULL,
    [address]   NVARCHAR (70)   NULL,
    [photo]     VARBINARY (MAX) DEFAULT (NULL) NULL,
    [Appnm]     NVARCHAR (30)   NOT NULL,
    [fathnm]    NVARCHAR (30)   NULL,
    [DateofReg] DATE            NOT NULL,
    [cnic]      VARCHAR (15)    NULL,
    [phoneno]   VARCHAR (20)    NULL,
    [ProRcptNo] INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([ProRcptNo] ASC)
);


GO
create trigger MonInstStat_CusPerInfo on CusPerInfo 
after delete
as begin
declare @ac int,@rcptno int,@Date date 
select @ac=AcNo,@rcptno=ProRcptNo,@Date=DateofReg 
from deleted
    if (@ac is not null)
	begin
	       delete from MonInstStat where AcNo=@ac and ProRcptNo=@rcptno
		   delete from MonInstvar where AcNo=@ac
		   delete from Spon1 where AcNo=@ac
			delete from Spon2 where AcNo=@ac 
			delete from ProSolBas where AcNo=@ac and ProRcptNo=@rcptno
			delete from ProSolBik where AcNo=@ac and ProRcptNo=@rcptno
			
	end
	else if (@ac is null)
	begin
	       delete from MonInstStat where DateofReg=@Date and ProRcptNo=@rcptno
		   delete from MonInstvar where DateofRec=@Date and RcptNo=@rcptno
			delete from ProSolBas where DateofSl=@Date and ProRcptNo=@rcptno
			delete from ProSolBik where  ProRcptNo=@rcptno
			
	end


 
end