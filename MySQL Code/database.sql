
#drop DATABASE yzg_db01
CREATE DATABASE yzg_db01
CREATE DATABASE yzg_db02 CHARACTER SET utf8
CREATE DATABASE yzg_db03 CHARACTER SET utf8 COLLATE utf8_bin
#校对规则 utf8_bin 区分大小写 默认utf8_general_ci  不区分大小写


SELECT * FROM t1 WHERE NAME = 'tom'