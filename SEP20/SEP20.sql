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

Alter table Issue
add comments char(100)

Alter table Issue
add Reference char(30)

Alter table Issue
Drop column Reference 

insert into Member values(1,'Richa Sharma',	'2021-06-04'	,5	,50)
insert into Member values(2,'Garima Sen',	'2022-09-20',	3,Null)
insert into Member values(3,'Prerna Sharma',	'2018-06-04'	,Null	,50)
insert into Member values(4,'Rinky',	'2017-06-04',	3,Null)
insert into Member values(5,'Pinky',	'2021-06-04',	3,Null)

select * from Member
insert into Member values(5,'Tinky',	'2021-06-04',100,50)

select * into Member101 from Member
select * into Member102 from Member where 1 = 2
select * from Member101
select * from Member102

insert into Book values(101,'Let us C',	'Denis Ritchie',	450,	'System')
insert into Book values(102,	'Oracle – Complete Ref','Loni',	550	,'Database')
insert into Book values(103,	'Mastering SQL',	'Loni',	250,'	Database')
insert into Book values(104	,'PL SQL-Ref',	'Scott Urman',	750,	'Database')

select * into Book101 from Book where 1 = 2
select* from Book101
select * into Book103 from Book
select * from Book103

insert into Book values(105,  'National Geographic', 'Adis Scott', 1000, ' Science')
 
 update Book
set Cost=300 , Category='RDBMS'
where Book_No=103

select * from Book

Alter table Issue
drop column comments





