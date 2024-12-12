ALTER TABLE emp
       ADD  image VARCHAR(32) NOT NULL DEFAULT ''
       AFTER RESUME
       
DESC emp`emp``emp``emp`	 -- 显示表结构，可以查看表的所有列

ALTER TABLE emp
		MODIFY job VARCHAR(60) NOT NULL DEFAULT ''

ALTER TABLE emp 
		DROP sex;

RENAME TABLE emp TO employee		
