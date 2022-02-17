-- create salesman table
Create table Salesman(
	salesmanId int primary key,
	salesmanName varchar(50),
	salesmanNumber varchar(50)
)

--insert salesman values--
insert into Salesman  
values(1, 'Bob The Builder', '510-BUI-LDIT'),
	(2, 'Fred Belotte', '415-HEY-FRED'),
	(3, 'Nick Enscalada', '888-GET-COFI'),
	(4, 'Pushpinder Kaur', '213-TRA-INER'),	
	(5, 'Mark "Less is" Moore', '635-SLI-DES!'),
	(6, 'Jacob Davis', '415-SEA-HAWK'),
	(7, 'Marielle The Martian', '510-FLY-MARS')

select * from Salesman 

-- drop the table
drop table Salesman
drop table Airports 
drop table Products 

-- create airport table
Create table Airports(
	airportId int primary key,
	airportName varchar(50)
)

--insert airports values--
insert into Airports 
values(1, 'SFO'), (2, 'LAX'),
	(3, 'DFW'), (4, 'IAH'),
	(5, 'SAT'), (6, 'DAL'),
	(7, 'AUS'), (8, 'TPA'),
	(9, 'SEA'), (10, 'STL'),
	(11, 'OAK'), (12, 'MNL')

select * from Airports 

-- create products table
Create table Products(
	productId int primary key,
	productName varchar(50)
)

--insert products values--
insert into Products  
values(1, 'hammer'), (2, 'nails'),
	(3, 'screws'), (4, 'pizza'),
	(5, 'coffee'), (6, 'espresso'),
	(7, 'latte'), (8, 'cookies'),
	(9, 'cakes'), (10, 'books'),
	(11, 'tea'), (12, 'hot chocholate')
	
select * from Products 


--create join table with salesman and airport
create table salesman_airports(
	salesmanId int foreign key references Salesman(salesmanId),
	airportId int foreign key references Airports(airportId)
)

--adding salesman id with airport id
insert into salesman_airports 
values (1, 1), (1,2),
	(2, 3), (2, 4), (2, 5),
	(3, 6), (3, 4), (3, 7),
	(4, 8), (4, 3), (4, 6),
	(5, 3),
	(6, 9), (6, 10), (6, 4),
	(7, 11), (7, 1), (7, 12), (7, 6)

-- select only the routes from Marielle The Martian 
select a.airportName from Salesman s
inner join salesman_airports sa on s.salesmanId = sa.salesmanId 
inner join Airports a on a.airportId = sa.airportId 
where s.salesmanName ='Marielle The Martian'


--create join table with salesman and product
create table salesman_products(
	salesmanId int foreign key references Salesman(salesmanId),
	productId int foreign key references Products(productId)
)

--adding salesman id with product id
insert into salesman_products 
values (1, 1), (1, 2), (1 ,3),
	(2, 4), 
	(3, 5), (3, 6),(3, 7),
	(4, 8), (4, 9),
	(5, 10),
	(6, 5), 
	(7, 5), (7, 11), (7, 12)

--Select every saleman's name that has both route 'IAH' and product 'coffee'
SELECT s.salesmanName FROM Salesman s 
INNER JOIN salesman_airports sa ON s.salesmanId = sa.salesmanId 
INNER JOIN Airports a ON a.airportId = sa.airportId 
INNER JOIN salesman_products sp ON s.salesmanId = sp.salesmanId 
INNER JOIN Products p ON p.productId = sp.productId 
WHERE a.airportName = 'IAH' AND p.productName ='coffee'


--select every salesman name, no, routes, products 
SELECT s.salesmanName AS Name, s.salesmanNumber AS Phone_Number, a.airportName AS Routes, p.productName AS Products FROM Salesman s 
--SELECT STRING_AGG(Routes, ',') AS RESULT FROM Salesman s
INNER JOIN salesman_airports sa ON s.salesmanId = sa.salesmanId 
INNER JOIN Airports a ON a.airportId = sa.airportId 
INNER JOIN salesman_products sp ON s.salesmanId = sp.salesmanId 
INNER JOIN Products p ON p.productId = sp.productId 

