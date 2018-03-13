--19
--select *
--from
--	(SELECT hello.FirstName, hello.LastName, hello.AddressID , itms.FirstName as ManiFirst, itms.LastName as ManiLast
--	from Employees hello
--	inner join Employees itms
--	on hello.ManagerID = itms.EmployeeID) 
--	as p
--	inner join Addresses
--	on p.AddressID = Addresses.AddressID

--20
--select  from Departments
--union 
--select  Name from Towns

--21
--select *
--from Employees emps
--left outer join Employees empsSecond
--on   emps.ManagerID  = empsSecond.EmployeeID

--22
--select*
--from Employees emps
--inner join Departments deps
--on emps.DepartmentID = deps.DepartmentID
--where deps.Name in ('Finance','Sales')
--and emps.HireDate between '1995' and '2005'

 




