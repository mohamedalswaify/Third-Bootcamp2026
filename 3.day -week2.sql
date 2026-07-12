 ***********************Session 5**********************************
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
-- SELECT * |  column1, column2, ...
-- FROM table_name
-- [WHERE condition]
-- [ORDER BY column1, column2, ... [ASC|DESC]]



-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >, >=
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: not BETWEEN ... AND ...
--   📋 List: [not] IN (...)
--   🔍 Pattern: [not] LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL

-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------

------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id = 30



select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id = 60


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id in(30,60,90)

-- 'IT_PROG'  'SA_MAN'


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  job_id in( 'IT_PROG' , 'SA_MAN' )


select  last_name ,salary , job_id , hire_date , department_id
from employees
where department_id is null

select  last_name ,salary , job_id , hire_date , department_id
from employees
where department_id is not null


select  last_name ,salary , job_id , hire_date , department_id
from employees
where  department_id not in(30,60,90)


select first_name + ' ' + last_name as employee_name   ,salary
from employees
where salary not  between  4000  and 9000
order by salary desc

* Display the employee name, department, and salary for all employees 
who have no commission (NULL)


select  *
from employees


select  first_name  + ' ' + last_name as "employee name" ,department_id  ,salary ,commission_pct
from employees
where commission_pct is null

--------------------------------------

* Display the last name, job, and salary for all employees 
whose salary is not equal 
to $2,500, $3,500, or $7,000.




select  last_name ,salary , job_id 
from employees
where  salary not in(2500,3500,7000)





select  last_name ,salary , job_id 
from employees
where last_name like'Z%'


select  last_name ,salary , job_id 
from employees
where last_name like'%z'


--MAN
select  last_name ,salary , job_id 
from employees
where  job_id like'%MAN'

select  last_name ,salary , job_id 
from employees
where last_name like'%ee%'



select  last_name,salary,hire_date ,department_id
from  employees
where salary >=6000



select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50  


select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    and  salary >=6000


select  last_name,salary,hire_date ,department_id
from  employees
where department_id = 50    or  salary >=6000



* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.



 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------