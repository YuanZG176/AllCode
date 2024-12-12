UPDATE employee SET salary = 5000;

SELECT * FROM employee

UPDATE employee 
	SET salary = 3000
	WHERE `name` = '小妖怪';
	
INSERT INTO employee 
		VALUES(200,'老妖怪','1990-11-11','2000-10-01 10:10:10','捶背的',5000,'给大王捶背',
		'E:\\a.jpg');
UPDATE employee 
	SET salary = salary + 1000, job = '出主意'
	WHERE `name` = '老妖怪';
