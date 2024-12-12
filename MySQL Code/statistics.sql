SELECT COUNT(*) FROM student2;

SELECT COUNT(*) FROM student2
		WHERE math > 90;
		
SELECT COUNT(*) FROM student2
		WHERE (math+english +chinese) > 250;
		
CREATE TABLE t15(
	`name` VARCHAR(20));
	
INSERT INTO t15 VALUES('tom');
INSERT INTO t15 VALUES('jack');
INSERT INTO t15 VALUES('mary');
INSERT INTO t15 VALUES(NULL);
SELECT * FROM t15;
SELECT COUNT(*) FROM t15;
SELECT COUNT(`name`) FROM t15;


SELECT SUM(math) FROM student2;
SELECT SUM(math),SUM(chinese),SUM(english) FROM student2;
SELECT SUM(math + english + chinese) FROM student2;
SELECT SUM(chinese) / COUNT(*) FROM student2;



SELECT AVG(math) FROM student2;
SELECT AVG(math + english + chinese) FROM student2;

SELECT MAX(math + english + chinese),MIN(math + english + chinese)
	FROM student2;
SELECT MAX(math ),MIN(math )
	FROM student2;