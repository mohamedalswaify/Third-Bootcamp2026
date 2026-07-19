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





-- 🧠 This course demonstrates how to use SELECT in practical contexts, from basic retrieval to advanced logic and multi-table operations.
------------------------------------------------------------
------------------------------------------------------------
-- 🔰 BEGINNER LEVEL: Basic SELECT, WHERE, and ORDER BY
------------------------------------------------------------



select  first_name ,department_name 
from employees e  inner join  departments d
on  e.department_id = d.department_id




select  first_name ,department_name 
from employees e  cross join  departments d
where   e.department_id = d.department_id



select  first_name ,department_name 
from employees e  ,  departments d
where   e.department_id = d.department_id


select  first_name ,department_name ,job_title
from employees e  join  departments d
on  e.department_id = d.department_id
join jobs j
on  e.job_id =j.job_id



select  first_name ,department_name ,job_title
from employees e  ,  departments d ,jobs j 
where  e.department_id = d.department_id  and e.job_id =j.job_id and salary >15000


select e.last_name ,j.job_title ,  e.department_id ,d.department_name ,l.city
from employees e join jobs j
on  e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join locations l 
on d.location_id = l.location_id
where city = 'Toronto'



select e.last_name ,j.job_title ,  e.department_id ,d.department_name ,l.city
from employees e , jobs j  ,departments d ,locations l 
where   e.job_id = j.job_id and  e.department_id = d.department_id and  d.location_id = l.location_id and  city = 'Toronto'



City   and country using  cross join

select  * 
from locations

select  * 
from countries


select  city ,country_name 
from  locations l ,  countries c
where l.country_id = c.country_id


select  department_id
from  employees
order by department_id

select  department_id
from  departments
order by department_id

select  first_name ,department_name 
from employees e  left outer join  departments d
on  e.department_id = d.department_id



select  first_name ,department_name 
from departments d  right outer join   employees e 
on  e.department_id = d.department_id





select  first_name ,department_name 
from employees e  right join  departments d
on  e.department_id = d.department_id



select  first_name ,department_name 
from employees e  full outer join  departments d
on  e.department_id = d.department_id

--------------------------------------------------------------------


select max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees



select salary
from employees



select max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees
where department_id = 60



select max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees
where job_id = 'ST_MAN'







select max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees
where department_id = 60



select  e.department_id, department_name , max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees e , departments d
where e.department_id = d.department_id
group by e.department_id, department_name






Write a query to display the job , maximum salary, minimum salary, total salary, 
average salary , and number of employees for each jobs from the employees table. 
Sort the result by job.

select  e.job_id , job_title ,max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees e join jobs j
on e.job_id = j.job_id
group by  e.job_id , job_title


select  job_title ,max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees e join jobs j
on e.job_id = j.job_id

group by  job_title




select  e.job_id , job_title ,max(salary) as maxumim ,min(salary) minumim,sum(salary) summ ,avg(salary) average ,count(*) as num_of_emp
from employees e join jobs j
on e.job_id = j.job_id
where e.job_id  not in('IT_PROG','SA_MAN')  
group by  e.job_id , job_title 
having count(*)  >5









--Insert your date in  employee table
 -----------------------------------------------------------
-- ✅ END OF COURSE
------------------------------------------------------------