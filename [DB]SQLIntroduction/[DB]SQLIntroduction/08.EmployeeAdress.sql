SELECT m.FirstName, m.AddressID as [Employee ComparingID], a.AddressID as [Adress ComparingID], a.AddressText
FROM Employees m JOIN Addresses a
on m.AddressID = a.AddressID