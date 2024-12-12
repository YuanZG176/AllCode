SELECT * FROM student2
	ORDER BY math DESC;
	
SELECT `name`,(chinese+english+math) AS total_score FROM studnet2
	ORDER BY total_score DESC;
	
SELECT `name`,(chinese+english+math) AS total_score FROM student2
	WHERE `name` LIKE '韩%'
	ORDER BY total_score;
	