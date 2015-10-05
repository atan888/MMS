SELECT   DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0) AS Date, COUNT(*) AS Jobs, SUM(CASE WHEN isnull(CustomerJob.ManHours, 0) = 0 THEN 0 ELSE CustomerJob.ManHours END) AS ManHrs, 
                      SUM(CustomerJob.Revenue) AS Revenue, SUM(CustomerJob.MaterialCost) AS MatCost, SUM(CustomerJob.Revenue) - SUM(CustomerJob.MaterialCost) AS NetRevenue, 
                      (SUM(CustomerJob.Revenue) - SUM(CustomerJob.MaterialCost)) / (CASE WHEN isnull(SUM(CustomerJob.ManHours), 0) = 0 THEN 1 ELSE SUM(CustomerJob.ManHours) END) AS PMH, 
                      SUM(CASE WHEN CustomerJob.Type = 'Mow' THEN CustomerJob.Revenue ELSE 0 END) AS Mow, SUM(CASE WHEN CustomerJob.Type = 'Gutter' THEN CustomerJob.Revenue ELSE 0 END) 
                      AS Gutter, SUM(CASE WHEN CustomerJob.Type = 'Mulch' THEN CustomerJob.Revenue ELSE 0 END) AS Mulch, 
                      SUM(CASE WHEN CustomerJob.Type = 'Leaf' THEN CustomerJob.Revenue ELSE 0 END) AS Leaf, SUM(CASE WHEN CustomerJob.Type = 'App' THEN CustomerJob.Revenue ELSE 0 END) AS App, 
                      SUM(CASE WHEN CustomerJob.Type = 'Prune' THEN CustomerJob.Revenue ELSE 0 END) AS Prune, SUM(CASE WHEN CustomerJob.Type = 'Other' THEN CustomerJob.Revenue ELSE 0 END) 
                      AS Other, CustomerJob.CrewKey
FROM         CustomerJob INNER JOIN
                      Property ON CustomerJob.PropertyID = Property.PropertyID INNER JOIN
                      Crew ON CustomerJob.CustomerJobID = Crew.CustomerJobID INNER JOIN
                      Employee ON Crew.EmployeeId = Employee.EmployeeID
WHERE     (CustomerJob.Date BETWEEN '1/2/2013' AND '1/3/2013') AND Employee.Contractor = 'False'
GROUP BY DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0), CustomerJob.CrewKey
ORDER BY Date