SELECT  DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ) As Date1,
SUM ( case when CustomerJob.Type = 'Mow' Then 1 else 0 end) as Mow,
SUM ( case when CustomerJob.Type = 'Leaf' Then 1 else 0 end) as Leaf,
SUM ( case when CustomerJob.Type = 'Gutter' Then 1 else 0 end) as Gutter,
SUM ( case when CustomerJob.Type <> 'Mow'and CustomerJob.Type <> 'Leaf' and CustomerJob.Type <> 'Gutter' Then 1 else 0 end) as Other,
SUM ( case when isnull(CustomerJob.ManHours, 0) = 0 then 0 else CustomerJob.ManHours end) as ManHrs,
SUM (CustomerJob.Revenue) as TotalRev,
SUM (CustomerJob.Revenue) / (case when isnull(SUM( CustomerJob.ManHours), 0) = 0 then 1 else SUM( CustomerJob.ManHours) end) as PMH
FROM  CustomerJob INNER JOIN
               Crew ON CustomerJob.CustomerJobID = Crew.CustomerJobID INNER JOIN
               Employee ON Crew.EmployeeId = Employee.EmployeeID               
WHERE Employee.LastName = 'Seay'              
Group by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 )
Order by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 )