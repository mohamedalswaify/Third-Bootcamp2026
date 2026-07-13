 ***********************Session 4**********************************
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




* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.

* Write a query that displays the last name and salary for all employees whose name starts 
with the letters “J,” “A,” or “M.” and the salary more than 6000 SR 
after that  Sort the results descending by the employees’ last names.

(13+7+10 )/3=10


select  last_name , salary 
from employees
where (last_name like'J%'   or  last_name like'A%'  or last_name like'M%')   and salary >6000
order by   last_name desc
-----------------------------------------------------------------------------------------------------------------


select  * 
from employees


select  * 
from departments


select  *
from jobs


select  first_name ,department_name 
from employees  join  departments
on  employees.department_id = departments.department_id


select  first_name ,department_name 
from employees e  inner join  departments d
on  e.department_id = d.department_id

select  first_name ,job_title
from employees join jobs 
on employees.job_id = jobs.job_id


select  first_name ,job_title
from employees e join jobs  j
on e.job_id = j.job_id
where salary >15000


* Write a query for the HR department to produce the addresses of all the 
departments. Use the LOCATIONS tables. Show the  street address, 
city, state or province, and country  in the output. 


select * 
from departments

select  * 
from locations

select  * 
from countries

select  department_name , street_address ,city ,state_province ,country_name
from departments d join  locations l
on   d.location_id =l.location_id
join  countries c
on  l.country_id = c.country_id

select  first_name ,department_name ,job_title
from employees e  join  departments d
on  e.department_id = d.department_id
join jobs j
on  e.job_id =j.job_id





* The HR department needs a report of employees in Toronto. Display the last name, 
job, department number, and the department name and city for all employees who work in 
Toronto. 
 
select e.last_name ,j.job_title ,  e.department_id ,d.department_name ,l.city
from employees e join jobs j
on  e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join locations l 
on d.location_id = l.location_id
where city = 'Toronto'




 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------