SELECT * FROM
(
SELECT    
DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0) AS Date, 
Count (*) as Jobs,
SUM ( case when isnull(CustomerJob.ManHours, 0) = 0 then 0 else CustomerJob.ManHours end) as ManHrs,
SUM (CustomerJob.Revenue) as Revenue,
SUM (CustomerJob.MaterialCost) as MatCost,
SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost) as NetRevenue,
(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost)) / (case when isnull(SUM( CustomerJob.ManHours), 0) = 0 then 1 else SUM( CustomerJob.ManHours) end) as PMH,
SUM(CASE WHEN CustomerJob.Type = 'Mow' THEN CustomerJob.Revenue ELSE 0 END) AS Mow, 
SUM(CASE WHEN CustomerJob.Type = 'Gutter' THEN CustomerJob.Revenue ELSE 0 END) AS Gutter, 
SUM(CASE WHEN CustomerJob.Type = 'Mulch' THEN CustomerJob.Revenue ELSE 0 END) AS Mulch, 
SUM(CASE WHEN CustomerJob.Type = 'Leaf' THEN CustomerJob.Revenue ELSE 0 END) AS Leaf, 
SUM(CASE WHEN CustomerJob.Type = 'App' THEN CustomerJob.Revenue ELSE 0 END) AS App, 
SUM(CASE WHEN CustomerJob.Type = 'Prune' THEN CustomerJob.Revenue ELSE 0 END) AS Prune, 
SUM(CASE WHEN CustomerJob.Type = 'Other' THEN CustomerJob.Revenue ELSE 0 END)AS Other, 
CustomerJob.CrewKey,
DominantJob = case
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Mow' THEN CustomerJob.Revenue ELSE 0 END) then 'Mow' 
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Gutter' THEN CustomerJob.Revenue ELSE 0 END) then 'Gutter'
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Mulch' THEN CustomerJob.Revenue ELSE 0 END) then 'Mulch' 
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Leaf' THEN CustomerJob.Revenue ELSE 0 END) then 'Leaf' 
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'App' THEN CustomerJob.Revenue ELSE 0 END) then 'App' 
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Prune' THEN CustomerJob.Revenue ELSE 0 END) then 'Prune' 
	when max(cj.revenue) = SUM(CASE WHEN CustomerJob.Type = 'Other' THEN CustomerJob.Revenue ELSE 0 END)then  'Other' 
	end
FROM         CustomerJob 

INNER JOIN Property ON CustomerJob.PropertyID = Property.PropertyID
	
INNER Join 
	(select MAX(cj1.revenue) revenue,cj1.CrewKey,cj1.Date Date  from (

select sum(cj.revenue) revenue, cj.CrewKey,DATEADD(dd, DATEDIFF(dd, 0, cj.Date), 0) AS Date
	  from CustomerJob cj
		WHERE     (cj.Date BETWEEN '1/2/2013' AND '12/3/2013')
		GROUP BY DATEADD(dd, DATEDIFF(dd, 0, cj.Date), 0), cj.CrewKey,cj.type,cj.date) cj1
		group by cj1.CrewKey,cj1.Date)	 cj
on (cj.CrewKey = CustomerJob.CrewKey ) and (cj.Date = DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0))

	
WHERE     (CustomerJob.Date BETWEEN '1/2/2013' AND '10/3/2013') 
		  
		  and CustomerJob.CustomerJobID  in (Select Crew.CustomerJobID from Crew	
													   where Crew.EmployeeId   IN (Select Employee.EmployeeID from Employee
																							where Employee.Contractor = 'False'))




GROUP BY  DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0), CustomerJob.CrewKey,cj.revenue
) data
WHERE NetRevenue > 0 and DominantJob = 'Mow'
Order by DATEADD( dd, DATEDIFF( dd, 0,  Date ), 0 ) ASC



