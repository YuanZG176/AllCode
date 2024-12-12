select lastname,state 
from customers
where state = 'FL';



select title,retail 
from books
where retail > 55;

select title,pubid
from books
where pubid between 1 and 3;

select title,pubid 
from books
where pubid in (1,2,5);

select lastname 
from customers
where lastname like 'P%';


select title,pubid,category
from books
where pubid  = 3 and category = 'COMPUTER';


select title,pubid,category
from books
where pubid = 3 or category ='COMPUTER';


select * from books
where category ='FAMILY LIFE'
OR PUBID = 4
and cost > 15;


select * from books
where (category ='FAMILY LIFE'
OR PUBID = 4)
and cost > 15;


select order#,shipdate
from orders
where shipdate is null;

--select order#,shipdate
--from orders
--where shipdate = null;


select lastname,firstname,state,city
from customers
where state in('FL','CA')
order by state desc,city;


select lastname,firstname,state,city
from customers
where state in('FL','CA')
order by 3 desc,4;



select title,name 
from books,publisher;


--select * from warehouses;
--
--select isbn,title,location,'    ' Count
--from books cross join warehouses
--order by location,title;


select title,name
from books,publisher
where books.pubid = publisher.pubid;


select * from books;
select * from publisher;

select title,books.pubid,name
from books,publisher
where books.pubid = publisher.pubid;


--select title,pubid,name
--from books,publisher
--where books.pubid = publisher.pubid;


select title,books.pubid,name
from books,publisher
where books.pubid = publisher.pubid
and publisher.pubid = 4;

select c.lastname,c.firstname,b.title
from customers c,orders o, orderitems oi,books b
where c.customer# = o.customer#
and o.order# = oi.order# 
and oi.isbn = b.isbn
order by lastname,firstname;


select title,pubid,name
from publisher natural join books;


select * from publisher;
select * from books;
select title,publisher.pubid,name
from publisher,books;

--select title,p.pubid,name
--from publisher natural join books;


select b.title,pubid,p.name
from publisher p join books b 
using (pubid);

--select b.title,b.pubid,p.name
--from publisher p join books b 
--on p.id = b.pubid;

select * from promotion;

select b.title,p.gift
from books b,promotion p
where b.retail between p.minretail and p.maxretail;


select b.title,p.gift
from books b join promotion p 
 on  b.retail between p.minretail and p.maxretail;
 
 //вта╛╫с
 select r.firstname,r.lastname,c.lastname "Referred"
 from customers c, customers r
 where c.referred = r.customer#;
 
 
 select r.firstname,r.lastname,c.lastname "Referred"
 from customers c join customers r 
 on c.referred = r.customer#;
 
 select c.lastname,c.firstname,o.order#
 from customers c, orders o
 where c.customer# = o.customer#(+)
 order by c.lastname, c.firstname;
 
 
 SELECT c.lastname, c.firstname, o.order#
FROM customers c
LEFT JOIN orders o ON c.customer# = o.customer#
ORDER BY c.lastname, c.firstname;


select ba.authorid
from books b join bookauthor ba
using(isbn)
where category='FAMILY LIFE'
union
select ba.authorid
from books b join bookauthor ba
using (isbn)
where category = 'CHILDREN';



select customer#
from customers
intersect
select customer#
from orders;


select customer#
from customers
minus
select customer#
from orders;