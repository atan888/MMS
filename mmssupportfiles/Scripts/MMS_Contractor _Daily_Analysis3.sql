SELECT  DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ) As Date1,
SUM ( case when CustomerJob.Type = 'Mow' Then 1 else 0 end) as Mow
FROM  CustomerJob INNER JOIN
               Crew ON CustomerJob.CustomerJobID = Crew.CustomerJobID INNER JOIN
               Employee ON Crew.EmployeeId = Employee.EmployeeID               
WHERE Employee.LastName = 'Paige' and CustomerJob.Status = 'Completed'          
Group by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 )
Order by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 )