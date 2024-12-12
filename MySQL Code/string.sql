-- CHARSET(str) 返回字串字符集
SELECT CHARSET(ename) FROM emp;
 -- CONCAT (string2 [,... ]) 连接字串, 将多个列拼接成一列
 SELECT CONCAT(ename, 'job is ', job) FROM emp;
-- INSTR (string ,substring ) 返回 substring 在 string 中出现的位置,没有返回 0
SELECT INSTR('hangshunping', 'ping') FROM DUAL;  
-- dual 亚元表, 系统表 可以作为测试表使用

-- UCASE (string2 ) 转换成大写
SELECT UCASE(ename) FROM emp;
 -- LCASE (string2 ) 转换成小写
 SELECT LCASE(ename) FROM emp;
-- LEFT (string2 ,length )从 string2 中的左边起取 length 个字符
SELECT LEFT(ename, 2) FROM emp;
SELECT RIGHT(ename, 2) FROM emp;
-- RIGHT (string2 ,length ) 从 string2 中的右边起取 length 个字符

-- LENGTH (string )string 长度[按照字节]
SELECT LENGTH('han') FROM emp;
SELECT LENGTH('韩') FROM emp;
SELECT LENGTH(ename) FROM emp;

-- REPLACE (str ,search_str ,replace_str )
-- 在 str 中用 replace_str 替换 search_str
-- 如果是 manager 就替换成 经理
SELECT ename, REPLACE(job,'MANAGER','经理') FROM emp;

-- STRCMP (string1 ,string2 ) 逐字符比较两字串大小
SELECT STRCMP('hsp', 'hsp') FROM DUAL;
SELECT STRCMP('hsp', 'gsp') FROM DUAL;

-- SUBSTRING (str , position [,length ])
-- 从 str 的 position 开始【从 1 开始计算】,取 length 个字符
SELECT SUBSTRING(ename, 1,2) FROM emp;
-- 从 ename 列的第一个位置开始取出 2 个字符


 -- LTRIM (string2 ) RTRIM (string2 ) TRIM(string)
-- 去除前端空格或后端空格
SELECT LTRIM(' hanshunping') FROM DUAL;
SELECT LTRIM('hanshunping ') FROM DUAL;
SELECT LTRIM('   hanshunping ') FROM DUAL;


 -- 练习: 以首字母小写的方式显示所有员工 emp 表的姓名
-- 方法 1
-- 思路先取出 ename 的第一个字符，转成小写的
-- 把他和后面的字符串进行拼接输出即可
SELECT CONCAT(LCASE(SUBSTRING(ename,1,1)),SUBSTRING(ename,2)) AS new_name
	FROM emp;
	
	
SELECT CONCAT(LCASE(LEFT(ename,1)),SUBSTRING(ename,2)) AS new_name
	FROM emp;

