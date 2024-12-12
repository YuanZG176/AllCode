#注释的快捷键  shift+ctrl+c
#注释注销  shift+ ctrl+r

#CHAR(size)
#固定长度字符串 最大255 字符
#VARCHAR（size）  0~65535
#可变长度字符串  最大65532字节  [utf8编码最大21844字符 1-3个字节用于记录大小]
#如果表的编码是 utf8 Varchar(size)  size = (65535 - 3) / 3 = 21844;
#如果表的编码是gbk, varchar(size)  size = (65535 - 3) / 2 = 32766;

CREATE TABLE t09(
		`name` CHAR(255));
CREATE TABLE t10(
		`name` VARCHAR(32766)) CHARSET gbk;
#       drop table t10 

CREATE TABLE t13(content TEXT, content2 MEDIUMTEXT, content3 LONGTEXT);
INSERT INTO t13 VALUES('韩顺平教育','韩顺平教育100','韩顺平教育1000~');
SELECT  * FROM t13;