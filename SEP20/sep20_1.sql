use Shopping
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7001	,101,	1,'2021-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7002,	102,	2,'2010-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7004	,101,	1,	'2001-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7005	,104,	2,	'2020-09-06')
insert into Issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date)values(7006,	101,	3,	'2019-09-06')
select * from Issue
update Member
set Penalty_Amount=100
where member_name='garima sen'
select * from member
update Issue
set Return_date='2020-09-21'
where Lib_Issue_Id=7004 

update Issue
set Return_date='2020-09-21'
where Lib_Issue_Id=7005

delete from Issue
where Member_Id=1 And Issue_Date < '2022-02-09'

delete from Book
where Category !='RDBMS' and Category != 'Database'

Drop table Member101
Drop table Book101

select * from Book
select * from Member
select * from Issue

Select * from member
where Acc_Open_Date='2018-06-04'

select * from member

select * from Book 
where Author='Loni' and Cost < 600



select * from Issue
update issue
set Return_date='2006-12-31'
where Member_Id !=7005 and Member_Id !=7006

select * from Book
where Cost between 500 and 700 and Category= 'Database'


SELECT * FROM Book 
WHERE category in ('Science','Database', 'Fiction','Management');SELECT * FROM member ORDER BY penalty_amount DESC;select * from book order by category asc,cost desc;select * from book where Book_Name like '%sql%'SELECT * FROM MEMBER where MEMBER_NAME like'R%'OR
MEMBER_NAME LIKE'G%' AND MEMBER_NAME LIKE '%I%';

select upper(book_name) from book
order by book_name desc;select * from issue order by issue_date SELECT SUM(MAX_BOOKS_ALLOWED)
FROM MEMBER
WHERE MEMBER_ID=1 

select sum(penalty_amount) from member

select sum(cost) from Book 
where category ='Database'

select min(cost) from book

select issue_date from issue where Lib_Issue_Id = 7002

select * from Issue

select avg(cost) from book where Category='Database'
