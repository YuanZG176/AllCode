
CREATE TABLE t14(
birthday DATE, 
jobtime DATETIME,
login_time TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP);

SELECT * FROM t14;

INSERT INTO t14(birthday,jobtime) 
VALUES('2022-11-11','2022-11-11 10:10:10');