create table dept (
    deptno number(6) not null primary key, 
    dname varchar2(20) not null,
    loc varchar2(13) not null,
    constraint dept_positive_value_check check (deptno >= 0)
);

create table emp (
    empno number(6) not null primary key,
    ename varchar2(20) not null,
    job varchar2(9) not null,
    mgr number(6),
    hiredate date not null,
    sal decimal(7,2),
    comm decimal(7,2),
    deptno number(6) not null,
    constraint emp_deptno_fk foreign key (deptno) references dept(deptno),
    constraint emp_empno_check check (empno > 0),
    constraint emp_sal_check check (sal >= 0),
    constraint emp_comm_check check (comm >= 0),
    constraint emp_deptno_check check (deptno > 0)
);

alter table emp modify job varchar2(20);

create table salgrade (
    grade number(6) not null,
    losal decimal(17,2) not null,
    hisal decimal(17,2) not null,
    constraint salgrade_grade_check check (grade > 0)
);

create table jobhistory (
    recordid number(6) primary key,
    empno number(6) not null,
    deptno number(6) not null,
    startdate date not null,
    enddate date,
    position varchar2(20) not null,
    constraint jobhistory_empno_fk foreign key (empno) references emp(empno),
    constraint jobhistory_deptno_fk foreign key (deptno) references dept(deptno)
);

create table worklogs (
    logid number(6) primary key,
    empno number(6) not null,
    workdate date not null,
    hoursworked decimal(5,2) not null,
    taskdescription clob,
    constraint worklogs_empno_fk foreign key (empno) references emp(empno)
);

--drop table dept;
--drop table emp;
--drop table salgrade;
--drop table jobhistory;
--drop table worklogs;
desc dept;

select * from dept;
select * from emp;
select * from salgrade;
select * from jobhistory;
select * from worklogs;

--dept 表
insert into dept values(10, 'accounting', 'NEW YORK');
insert into dept values(20, 'research', 'DALLAS');--达拉斯
insert into dept values(30, 'sales', 'CHICAGO');--芝加哥
insert into dept values(40, 'operations', 'BOSTON');
insert into dept values (50, 'marketing', 'LOS ANGELES');--洛杉矶
insert into dept values (60, 'human resources', 'SAN FRANCISCO');--旧金山
insert into dept values (70, 'enginering', 'SEATTLE');




delete from emp;
--emp 表
INSERT INTO emp values (7369, 'XICAIYAN', 'Teacher', null, TO_DATE('1990-12-17', 'YYYY-MM-DD'), 800.00, NULL, 20);
insert into emp values(7156,'ZHANGZHENGHAN','COUNSELLOR',null,TO_DATE('1993-1-21', 'YYYY-MM-DD'), 2653.00, 1000.00,60);
insert into emp values(7025,'WEILEI','DEAN',null,TO_DATE('1996-7-21', 'YYYY-MM-DD'), 5000.00, 500.00,70);
insert into emp values(7125,'SHENGANG','DIRECTOR',null,TO_DATE('1995-8-16', 'YYYY-MM-DD'), 4000.00, 900.00,70);
insert into emp values(7499, 'NINGFANGMEI', 'SALESMAN', 7698, to_date('1991-2-20', 'YYYY-MM-DD'), 1600.00, 300.00, 30);  
insert into emp values(7521, 'SONGHONGLI', 'SALESMAN', 7698, TO_DATE('1991-2-22', 'YYYY-MM-DD'), 1250.00, 500.00, 30); 
insert into emp values(7566, 'CAIHANXIAO', 'MANAGER', 7839, TO_DATE('1991-4-2', 'YYYY-MM-DD'), 2975.00,NULL,20);
insert into emp values(7654, 'ZHOUBOHANG', 'SALESMAN', 7698, TO_DATE('1991-9-28', 'YYYY-MM-DD'),1250.00,1400.00,30);  
insert into emp values(7698, 'MAJUNXIAO','MANAGER', 7839,TO_DATE('1991-5-1', 'YYYY-MM-DD'), 2850.00,NULL,30);
insert into emp values(7782, 'MAYIQING','MANAGER', 7839, TO_DATE('1991-6-9', 'YYYY-MM-DD'),2450.00,NULL,10);  
insert into emp values(7788, 'YUANZHIGUO','ANALYST',7566, TO_DATE('1997-4-19', 'YYYY-MM-DD'),3000.00,NULL,20);  
insert into emp values(7839, 'DUZHONGMING','PRESIDENT',NULL,TO_DATE('1991-11-17', 'YYYY-MM-DD'),5000.00,NULL,10);  
insert into emp values(7844, 'GENGJINQI', 'SALESMAN',7698, TO_DATE('1991-9-8', 'YYYY-MM-DD'), 1500.00, NULL,30);  
insert into emp values(7900, 'LIUYINQIU','CLERK',7698, TO_DATE('1991-12-3', 'YYYY-MM-DD'),950.00,NULL,30);
insert into emp values(7902, 'FANGYIYANG', 'ANALYST',7566,TO_DATE('1991-12-3', 'YYYY-MM-DD'),3000.00, NULL,20);  
insert into emp values(7934,'HEKAIWEI','CLERK',7782,TO_DATE('1992-1-23', 'YYYY-MM-DD'), 1300.00, NULL,10);
insert into emp values(7952,'LITIANCHENG','CLERK',7782,TO_DATE('1996-8-23', 'YYYY-MM-DD'), 2350.00, NULL,60);
insert into emp values(7256,'SUNJUNBO','MANAGER',7844,TO_DATE('1995-4-23', 'YYYY-MM-DD'), 1658.00, NULL,50);
insert into emp values(7361,'XUZIQUN','MANAGER',7900,TO_DATE('1993-3-28', 'YYYY-MM-DD'), 5968.00, NULL,60);
insert into emp values(7253,'XIELIMEI','CLERK',7788,TO_DATE('1992-5-3', 'YYYY-MM-DD'), 2586.00, NULL,70);
insert into emp values(7123,'LIUJIACHENG','MANAGER',7902,TO_DATE('1994-7-8', 'YYYY-MM-DD'), 4592.00, NULL,70);
insert into emp values(7903,'DINGYUTAO','SALESMAN',7521,TO_DATE('1995-1-15', 'YYYY-MM-DD'), 2653.00, NULL,50);
insert into emp values(7265,'YINGWENXIANG','CLERK',7934,TO_DATE('1992-1-14', 'YYYY-MM-DD'), 2653.00, NULL,70);



