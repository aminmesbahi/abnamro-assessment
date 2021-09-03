create database ABNAmro_Assessment on primary (
name=Assessment_Data0, -- for better performance, number of files should be equal to number of CPU physical cores
filename='d:\db\Assessment_Data0.mdf', --this drive should be formatted 64K allocation unit size for better performance
size=10mb,
maxsize=1gb,
filegrowth=10%) log on (
name=Assessment_Log,
filename='d:\db\Assessment_Log.ldf',
size=10mb,
maxsize=1gb,
filegrowth=10%);
go
use ABNAmro_Assessment;
go
create schema [queue];
go
create schema [history];
go
create table history.calculations(
Id int primary key identity (1,1),
CalculationHandler uniqueidentifier not null,
GivenValue int not null check (GivenValue between 10 and 99),
CalculationTime int not null check (CalculationTime between 20 and 99 or CalculationTime=-1),
LastStatus nvarchar(15) not null default N'Running',
CreatedDate datetime not null default getdate());
go
create nonclustered index IX_CalculationHistory_CreatedDate on history.calculations(CreatedDate) with (fillfactor=90, pad_index=on);
go
create procedure history.Sp_calculations_Insert @CalculationHandler uniqueidentifier, @GivenValue int
as
insert into history.calculations (CalculationHandler, GivenValue, CalculationTime) values
	(@CalculationHandler, @GivenValue, -1);
go
create procedure history.Sp_calculations_UpdateCalculationTime @CalculationHandler uniqueidentifier, @CalculationTime int
as
update history.calculations set CalculationTime=@CalculationTime
	where CalculationHandler=@CalculationHandler
go
