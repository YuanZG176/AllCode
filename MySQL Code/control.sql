SELECT IF(TRUE,'北京','上海') FROM DUAL;
SELECT IF(FALSE,'北京','上海') FROM DUAL;

SELECT IFNULL(NULL, '韩顺平教育') FROM DUAL;
SELECT IFNULL('jack', '韩顺平教育') FROM DUAL;

SELECT CASE
	WHEN TRUE THEN 'jack'
	WHEN FALSE THEN 'tom'
	ELSE 'mary' END;

SELECT ename,IF (comm IS NULL,0.0,comm)
	FROM emp;
	
SELECT ename,IFNULL (comm ,0.0)
	FROM emp;
	
SELECT ename, (SELECT CASE
	WHEN job = 'CLERK' THEN '职员'
	WHEN job = 'MANAGER' THEN '经理'
	WHEN job = 'SALESMAN' THEN '销售人员'
	ELSE job END) AS 'job',job
	FROM emp;
	
SELECT * FROM emp;
SELECT * FROM dept;
SELECT * FROM salgrade;
	
	