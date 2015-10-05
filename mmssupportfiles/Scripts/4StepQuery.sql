SELECT     Customer.LastName + ',' + Customer.FirstName as Name,
Property.Address, CustomerJob.Date, CustomerJob.Type
FROM         Property INNER JOIN
                      Customer ON Property.CustomerID = Customer.CustomerID INNER JOIN
                      Service ON Property.PropertyID = Service.PropertyID INNER JOIN
                      Route ON Property.PropertyID = Route.PropertyID LEFT OUTER JOIN
                      CustomerJob ON Property.PropertyID = CustomerJob.PropertyID AND CustomerJob.FourStepJob = '1' AND CustomerJob.Date BETWEEN '1/1/2013' AND '12/30/2013'
WHERE     (Customer.Active = '1') AND (Service.FourStepType = '1') AND (Route.RouteName = 'FourStep')
ORDER BY Route.RouteOrder,Customer.LastName, Customer.FirstName
