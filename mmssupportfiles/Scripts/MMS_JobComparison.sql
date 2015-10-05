SELECT CustomerJob.Type, 
COUNT (Distinct CustomerJob.CrewKey) as NumCrew,
COUNT (CustomerJob.Type) as NumJobs,
SUM (CustomerJob.ManHours)as CrewHours,
SUM (CustomerJob.Cost+CustomerJob.CostB+CustomerJob.CostC) as Revenue,
SUM (CustomerJob.MaterialCost) as MatCost,
SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost) as NetRev,
(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost)) / COUNT (Distinct CustomerJob.CrewKey)as PerCrew,
(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost))/COUNT (CustomerJob.Type) as PerJob,
(SUM (CustomerJob.Revenue) - SUM (CustomerJob.MaterialCost))/(case when isnull(SUM( CustomerJob.ManHours), 0) = 0 then 1 else SUM( CustomerJob.ManHours) end) as ManHrs
FROM  CustomerJob
WHERE CustomerJob.Date between '1/1/2013' and DATEADD(dd,1,'10/1/2013')
Group by CustomerJob.Type
ORDER by CustomerJob.Type


