SELECT * FROM emp
	ORDER BY empno
	LIMIT 0,3;
SELECT * FROM emp
	ORDER BY empno
	LIMIT 3,3;
SELECT * FROM emp
	ORDER BY empno
	LIMIT 6,3;
SELECT * FROM emp
	ORDER BY empno
	LIMIT 9,3;
SELECT * FROM emp
	ORDER BY empno
	LIMIT 12,3;
	
#SELECT * FROM emp
#	ORDER BY empno
#	LIMIT 每页显示记录数*（第几页-1），每页显示记录数;
	
SELECT * FROM emp
	ORDER BY empno DESC
	LIMIT 20,5