 ***********************Session 6**********************************
-- 📘 SQL Server: Full DQL Course - Beginner to Advanced
-- 👨‍🏫 Name: Mohamed Alswaify
-- 📱 Mobile: 0564842804


---------------------------------------------------------
-- 📘 THEORETICAL INTRODUCTION: What is DQL?
------------------------------------------------------------
-- DQL (Data Query Language) is used to fetch data from database objects such as tables and views.
-- The main DQL command is:
--     SELECT

-- 🔹 SQL SELECT SYNTAX:
SELECT *|columns
FROM table name
[WHERE bool-expr AND|OR  bool-expr]
[group by column|expr ]
[having bool-expr]
[order by column|number|expr|alias [ASC][DESC]]



-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: not BETWEEN ... AND ...
--   📋 List: [not] IN (...)
--   🔍 Pattern: [not] LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL


-- * Displaying Data from Multiple Tables Using Joins:

    * FROM table1 [INNER] JOIN table2 ON bool-expr [[INNER] JOIN table3 ON bool-expr ...]
    * FROM table1 CROSS JOIN table2 where bool-expr
    * FROM table1, table2 where bool-expr
    * FROM table1 LEFT|RIGHT|FULL [OUTER] JOIN table2 ON bool-expr [ LEFT|RIGHT|FULL [OUTER] JOIN table3 ON bool-expr ...]


* Reporting Aggregated Data Using the Group Functions:

    max(), min(), sum(), avg(), count()



=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================

1. INSERT:
----------
Used to add new records to a table.

Syntax:
    INSERT INTO table_name (column1, column2, ...)
    VALUES (value1, value2, ...);

2. UPDATE:
----------
Used to modify existing records.

Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
    WHERE condition;


3. DELETE:
----------
Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;





Introduction to Data Definition Language (DDL) in SQL Server

1. CREATE TABLE:
----------------
Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ...,
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _, @, $, #.
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT, REAL
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)
    - FOREIGN KEY REFERENCES other_table(column)

    
2. ALTER TABLE:
---------------
Syntax Overview:
    ALTER TABLE table_name
    -- Add a new column
    ADD column_name datatype;

    -- Modify column datatype or nullability
    ALTER COLUMN column_name new_datatype;

    -- Drop a column
    DROP COLUMN column_name;

    -- Add a constraint
    ADD CONSTRAINT constraint_name constraint_type;

    -- Drop a constraint
    DROP CONSTRAINT constraint_name;

Note:
    - RENAME COLUMN is not supported directly; use SQL Server Management Studio (SSMS) or recreate the column.


    3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;

-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------



select  * 
from departments

INSERT INTO departments 
VALUES (280, 'XYZ',nu
ll,null);

update departments
set manager_id = 206
where  department_id = 280

update departments
set location_id = 1700
where  department_id = 280

delete departments
	
where  department_id = 280

INSERT INTO departments  (department_id , department_name)
VALUES(290, 'XYZ');

select  * 
from employees

INSERT INTO employees  (employee_id , first_name ,last_name ,email,hire_date,job_id ,salary,department_id)
VALUES(208,'Mohamed','Alswaify','mo@gmail.com','1998-01-01','IT_PROG',5000,60);



-----------------------------------------------

create database ThirdDB;

drop database ThirdDB;
use ThirdDB;


create  table My_depts
(
Dept_id int primary key ,
Dept_Name varchar(60) UNIQUE

);


select  * 
from My_depts

insert into My_depts
values(2,'IT')



create  table My_depts
(
Dept_id int constraint My_depts_Dept_id_PK  primary key ,
Dept_Name varchar(60) constraint  My_depts_Dept_Name_UQ UNIQUE

);


drop  table My_depts


-- Create employees table
CREATE TABLE My_Emps (
    Emp_ID INT CONSTRAINT PK_My_Emps_Emp_ID PRIMARY KEY,
    Emp_Name VARCHAR(30) NOT NULL,
    Salary DECIMAL(8, 2) CONSTRAINT CK_My_Emps_Salary CHECK (Salary between 3000 and 6000),
    Hire_Date DATE DEFAULT GETDATE(),
    Dept_ID INT CONSTRAINT FK_My_Emps_Dept_ID FOREIGN KEY REFERENCES My_Depts(Dept_ID)
);


INSERT INTO My_Emps (Emp_ID, Emp_Name, Salary, Dept_ID)
VALUES 
(106, 'Hussain', 4000, 1),
(105, 'Hussain', 4000, 1),
(104, 'Hussain', 4000, 1)
;

select  * 
from My_Emps

ALTER TABLE My_Emps

add city varchar(30)

ALTER TABLE My_Emps

add city varchar(30)


ALTER TABLE My_Emps
DROP COLUMN city;

ALTER TABLE My_Emps
  ALTER COLUMN city varchar(60);






--Insert your date in  employee table
 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------