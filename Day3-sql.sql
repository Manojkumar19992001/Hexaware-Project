select * from Region;

select * from Countries;

select * from location;

select * from department;

select * from employee;

select * from manager;



select * from employee where salary=(select max(salary) from employee);
select * from employee where salary=(select min(salary) from employee);
select * from employee where salary>(select avg(salary) as avg_salary from employee);
select * from employee where salary=(select max(salary) from employee where salary !=(select max(salary) from employee));

----2
select state from location where country_id =(select id from countries where name='canada') order by state asc;

----3
select first_name from employee where id in
(select employee_id from manager where department_id=(select id from department where name='accounts'))
order by first_name asc;

----9
select name from countries where region_id=(
select id from region where name='europe') order by name asc;

----14
select first_name from employee where id in(
select employee_id from manager where department_id=
(select id from department where name='hr')) order by first_name asc;

----15
select first_name from employee where id in
(select employee_id from manager) order by first_name asc;

--------------
--------------
select count(id) as count_ from location
group by country_id;

----find out how many employees are available in 'IT' department
select count(department_id) as it_count from employee where department_id=(
select id from department where name='it');

----
select count(employee_id)as manager_count,department_id from manager group by department_id;
