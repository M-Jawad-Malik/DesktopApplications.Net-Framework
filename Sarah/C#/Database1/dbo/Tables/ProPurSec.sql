CREATE TABLE [dbo].[ProPurSec] (
    [billno]     INT           NOT NULL,
    [PrdctNm]    NVARCHAR (35) NOT NULL,
    [PrdctCmpny] NVARCHAR (35) NOT NULL,
    [PrdctCtgry] NVARCHAR (35) NULL,
    [Quantity]   INT           NOT NULL
);


GO
create trigger NewPro_ProSolSec on ProPurSec
after delete
as begin
declare @billno int
select @billno=billno from deleted
delete  from NewPro  where  NewPro.billno=@billno
end