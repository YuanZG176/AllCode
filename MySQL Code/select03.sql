SELECT * FROM student 
	WHERE `name` = '赵云';
	
SELECT * FROM student 
	WHERE english > 90
	
SELECT * FROM student 
	WHERE (english+chinese+math) > 200
	
SELECT * FROM student 
	WHERE math > 60 AND id > 4;
	
SELECT * FROM student 
	WHERE english > chinese
	
SELECT * FROM student 
	WHERE (english+chinese+math) > 200 AND
		math < chinese AND `name` LIKE '赵%'；
		
SELECT * FROM student 
	WHERE english >= 80 AND english <= 90;
#闭区间	
SELECT * FROM student 
	WHERE english BETWEEN 80 AND  90;
	
SELECT * FROM student 
	WHERE math = 89 OR math = 90 OR math = 91;
	
SELECT * FROM student 
	WHERE math IN (89,90,91);
	
SELECT * FROM student 
	WHERE `name` LIKE '韩%';
	
SELECT * FROM student 
	WHERE math > 80 AND chinese > 80;
	

