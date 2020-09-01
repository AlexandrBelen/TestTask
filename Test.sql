use NewDb
go

insert into Cars(Number, Brand, Model, Color, Year) values ('AA2545ET', 'Volvo', 'XC60', 'grey', '2015')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA1111AT', 'Volvo', 'XC90', 'white', '2016')
insert into Cars(Number, Brand, Model, Color, Year) values ('AO2356CT', 'Mercedes', 'Vito 116', 'black', '2017')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA8545EB', 'BMW', 'X5', 'grey', '2018')
insert into Cars(Number, Brand, Model, Color, Year) values ('KA9999EI', 'BMW', 'X6', 'grey', '2019')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA2222EO', 'Mazda', 'M6', 'green', '2014')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA8586MO', 'Volkswagen', 'Polo', 'red', '2015')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA3355KM', 'MiniCooper', 'F55', 'yellow', '2013')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA7788IO', 'Volvo', 'XC60', 'white', '2016')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA9514TE', 'Audi', 'A7', 'black', '2017')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA7539BA', 'Mercedes', 'S223', 'black', '2011')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA8552AA', 'Volkswagen', 'Golf', 'white', '2019')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA6554OP', 'Volkswagen', 'Passat', 'white', '2016')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA9902PA', 'Volkswagen', 'Arteon', 'grey', '2017')
insert into Cars(Number, Brand, Model, Color, Year) values ('AA0001KP', 'Volkswagen', 'Raptor', 'black', '2018')
select * from Cars;

insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Олександр', N'Кучер', N'Олександрович', '21.02.1995')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Андрій', N'Кучер', N'Олександрович', '05.12.1998')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Джон', N'Коко', N'Петрович', '29.02.1989')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Джонні', N'Сінс', N'Михайлович', '31.09.1992')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Олег', N'Ребро', N'Тарасович', '14.02.1995')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Григорій', N'Шевченко', N'Тарасович', '08.05.1996')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Дмитро', N'Квадратний', N'Олександрович', '15.06.1999')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Всеволод', N'Рюрик', N'Мирославович', '17.10.1994')
insert into Owners(Name, LastName, MidName, DateOfBirth) values(N'Володимир', N'Мономах', N'Ярославович', '01.04.1993')
select * from Owners;

insert into CarOwners(CarId, OwnerId) values(1, 1)
insert into CarOwners(CarId, OwnerId) values(2, 2)
insert into CarOwners(CarId, OwnerId) values(3, 3)
insert into CarOwners(CarId, OwnerId) values(4, 4)
insert into CarOwners(CarId, OwnerId) values(5, 5)
insert into CarOwners(CarId, OwnerId) values(6, 6)
insert into CarOwners(CarId, OwnerId) values(7, 7)
insert into CarOwners(CarId, OwnerId) values(8, 8)
insert into CarOwners(CarId, OwnerId) values(9, 9)
insert into CarOwners(CarId, OwnerId) values(10, 1)
insert into CarOwners(CarId, OwnerId) values(11, 5)
insert into CarOwners(CarId, OwnerId) values(12, 3)
insert into CarOwners(CarId, OwnerId) values(13, 7)
insert into CarOwners(CarId, OwnerId) values(14, 9)
insert into CarOwners(CarId, OwnerId) values(15, 7)
select * from CarOwners;


use NewDB

select * from Cars a join CarOwners co on co.CarId=a.Id where co.OwnerId=7;

select Name, LastName, MidName from Owners o join CarOwners co on co.OwnerId=o.Id where co.CarId=8

select * from Owners;

select * from Cars

