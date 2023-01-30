create database inventoryManagementSystem;
use inventoryManagementSystem;

Create Table Product_Master(
Productid int primary key identity(1,1),
ProductName varchar(50),
AvailableQty bigint);

Create Table Users_tbl(
UserID int primary key identity(1,1),
UserName varchar(50),
password varchar(25),
FullName varchar(255),
IsActive bit,
Category varchar(50));

Create Table Transaction_tbl(
TransactionID int primary key identity(1,1),
TransactionDate DATE,
ProductID int,
TransactionType varchar(5),
Qty int,
UpdatedBy int);

Alter table Transaction_tbl alter column updatedBy int null;
Alter table Transaction_tbl alter column TransactionType varchar(5) not null;
Alter table Transaction_tbl add foreign key(productid) references Product_Master(productid);
Alter table Product_Master alter column ProductName varchar(50) not null;
Alter table Product_Master alter column AvailableQty bigint not null;


insert into Users_tbl values 
('Manoj','Manoj#2001','Manoj Kumar',1,'Admin'),
('Ram','abcd@432','Ram kumar',1,'Labour'),
('Suresh','Suru$123','Suresh Raj',1,'Admin'),
('Mathew','mathew@07','Mathew',1,'Staff');

insert into Product_Master values ('switch',2000),('bulbs',1500),
('Tables',500),('Nails',2030),('Screw',100);

insert into Transaction_tbl(TransactionDate,TransactionType) values
('2020-06-01','in'),('2020-12-12','out'),('2021-01-02','in'),('2021-03-20','in');

select * from Users_tbl;

select *from Product_Master;
select * from Transaction_tbl;
truncate table Transaction_tbl;

select Fullname,category from Users_tbl;
select Productname from Product_Master where Availableqty<500;
select Transactiondate,Transactiontype from Transaction_tbl;
select * from Transaction_tbl where Transactiontype='in';
select * from Product_Master where ProductName = 'Nails';

create table dummy(
username varchar(50) primary key,
rollnum int);

insert into dummy values('manoj',22),('kumar',43),('ram',6),('sam',21),('charan',19),
('bose',34),('hari',30);

alter table dummy alter column rollnum int not null;
select * from dummy;
