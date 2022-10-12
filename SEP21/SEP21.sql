use shopping
select  category,count(Book_No) from book 
group by category

select * from book
select * from issue

select book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no
order by issuedcount desc 

select* from member

select max(Penalty_Amount) Max ,min(penalty_amount) Min,sum(penalty_amount) Sum,avg(penalty_Amount) Avg  from Member

select member_id,count(lib_issue_id) from issue
group by member_id
having count(lib_issue_id)> 1

select member_id, book_no,count(lib_issue_id) Issuedcount from issue 
group by book_no,Member_Id
order by issuedcount desc

select month(issue_date) month,count(book_no) bookcount from Issue
group by month(issue_date)
order by bookcount desc

select book_no from issue 
where issue_date is null


select m.Member_Id,i.Member_Id "DEPT"
from member m inner join issue i
on m.Member_Id=i.Member_Id

select member_id ,max(lib_issue_id) Max,min(lib_issue_id) Min from issue
group by Member_Id

select * from issue
where month(issue_date) 
in (12,9)
use shopping

select b.Book_No,b.book_name,i.Issue_Date,b.Category
from Book b inner join issue i
on b.Book_No=i.Book_No
where month(issue_date)=9 and b.Category='database'

select m.Member_Id,m.Member_Name,count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.Member_Id=i.Member_Id
group by rollup(m.Member_Id,m.Member_Name)
order by Issuecount desc


select b.Book_No,b.book_name,i.Issue_Date,i.Return_date,b.Author
from Book b inner join issue i
on b.Book_No=i.Book_No
where b.Author= 'Loni'

select m.Member_Id,m.Member_Name,count(i.lib_issue_id) Issuecount
from member m inner join issue i
on m.Member_Id=i.Member_Id


 select m.Member_Id,m.Member_Name
  from member m inner join  issue i
  on  m.Member_Id=i.Member_Id
  inner join Book b
  on i.Book_No=b.Book_No
  where b.Category='Database'

  select category,max(cost) from book
  group by category

  select distinct i.* from issue i,member m where i.issue_date not between m.acc_open_date and i.return_date

  select member_id from member
  except
  select member_id from issue

  select * from issue
  select * from member

use northwind
  
  select * from Customers

  select distinct  count(Customerid) from Customers

   select distinct  count(Customerid) from Customers
   where ContactName like 'b%'  

   select distinct  count(Customerid) from Customers
   where ContactName like '%s%'  

   select distinct city, count(Customerid) from Customers
   group by City



  