--salgrade 表

drop table salgrade;
insert into salgrade values (1,700,1200);
insert into salgrade values (2,1201,1400);
insert into salgrade values (3,1401,2000);
insert into salgrade values (4,2001,3000);
insert into salgrade values (5,3001,9999);



--jobhistory 表
insert into jobhistory  values (1, 7369, 20, TO_DATE('1990-12-17', 'YYYY-MM-DD'), NULL, 'CLERK');
insert into  jobhistory  values (2, 7499, 30, TO_DATE('1991-02-20', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into jobhistory  values (3, 7521, 30, TO_DATE('1991-02-22', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into jobhistory  values (4, 7566, 20, TO_DATE('1991-04-02', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory values (5, 7654, 30, TO_DATE('1991-09-28', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into  jobhistory  values (6, 7698, 30, TO_DATE('1991-05-01', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory  values (7, 7782, 10, TO_DATE('1991-06-09', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory  values (8, 7788, 20, TO_DATE('1997-04-19', 'YYYY-MM-DD'), NULL, 'ANALYST');
insert into  jobhistory  values (9, 7839, 10, TO_DATE('1991-11-17', 'YYYY-MM-DD'), NULL, 'PRESIDENT');
insert into  jobhistory  values (10, 7844, 30, TO_DATE('1991-09-08', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into jobhistory  values (11, 7900, 30, TO_DATE('1991-12-03', 'YYYY-MM-DD'), NULL, 'CLERK');
insert into  jobhistory  values (12, 7902, 20, TO_DATE('1991-12-03', 'YYYY-MM-DD'), NULL, 'ANALYST');
insert into  jobhistory  values (13, 7934, 10, TO_DATE('1992-1-23', 'YYYY-MM-DD'), NULL, 'CLERK');
insert into  jobhistory  values (14, 7369, 20, TO_DATE('1990-12-17', 'YYYY-MM-DD'), NULL, 'CLERK');
insert into  jobhistory  values (15, 7499, 30, TO_DATE('1991-02-20', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into  jobhistory  values (16, 7521, 30, TO_DATE('1991-02-22', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into  jobhistory values (17, 7566, 20, TO_DATE('1991-04-02', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory  values (18, 7654, 30, TO_DATE('1991-09-28', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into  jobhistory  values (19, 7698, 30, TO_DATE('1991-05-01', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory  values (20, 7782, 10, TO_DATE('1991-06-09', 'YYYY-MM-DD'), NULL, 'MANAGER');
insert into  jobhistory  values (21, 7788, 20, TO_DATE('1997-04-19', 'YYYY-MM-DD'), NULL, 'ANALYST');
insert into  jobhistory  values (22, 7839, 10, TO_DATE('1991-11-17', 'YYYY-MM-DD'), NULL, 'PRESIDENT');
insert into  jobhistory  values (23, 7844, 30, TO_DATE('1991-09-08', 'YYYY-MM-DD'), NULL, 'SALESMAN');
insert into  jobhistory  values (24, 7900, 30, TO_DATE('1991-12-03', 'YYYY-MM-DD'), NULL, 'CLERK');
insert into  jobhistory  values (25, 7902, 20, TO_DATE('1991-11-19', 'YYYY-MM-DD'), NULL, 'ANALYST');
insert into  jobhistory  values (26, 7934, 10, TO_DATE('1992-1-23', 'YYYY-MM-DD'), NULL, 'CLERK');


--worklogs 表

insert into worklogs values (1, 7369, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 8.5, 'Completed lesson plans for the day.');
insert into worklogs values (2, 7156, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 7.0, 'Conducted counseling sessions with students.');
insert into  worklogs values (3, 7025, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 9.5, 'Managed administrative tasks for the department.');
insert into worklogs values (4, 7125, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 8.0, 'Directed team meeting to discuss project progress.');
insert into  worklogs values (5, 7499, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 6.5, 'Met with clients to discuss sales targets.');
insert into  worklogs values (6, 7521, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 7.5, 'Prepared sales reports for management review.');
insert into  worklogs values (7, 7566, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 8.0, 'Managed daily operations of the department.');
insert into  worklogs values (8, 7654, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 6.5, 'Conducted product demonstrations for potential clients.');
insert into  worklogs values (9, 7698, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 9.0, 'Led team meeting to discuss project timelines.');
insert into  worklogs values (10, 7782, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 7.5, 'Reviewed financial reports and budgets.');
insert into  worklogs values (11, 7788, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 8.5, 'Analyzed market trends and competitor strategies.');
insert into  worklogs values (12, 7839, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 9.0, 'Developed strategic plans for company growth.');
insert into  worklogs values (13, 7844, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 7.0, 'Assisted clients with product inquiries and purchases.');
insert into  worklogs values (14, 7900, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 6.5, 'Processed customer orders and handled billing inquiries.');
insert into  worklogs values (15, 7902, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 8.0, 'Conducted data analysis for market research.');
insert into  worklogs values (16, 7934, TO_DATE('2024-05-09', 'YYYY-MM-DD'), 7.5, 'Provided administrative support to management.');


select ename || ' job is ' || job from emp;

select instr('zhiguo yuan','yuan') from dual;

select upper(ename) from emp;

select lower(ename) from emp;

select substr(ename,1,3) from emp;

select substr(ename, length(ename) - 2, 3) FROM emp;

select length(ename) from emp;

select ename,replace(job, 'MANAGER', '经理') from emp;

select case 
           when 'carl' = 'carl' then 0
           else 1
       end as result
from dual;

select substr(ename,1,2) from emp;

select ltrim('   hello,SQL SERVER') from dual;

select ltrim('hello,SQL SERVER         ') from dual;

select trim('   hello,SQL SERVER      ') from dual;

select user from dual;

select current_date from dual;

select sysdate from dual;


select systimestamp from dual;

select current_timestamp from dual;

select to_date('2024-03-09','YYYY-MM-DD') 
    - to_date('2002-09-24','YYYY-MM-DD') as datediff from dual;

select extract(year from sysdate) from dual;

select extract(month from sysdate) from dual;

select extract(day from sysdate) from dual;

select abs(-10) from dual;

select ceil(-1.1) from dual;

select to_char(to_number('8','99'),'B') from dual;

select floor(-1.1) from dual;

select to_char(78.1235896,'99999999.99') from dual;

select least(1,3,5,7,8) from dual;

select mod(10,3) from dual;

select dbms_random.value from dual;

select current_timestamp from dual;



--group by 
select avg(sal), max(sal), deptno from emp group by deptno;

select to_char(avg(sal),99999.99) ,max(sal), deptno from emp group by deptno;

select avg(sal), min(sal), deptno , job from emp 
group by deptno, job;

select avg(sal),deptno from emp group by deptno having avg(sal) < 2000;

select count(*), avg(sal), job from emp group by job;

select count(*),count(comm) from emp;

select count(*),count(case when comm is null then 1 else null end) from emp;

select count(*),count(*) - count(comm) from emp;

select count(distinct mgr) from emp;

select max(sal) - min(sal) from emp;

select deptno,avg_sal from
(select deptno,avg(sal) as avg_sal from emp group by deptno
having avg(sal) > 1000
order by avg_sal desc)
where rownum <= 2;

















--selectinc

select * from emp where hiredate > to_date('1992-01-01','YYYY-MM-DD');

select ename,sal from emp where ename like 'S%';

select ename,sal from emp where ename like '__O%';

select * from emp where mgr is null;

desc emp;

select * from emp order by sal;

select * from emp order by deptno asc, sal desc;







--control
select case when 1=1 then 'BEIJING' else 'SHANGHAI' end from dual;

select nvl(null,'yzg') from dual;

select ename,nvl(comm,0.0) from emp;

select ename,  case 
		when job = 'CLERK' then '职员' 
		when job = 'MANAGER' then '经理'
		when job = 'SALESMAN' then '销售人员' 
        when job = 'Teacher' then '老师'
        when job = 'COUNSELLOR' then '辅导员'
        when job = 'ANALYST' then '分析员'
        when job = 'DEAN' then '院长'
        when job = 'DIRECTOR' then '主任'
        when job = 'PRESIDENT' then '总统'
		else job 
        end as job 
	from emp; 
    






--page
select * from emp order by empno fetch first 3 rows only;
    
select * from (select * from emp where rownum <= 6 order by empno)
where rownum >= 4;

select job, count(*) from emp group by job;

select count(*) from emp where mgr is not null; 

select max(sal) - min(sal) from emp;







--subquery

select deptno, avg(sal) as avg_sal from emp group by deptno;

select ename,sal,temp.avg_sal ,emp.deptno from emp,(
select deptno, avg(sal) as avg_sal from emp group by deptno
)temp
where emp.deptno = temp.deptno and emp.sal > temp.avg_sal;

select ename,sal,temp.avg_sal ,emp.deptno from emp,(
select deptno, avg(sal) as avg_sal from emp group by deptno
)temp
where emp.deptno = temp.deptno and emp.sal = temp.avg_sal;

select count(*),deptno from emp group by deptno;

select dname,dept.deptno,loc,tmp.per_num as 人数
from dept,(
select count(*) as per_num, deptno from emp group by deptno
)tmp 
where tmp.deptno = dept.deptno;

select tmp.*, dname, loc from dept,
(select count(*) as per_num,deptno from emp group by deptno
)tmp
where tmp.deptno = dept.deptno;

select deptno from emp where ename = 'DUZHONGMING';

select * from emp where deptno = 
(select deptno from emp where ename = 'WEILEI'
);

select distinct job from emp where deptno = 10;

select ename, job, sal,deptno from emp where job in
( select distinct job from emp where deptno = 10) and deptno <> 10;
































-- all any
select ename,sal,deptno from emp where sal > all(
select sal from emp where deptno = 30);

select ename,sal,deptno from emp where sal > (
select max(sal) from emp where deptno = 30);

select ename,sal,deptno from emp where sal > any(
select sal from emp where deptno = 30);

select ename,sal,deptno from emp where sal > (
select min(sal) from emp where deptno = 30);






--self
select worker.ename as 职员名 , boss.ename as 上级名
from emp worker, emp boss
where worker.mgr = boss.empno;






-- many_tab

select ename,sal,dname,emp.deptno from emp,dept 
where emp.deptno = emp.deptno;

select ename,sal,dname,emp.deptno from emp,dept 
where emp.deptno = emp.deptno and emp.deptno = 10;

select ename, sal,grade from emp,salgrade 
where sal between losal and hisal;









-- Union
select ename,sal,job from emp where sal > 2500;

select ename,sal,job from emp where job = 'MANAGER';

select ename, sal, job from emp where sal > 2500
union 
select ename,sal,job from emp where job = 'MANAGER';






--outer
select dname,ename,job from dept left join emp
on dept.deptno = emp.deptno;

select dname,ename,job from emp right  join dept
on dept.deptno = emp.deptno;


select d.deptno, dname, count(e.empno) as total_employees
FROM dept d
left join emp e ON d.deptno = e.deptno
group by  d.deptno, d.dname;



--view
create view emp_view
as
select empno,ename,dname,grade 
from emp,dept,salgrade
where emp.deptno = dept.deptno and
(sal between losal and hisal);

desc emp_view;

select * from emp_view;

create view emp_view01
as
select empno,ename,job,deptno from emp;

desc emp_view01;

select * from emp_view01;

select ename, job from emp_view01;

--select text from ALL_VIEWS where view_name = 'emp_view01' ;

drop view emp_view01;

update emp_view01 set job = 'MANAFER'
where empno = 7369;

update emp 
	set job = 'SALESMAN' 
	where empno = 7369;

create view emp_view02
	as
	select empno, ename from emp_view01;

select * from emp_view02;










--manycolumn
select deptno, job from emp where ename = 'YUANZHIGUO';

select * from emp where (deptno,job) =(select deptno, job
from emp where ename ='LIUYINQIU') and ename != 'LIUYINQIU';











--user
create  user teacher identified by 123456;

drop user teacher;

alter user teacher identified by 1234567;

alter user teacher identified by 123456;

grant connect,resource,dba to teacher; 

revoke connect,resource,dba from teacher;
















--Exercise

select count(*) as c,deptno from emp group by deptno 
having count(*) >1;

select * from emp where sal >(
select sal from emp where ename = 'WEILEI');

select worker.ename as 员工名,worker.hiredate as 员工入职时间,
leader.ename as 上级名, leader.hiredate as 上级入职时间
from emp worker,emp leader
where worker.hiredate > leader.hiredate
and worker.mgr = leader.empno;

select dname, emp.* from dept 
left join emp on dept.deptno =  emp.deptno;

select dname,job  from emp,dept where job = 'CLERK'
and emp.deptno = dept.deptno;

select min(sal) as min_sal,job from emp group by job
having min(sal) > 1500;

select ename,dname from emp,dept where emp.deptno = dept.deptno 
and dname = 'sales';

select * from emp where sal > (select avg(sal) from emp);

select * from emp where job = (select job from emp where
ename = 'WEILEI') and ename != 'WEILEI';

select ename,sal from emp where sal > (select max(sal) from emp
where deptno = 30)

select count(*) as 部门员工数量 ,deptno, avg(sal) as 部门平均工资,
round(avg(MONTHS_BETWEEN(sysdate, hiredate) / 12), 2) as "平均服务期限(年)"
from emp
group by deptno;

select count(*) as c,deptno from emp group by deptno;

select dept.*, tmp.c as 部门人数 from dept, 
(select count(*) as c,deptno from emp group by deptno)tmp 
where dept.deptno = tmp.deptno;

select min(sal), job from emp group by job;

select min(sal) from emp where job = 'MANAGER';

select ename,(sal+nvl(comm,0))*12 as year_sal from emp
order by year_sal;

select ename, (sal+nvl(comm,0))* 13 as 年收入 from emp;

select * from emp;

select ename,sal  from emp where sal > 2850;

select ename,sal  from emp where sal < 1500 or sal > 2850;

select ename, sal from emp where not 
(sal > 1500 and sal <= 2580);

select ename, sal from emp where empno = 7566;

select ename, job from emp where 
(deptno  =10 or deptno  = 30) and sal > 1500;

select ename, job from emp where mgr is null;

select ename, job, hiredate from emp 
where hiredate > to_date('1991-02-02','YYYY-MM-DD') 
and hiredate < to_date('1991-05-01','YYYY-MM-DD') 
order by hiredate;

select ename, sal, comm from emp order by sal desc;

select * from emp where deptno = 30;

select ename,empno, deptno,job from emp where job = 'CLERK';

select * from emp where nvl(comm,0) > sal;

select * from emp where nvl(comm,0) > sal * 0.6;

select * from emp where (deptno = 10 and job = 'MANAGER')
or (deptno = 20 and job = 'CLERK');

select * from emp where (deptno = 10 and job = 'MANAGER')
or (deptno = 20 and job = 'CLERK')
or(job != 'MANAGER' and job != 'CLERK' and sal >= 2000);

SELECT * from emp where comm is not null;

select * from emp where comm is null or nvl(comm,0) < 100;

select * from emp where last_day(ADD_MONTHS(hiredate, 1)) -2 = hiredate;

select * from emp where length(ename) = 10;

select * from emp where ename not like '%R%';

select substr(ename,1,3) from emp;

select replace(ename, 'A', 'a') from emp;

select ename, hiredate from emp 
where hiredate + interval '10' year <= sysdate;

select ename, hiredate from emp order by hiredate;

select ename, job, sal from emp order by job desc, sal;


select ename, TO_CHAR(hiredate, 'YYYY-MM') as hire_month_year
from emp
order by extract(month from hiredate), extract(year from hiredate);

select ename, floor(sal / 30),sal / 30 from emp;

select * from emp where extract(month from hiredate) = 2;

select ename, months_between(sysdate,hiredate) as months_diff from emp;

select * from emp where ename like '%A%';

select ename,  TRUNC(MONTHS_BETWEEN(SYSDATE, hiredate) / 12) as 工作年,
            TRUNC(MOD(MONTHS_BETWEEN(SYSDATE, hiredate), 12)) as 工作月,
            trunc(sysdate - hiredate) as 工作天
from emp;

commit;


      
       
       
       
       
       
       
       
       
       
      
create table students (
    student_id number primary key,
    first_name varchar2(50),
    last_name varchar2(50),
    sal decimal(7,2),
    comm decimal(7,2),
    earnd as (sal + comm)
);


insert into students (student_id, first_name, last_name, sal, comm) 
values (1, 'John', 'Doe', 5000.00, 1000.00);
insert into students (student_id, first_name, last_name, sal, comm) 
values (2, 'Jane', 'Smith', 6000.00, 1500.00);
insert into students (student_id, first_name, last_name, sal, comm) 
values (3, 'Michael', 'Johnson', 5500.00, 1200.00);

select * from students;













create table emp_01
as (select empno, ename, job, mgr, hiredate, sal,comm, deptno from emp);

alter table emp_01 add (ext number(4));

desc emp_01;

alter table emp_01 modify (ext varchar2(18));

alter table emp_01 drop column ext;

rename emp_01 to emp_01_01;

rename emp_01_01 to emp_01;

truncate table emp_01;

drop table emp_01;

select object_name, original_name from recyclebin;

flashback table emp_01 to before drop;

alter table orders 
add constraint orders_customer#_fk foreign key(customer#) references customers(customer#);

alter table books add constraint book_title_uk unique(title);

alter table orders add constraint orders_shipdate_ck check(orderdate <= shipdate);

alter table orders modify (customer# constraint orders_customer#_nn not null);

alter table equip drop constraint equip_rating_ck;

alter table customers drop primary key;

update acctmanager set amedate = '10-10月-09', region = 'S' where amid = 'L500';

update customers set region = '&Region' where state = '&State';

delete from acctmanager where amid = 'J500';

select name from system_privilege_map;

select title, pubid from books where pubid in (1,2,5);

select lastname, firstname, state, city from customers 
where state in ('FL','CA') 
order by 3 desc, 4;

select isbn, title, location, '    '  Count from books
cross join warehouses
order by location, title;

select title, pubid, name from publisher natural join books;

select b.title, pubid, p.name from publisher  p join books b using(pubid);

select b.title, b.pubid, p.name from publisher2 p join books b on p.id = b.pubid;

select r.firstname, r.lastname , c.lastname "Referred"
from customers c, customers r
where c.referred = r.customer#;

select * from customers;

select  r.firstname, r.lastname , c.lastname "Referred"
from customers c join customers r
on c.referred = r.customer#;

select customer# from customers
minus
select customer# from orders;



--查询每个部门的平均工资和员工数量：
SELECT d.dname AS department_name, COUNT(e.empno) AS employee_count, 
AVG(e.sal) AS average_salary
FROM dept d
LEFT JOIN emp e ON d.deptno = e.deptno
GROUP BY d.dname;


--找出每个经理及其直接下属的平均工资：
SELECT m.ename AS manager_name, COUNT(e.empno) AS direct_reports, AVG(e.sal) AS average_salary
FROM emp m
LEFT JOIN emp e ON m.empno = e.mgr
GROUP BY m.ename;


--列出每个员工及其直接上级的姓名：
SELECT e1.ename AS employee_name, e2.ename AS manager_name
FROM emp e1
LEFT JOIN emp e2 ON e1.mgr = e2.empno;


--找出每个部门的经理及其直接下属的数量：
SELECT d.dname AS department_name, m.ename AS manager_name, COUNT(e.empno) AS direct_reports_count
FROM dept d
LEFT JOIN emp m ON d.deptno = m.deptno
LEFT JOIN emp e ON m.empno = e.mgr
GROUP BY d.dname, m.ename;

