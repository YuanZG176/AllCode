select length('abcx') from dual;

select length('原志国') from dual;

select lpad('firstname',12,' ') from dual;

select lpad('firstname',12,'*') from dual;

select rpad('firstname',12,'*') from dual;

select lastname,address,ltrim(address,'P.0. BOX')
from customers;


select address ,replace(address,'P.O. BOX','POST OFFICE')
from customers
where state = 'FL';

select round(59.94,1) from dual;
select round(59.95,1) from dual;

select title,retail ,round(retail,1),round(retail,2),round(retail,-1)
from books;

select trunc(30.95) from dual;

select title,retail, trunc(retail,1),trunc(retail,0),trunc(retail,-1)
from books;

select 235/16 from dual;

SELECT TRUNC(235/16, 0) AS lbs, MOD(235, 16) AS remainder
FROM dual;

select abs(12-15) from dual;


select * from books;

select title,
       concat(round(((retail - cost) / cost) * 100),'%') as markup_percentage
from books;


SELECT title,lpad(cost,12,'*')  
FROM books;

select title,pubdate, month_between(orderdate,pubdate) from books;

select title,pubdate,add_months('01-12月-08',18)"Renegotiate Date",
add_months(pubdate,84)"Drop Date"
from books
where category = 'COMPUTER'
ORDER BY "Renegotiate Date";

