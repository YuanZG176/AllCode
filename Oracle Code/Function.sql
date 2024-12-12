Create Table department
 (deptno NUMBER(2),
  dname VARCHAR2(20));
INSERT INTO department
 VALUES (10, 'General Admin');
INSERT INTO department
 VALUES (20, 'Engineering');
INSERT INTO department
 VALUES (30, 'Support');
Create table Books_1
(ISBN VARCHAR2(10), 
Title VARCHAR2(30), 
PubDate DATE, 
Retail NUMBER (5,2), 
Category VARCHAR2(12),
  CONSTRAINT books_1_isbn_pk PRIMARY KEY(isbn)); 
 INSERT INTO BOOKS_1
VALUES ('8843172113','DATABASE IMPLEMENTATION',('04-1月-05'),55.95, 'COMPUTER'); 
INSERT INTO BOOKS_1
VALUES ('3437212490','COOKING WITH MUSHROOMS','28-2月-06',19.95, 'COOKING'); 
INSERT INTO BOOKS_1 
VALUES ('3957136468','HOLY GRAIL OF ORACLE','31-12月-05',65.95, 'BUSINESS'); 
COMMIT;
Create table Books_2
(ISBN VARCHAR2(10), 
Title VARCHAR2(30), 
PubDate DATE, 
Retail NUMBER (5,2), 
Category VARCHAR2(12),
  CONSTRAINT books_2_isbn_pk PRIMARY KEY(isbn)); 
INSERT INTO BOOKS_2
VALUES ('8843172113','DATABASE IMPLEMENTATION','04-6月-05',55.95, 'COMPUTER'); 
INSERT INTO BOOKS_2 
VALUES ('3437212490','COOKING WITH MUSHROOMS','28-2月-06',29.95, 'COOKING'); 
INSERT INTO BOOKS_2 
VALUES ('3957136468','HOLY GRAIL OF ORACLE','31-12月-05',75.95, 'COMPUTER'); 
INSERT INTO BOOKS_2
VALUES ('1915762492','HANDCRANKED COMPUTERS','21-1月-05',25.00, 'COMPUTER'); 
INSERT INTO BOOKS_2
VALUES ('0299282519','THE WOK WAY TO COOK','11-9月-00',28.75, 'COOKING'); 
COMMIT;

select sum((paideach-cost)*quantity) "Total Profit"
from orderitems,orders,books
where books.isbn = orderitems.isbn
and orderitems.order# = orders.order#
and customer# = 1017;


select * from books;
select * from orders;
select * from orderitems;

select category, to_char(avg(retail - cost),'999.99') "Profit"
from books 
group by category;

select min(retail) from books where category = 'COMPUTER' group by category ;

select * from books;


select * from books;

select pubid,category ,avg(retail) 
from books
where category in ('CHILDREN','COMPUTER')
group by pubid, category 
having avg(retail) > 50;

select * from orders;

select avg(总值) as 平均
from
(select sum(shipcost) as 总值 from orders group by order#);


select 平均,总值
from 
(
    select avg(总值) as 平均 from
        (select sum(shipcost) as 总值 from orders group by order#)
),
    (select sum(shipcost) as 总值 from orders group by order#);



select * from customers;
select * from orders;
select * from orderitems;



select  distinct orderitems.order#,customers.lastname,customers.firstname
from customers,orders,orderitems
where STATE IN ('GA','FL')
and customers.customer# = orders.customer#
and orderitems.order# = orders.order#
group by  orderitems.order#,customers.lastname,customers.firstname
having sum(orderitems.quantity * orderitems.paideach)   > 80;











