

#部分错误
DESC emp	 -- 显示表结构，可以查看表的所有列
RENAME TABLE emp TO emoloyee		
ALTER TABLE emoloyee	 CHARACTER SET utf8
ALTER TABLE emoloyee	
	CHANGE `name` `user_name` VARCHAR(32) NOT NULL DEFAULT ''
DESC emoloyee	