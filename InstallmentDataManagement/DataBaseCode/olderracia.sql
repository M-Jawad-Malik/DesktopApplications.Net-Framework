create table CusPerInfo /*Customer Personal Info*/
(
AcNo int primary key not null,     --Account No
address nvarchar(70) not null,     --address of customer
photo varbinary(max) default null, --photo
Appnm nvarchar(30) not null,	   --applicant name
fathnm nvarchar(30) not null,      --father name
DateofReg date not null,           --date
cnic varchar(15) not null,         --CNIC
phoneno varchar(20) not null,			   --Phone No.
);
alter table CusPerInfo alter column phoneno varchar(20)
create table MonInstStat   /*Monthly Installment Static Data*/
(
AcNo int primary key not null,    --Account No 
TPrice int not null,			  --Total Price
advnc int not null,				  --Advance
MInstall int not null,			  --Monthly Installment
DateofReg date not null,          -- Date of Registration
);
create table MonInstVar    /*Monthly Installment Varing Data*/
(
AcNo int not null,                --Account No.
RcptNo int not null,			  --Reciept No.
blnc int not null,			      --Balance
DateofRec date not null,		  --Date of Reciving installment 
AmntRec int not null              --Amount Reiceved
);
alter table MonInstVar alter column blnc bigint
create table Spon1		    /*Sponser 1*/
(
AcNo int primary key not null,     --Account No. of Associated Customer
nm nvarchar(30) ,		   --Name
cnic varchar(15) ,         --CNIC
phoneno int,			   --Phone No.
address nvarchar(70),     --Address of sponser
);
create table Spon2          /*Sponser 1*/
(
AcNo int primary key not null,     --Account No. of Associated Customer
nm nvarchar(30) ,		   --Name
cnic varchar(15) ,         --CNIC
phoneno int,			   --Phone No.
address nvarchar(70),     --Address of sponser
);
create table ProPurPri     /*Product Purcased Primary Table*/
(
DateofPur date not null,		  --Date of Purchasing
Dlrnm nvarchar(30),				  --Dealer Name
billno int primary key not null,  --Bill No.
amnt int not null				  --Amount Paid to Dealer
);
create table ProPurSec    /*Product Purchased Secondry Table*/
(
billno int not null,  --Bill No.
PrdctNm nvarchar(35) not null,    --Product Name
PrdctCmpny nvarchar(35) not null, --Product Company
PrdctCtgry nvarchar(35),          --Product Category
Quantity int not null,		      --Quantity of Product
);
create table Sales				  /*Daily Sales*/
(
DateofSl date not null,		      --Date of Sale
RcptNo int not null,              --Reciept No.
CusNm nvarchar(30) not null,	  --Customer Name
CshInst varchar(20) not null,	  --Cash Installment
PrdctNm nvarchar(35) not null,    --Product Name
PrdctCmpny nvarchar(35) not null, --Product Company
PrdctCtgry nvarchar(35),          --Product Category
amnt bigint not null default 0				  --Amount Recieved
);
create table ProSolBas          /*Product SoldOut Basic Table*/
(
AcNo int primary key not null,    --Account No. of Associated Customer
PrdctNm nvarchar(35) not null,    --Product Name
PrdctCmpny nvarchar(35) not null, --Product Company
PrdctCtgry nvarchar(35),          --Product Category
DateofSl date not null,		      --Date of Sale
quantity int not null              --Quantity
);
create table ProSolBik       /*Product Info if it is bike*/
(
AcNo int primary key not null,   --Account No. of Associated Customer
EngnNo nvarchar(35) not null,    --Engine No
ChsNo nvarchar(35) not null,     --Chassis No
RegNo nvarchar(35),              --Registration No
);
create table DlyExpndErn      /*Daily Expanditure Earnings*/
(
DateofErn date primary key not null,--Date Earning
Erns bigint not null                --Earned Amount              
);
create table Expns           /*Daily Expenses*/
(
Dtyl varchar(60) not null,       --Details of Expense 
DateofExp date not null,--Date of expense
Amnt bigint not null,                --Expense Amount    
);
create table BkReg
(
DateReg date default  getdate(),       --Date of Entering
AcNo int primary key not null,--Account No. of Associated Customer
Appnm nvarchar(30) not null,	   --applicant name
Amnt  bigint not null,            ---Amount Recieved
PltNo varchar(30) not null,    --Palet No
Rcvd  varchar(5) not null   --Copy Recived or not
);
create table Dbt
(
DateofAR date primary Key not null, --Date of Amount Received
Amnt int not null,					-- Amount
);

create table NewPro          /*Add New Product Detail*/
(
billno int not null,  --Bill No.
PrdctNm nvarchar(35) not null,    --Product Name
PrdctCmpny nvarchar(35) not null, --Product Company
PrdctCtgry nvarchar(35),          --Product Category
Quantity int not null                    --Quantity
);