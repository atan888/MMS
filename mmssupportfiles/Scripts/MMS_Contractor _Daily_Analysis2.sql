SELECT  DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 ) As Date1,
SUM ( case when CustomerJob.Type = 'Mow' Then 1 else 0 end) as Mow,
SUM ( case when CustomerJob.Type <> 'Mow' Then 1 else 0 end) as Other,
SUM ( case when CustomerJob.Type = 'Mow' Then CustomerJob.CostContractor else 0 end) as CtrMow,
SUM ( case when CustomerJob.Type <> 'Mow' Then CustomerJob.CostContractor else 0 end) as CtrOther,
SUM ( CustomerJob.CostContractor ) as CtrTotal, 
SUM ( CustomerJob.Cost)as MMS
FROM         CustomerJob INNER JOIN
                      Crew ON CustomerJob.CustomerJobID = Crew.CustomerJobID INNER JOIN
                      Employee ON Crew.EmployeeId = Employee.EmployeeID
WHERE     (Employee.LastName = 'Paige') AND (CustomerJob.Date BETWEEN '1/1/2012' AND '12/30/2012')
Group by DATEADD( dd, DATEDIFF( dd, 0,  CustomerJob.Date ), 0 )