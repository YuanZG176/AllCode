select * from student;

SELECT sno as '学号',sname as '姓名' from student;

SELECT * from course where credit > 4;

select * from student where deptName ='软件131' xor sex='男';

select * from student where (deptName ='软件131' and  sex='女') or 
(deptName !='软件131' and  sex='男');

select  all* from student;
select  distinct* from student;

desc student;
desc course;
desc score;

select id '学号' from student;


select * from student where sname like '杨%';
