SELECT * FROM emp
	WHERE hiredate > '1992-01-01'
	
SELECT ename, sal FROM emp
	WHERE ename LIKE 'S%'
	
SELECT ename, sal FROM emp
	WHERE ename LIKE '__O%'
	
SELECT * FROM emp
	WHERE mgr IS NULL;
	
SELECT * FROM emp 
	ORDER BY sal;
	
SELECT * FROM emp 
	ORDER BY deptno ASC, sal DESC;
DESC emp;