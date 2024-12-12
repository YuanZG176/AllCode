select title,category from books where category in ('COOKING','CHILDREN');



select title,category from books where category = 'COOKING' or category  ='CHILDREN';


select title,category from books where category LIKE '%C%N%';


select title,pubdate from books where category = 'COMPUTER' and pubdate >= '1-1��-05' and pubdate <= '31-12��-05'; 

select title,pubdate from books where category = 'COMPUTER' and pubdate like '%05';

select title,pubdate from books where category = 'COMPUTER' and pubdate between '1-1��-05' and  '31-12��-05'; 

select title, books.pubid from books,publisher;



ALTER SESSION SET nls_language='american';

CREATE TABLE warehouses
  (wh_id NUMBER(2),
   location VARCHAR(12) );
INSERT INTO warehouses
  VALUES (10, 'Boston');
INSERT INTO warehouses
  VALUES (20, 'Norfolk');
INSERT INTO warehouses
  VALUES (30, 'San Diego');
COMMIT;
Create Table Publisher2 
(ID NUMBER(2), 
Name VarCHAR2(23), 
Contact VARCHAR2(15), 
Phone VARCHAR2(12),
  CONSTRAINT publisher2_pubid_pk PRIMARY KEY(id)); 
INSERT INTO PUBLISHER2 
VALUES(1,'PRINTING IS US','TOMMIE SEYMOUR','000-714-8321'); 
INSERT INTO PUBLISHER2 
VALUES(2,'PUBLISH OUR WAY','JANE TOMLIN','010-410-0010'); 
INSERT INTO PUBLISHER2 
VALUES(3,'AMERICAN PUBLISHING','DAVID DAVIDSON','800-555-1211'); 
INSERT INTO PUBLISHER2 
VALUES(4,'READING MATERIALS INC.','RENEE SMITH','800-555-9743'); 
INSERT INTO PUBLISHER2 
VALUES(5,'REED-N-RITE','SEBASTIAN JONES','800-555-8284'); 
commit;
Create Table Publisher3 
(ID NUMBER(2), 
Name VarCHAR2(23), 
Contact VARCHAR2(15), 
Phone VARCHAR2(12),
  CONSTRAINT publisher3_pubid_pk PRIMARY KEY(id)); 
INSERT INTO PUBLISHER3 
VALUES(2,'PUBLISH OUR WAY','JANE TOMLIN','010-410-0010'); 
INSERT INTO PUBLISHER3 
VALUES(3,'AMERICAN PUB','DAVID DAVIDSON','800-555-1211'); 
INSERT INTO PUBLISHER3 
VALUES(6,'PRINTING HERE','SAM HUNT','000-714-8321'); 
INSERT INTO PUBLISHER3 
VALUES(7,'PRINT THERE','CINDY TIKE','010-410-0010'); 
commit;

DROP TABLE employees CASCADE CONSTRAINTS;

CREATE TABLE Employees (
 EMPNO               NUMBER(4),
 LNAME               VARCHAR2(20),
 FNAME               VARCHAR2(15),
 JOB                 VARCHAR2(9),
 HIREDATE            DATE,
 DEPTNO              NUMBER(2) NOT NULL,
 MTHSAL              NUMBER(7,2),
 MGR                 NUMBER(4),
 CONSTRAINT employees_empno_PK PRIMARY KEY (EMPNO));
INSERT INTO employees VALUES (7839,'KING','BEN', 'GTECH2','17-NOV-91',10,6000,NULL);
INSERT INTO employees VALUES (8888,'JONES','LARRY','MTech2','17-NOV-98',10,4200,7839);
INSERT INTO employees VALUES (7344,'SMITH','SAM','GTech1','17-NOV-95',20,4900,7839);
INSERT INTO employees VALUES (7355,'POTTS','JIM','GTech1','17-NOV-95',20,4900,7839);
INSERT INTO employees VALUES (8844,'STUART','SUE','MTech1','17-NOV-98',10,3700,8888);
COMMIT;



