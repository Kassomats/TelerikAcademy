use TelerikAcademy

select *
from Employees e
where Salary =
		(select min(Salary) 
		from Employees
		where DepartmentID = e.DepartmentID)
order by DepartmentID

select avg(Salary) 
		from Employees
		where DepartmentID =1

select avg(Salary) 
		from Employees
		where DepartmentID = 
		(select DepartmentID from Departments where Departments.Name ='sales')

select count(*) 
		from Employees
		where DepartmentID = 
		(select DepartmentID from Departments where Departments.Name ='sales')

select count(*)
		from Employees
		where Employees.ManagerID is not null

		--10
select COUNT(EmployeeID) as EmpCount, Concat('DepartmentID: ', DepartmentID) as LocID
from Employees
group by DepartmentID
union
select COUNT(EmployeeID), Concat('TownID: ', Addresses.TownID)
from Employees join Addresses on Employees.AddressID = Addresses.AddressID
group by Addresses.TownID

--11
alter table Employees add Workers int

update Employees
set workers = 0
where EmployeeID = 3

select *
from Employees
where Workers is null


--alter table Employees drop column Workers 





