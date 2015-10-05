SELECT  DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ) As Date1,
Count (CustomerJob.Type) as Cnt,
SUM ( case when isnull(CustomerJob.ManHours, 0) = 0 then 0 else CustomerJob.ManHours end) as ManHrs,
SUM (CustomerJob.Revenue) as Revenue,
SUM (CustomerJob.MaterialCost) as MatCost,
SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost) as NetRevenue,
(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost)) / (case when isnull(SUM( CustomerJob.ManHours), 0) = 0 then 1 else SUM( CustomerJob.ManHours) end) as PMH,
CustomerJob.CrewKey
FROM  CustomerJob INNER JOIN
               Crew ON CustomerJob.CustomerJobID = Crew.CustomerJobID INNER JOIN
               Employee ON Crew.EmployeeId = Employee.EmployeeID
WHERE CustomerJob.Date between '1/1/2013' and '12/4/2013' and CustomerJob.Type = 'Gutter' and Employee.Contractor = 'FALSE'
Group by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ), CustomerJob.CrewKey
Order by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ) ASC