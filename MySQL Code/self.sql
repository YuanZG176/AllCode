SELECT worker.ename AS '职员名', boss.ename AS '上级名'
	FROM emp AS worker,emp AS boss
	WHERE worker.mgr = boss.empno