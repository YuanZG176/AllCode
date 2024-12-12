SELECT `name`,(chinese+math+english) FROM student;

SELECT `name`,(chinese+math+english+ 10) FROM student;

SELECT `name` AS '名字',(chinese+math+english +10) AS total_score FROM student;