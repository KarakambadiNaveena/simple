create database Shopping
use Shopping
create table customer
(
custid int,
custname varchar(20),
city varchar(20),
state varchar(20)
)
create table products
(
prodid int,
prodname varchar(20),
unitprice float,
unitofmeasurement float,
qtyinstock int
)
create table sales_header
(
invono int,
invdate date,
invamt float,
dispercent float
)
create table sales_detail
(
invno int primary key ,
custid int ,
prodid int ,
qtysold int
)
alter table sales_detail
drop column qtysold
alter table sales_detail
add qty int

use Shopping
create table Member
(
Member_Id numeric(5),
Member_Name	Char(25),
Acc_Open_Date date,
Max_Books_Allowed numeric(2),
Penalty_Amount numeric(7,2)
)
create table Book
(
Book_No numeric(6),
Book_Name varchar(30),
Author char(30),
Cost numeric(7,2),
Category char(10)
)
create table Issue
(
Lib_Issue_Id numeric(10),
Book_No numeric(6),
Member_Id numeric(5),
Issue_Date	Date,
Return_date	Date
)
select * from Member
select * from Book
select * from Issue
