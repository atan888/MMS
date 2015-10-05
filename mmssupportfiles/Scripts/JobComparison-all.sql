SELECT DominantJob as Type,
COUNT(Distinct CrewKey) as NumCrew,
SUM (Jobs) as NumJobs,
SUM (ManHrs) as CrewHours,
SUM (Revenue) as Revenue,
SUM (MatCost) as MatCost,
SUM (NetRevenue) as NetRev,
(SUM (Revenue) - SUM (MatCost)) / COUNT (Distinct CrewKey)as PerCrew,
(SUM (Revenue) - SUM (MatCost))/COUNT (DominantJob) as PerJob,
(SUM (Revenue) - SUM (MatCost))/(case when isnull(SUM( ManHrs), 0) = 0 then 1 else SUM( ManHrs) end) as ManHrs

From
(
	SELECT Date,Jobs, ManHrs, Revenue, MatCost, NetRevenue, PMH, Mow,Gutter, Mulch, Leaf, App, Prune, Other, CrewKey,
	CASE 
		WHEN Mow >= Gutter AND Mow >= Mulch And Mow >= Leaf And Mow >= App And Mow >= Prune and Mow >= Other THEN 'Mow' 
		WHEN Gutter >= Mow AND Gutter >= Mulch And Gutter >= Leaf And Gutter >= App And Gutter >= Prune and Gutter >= Other THEN 'Gutter' 
		WHEN Mulch >= Mow AND Mulch >= Gutter And Mulch >= Leaf And Mulch >= App And Mulch >= Prune and Mulch >= Other THEN 'Mulch' 
		WHEN Leaf >= Mow AND Leaf >= Gutter And Leaf >= Mulch And Leaf >= App And Leaf >= Prune and Leaf >= Other THEN 'Leaf' 
		WHEN App >= Mow AND App >= Gutter And App >= Mulch And App >= Leaf And App >= Prune and App >= Other THEN 'App' 
		WHEN Prune >= Mow AND Prune >= Gutter And Prune >= Mulch And Prune >= Leaf And Prune >= App and Prune >= Other THEN 'Prune' 
		WHEN Other >= Mow AND Other >= Gutter And Other >= Mulch And Other >= Leaf And Other >= App and Other >= Prune THEN 'Other' 
		ELSE 'None' End AS DominantJob
	From
		(
		SELECT     DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0) AS Date, 
		Count (*) as Jobs,
		SUM ( case when isnull(CustomerJob.ManHours, 0) = 0 then 0 else CustomerJob.ManHours end) as ManHrs,
		SUM (CustomerJob.Revenue) as Revenue,
		SUM (CustomerJob.MaterialCost) as MatCost,
		SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost) as NetRevenue,
		(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost)) / (case when isnull(SUM( CustomerJob.ManHours), 0) = 0 then 1 else SUM( CustomerJob.ManHours) end) as PMH,
		SUM(CASE WHEN CustomerJob.Type = 'Mow' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS Mow, 
		SUM(CASE WHEN CustomerJob.Type = 'Gutter' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS Gutter, 
		SUM(CASE WHEN CustomerJob.Type = 'Mulch' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS Mulch, 
		SUM(CASE WHEN CustomerJob.Type = 'Leaf' THEN(CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS Leaf, 
		SUM(CASE WHEN CustomerJob.Type = 'App' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS App, 
		SUM(CASE WHEN CustomerJob.Type = 'Prune' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END) AS Prune, 
		SUM(CASE WHEN CustomerJob.Type = 'Other' THEN (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) ELSE 0 END)AS Other, 
		CustomerJob.CrewKey
		FROM         CustomerJob INNER JOIN
					 Property ON CustomerJob.PropertyID = Property.PropertyID
		WHERE     (CustomerJob.Date BETWEEN '1/1/2013' AND DATEADD(dd,1,'10/1/2013'))
		GROUP BY DATEADD(dd, DATEDIFF(dd, 0, CustomerJob.Date), 0), CustomerJob.CrewKey
		) data
	) data2
WHERE NetRevenue > 0 
Group by DominantJob
Order by DominantJob
