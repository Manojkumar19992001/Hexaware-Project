Create database inventoryManagementSystem;
use  inventoryManagementSystem;

Create Table Users(
UserID int primary key identity(1,1),
UserName varchar(50),
password varchar(25),
FullName varchar(255),
IsActive bit,
Category varchar(50));

Create Table [Product Master](
Productid int primary key identity(1,1),
ProductName varchar(50),
AvailableQty bigint);

Create Table [Transaction](
TransactionID int primary key identity(1,1),
TransactionDate date,
ProductID int,
TransactionType varchar(5),
Qty int,
UpdatedBy int);
