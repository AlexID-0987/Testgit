use Task

CREATE TABLE Card
(

	Id int not null identity primary key,
    Qt int not null,
    Nom_ID int NOT NULL REFERENCES Nom (Id), 
	Store_ID int not null REFERENCES Store (Id),
	Party_ID int REFERENCES Party (Id), 
	Owner_ID int REFERENCES Contractor (Id),
	Customer_ID int REFERENCES Contractor (Id),
    
    
);
insert into Card
values(10,1,1,null,1,null),
(20,2,1,1,null,1),
(25,3,1,null,2,null),
(45,6,2,2,null,2),
(7,2,2,null,1,3),
(17,1,2,3,1,null),
(45,7,2,3,null,4),
(34,3,3,3,3,5),
(6,2,3,1,3,null)

select * from Card

CREATE TABLE Nom
(

	Id int not null identity primary key,
    Nm nvarchar (50) not null
    
    
);
insert into Nom
values('Стол'),('Стул'),('Шкаф'),('Тумбочка'),('Кресло'),('Ваза'),('Люстра')

CREATE TABLE Party
(

	Id int not null identity primary key,
    Nm nvarchar (50) 
    
    
);
insert into Party
values ('Первая'),('Вторая'),('Третья')

CREATE TABLE Contractor
(

	Id int not null identity primary key,
    Nm nvarchar (50) 
    
    
);
insert into Contractor
values('ООО"Веллатрест"'),('ООО"Оникс"'),('ООО"ПРОГРЕСС"'),('ООО"Интеллект Сервис"'),('"УКРСПЕЦЭКСПОРТ"')

CREATE TABLE Store
(

	Id int not null identity primary key,
    Nm nvarchar (50) not null
    
    
);
insert into Store
values('Готовая продукция'),('Товары на складе'),('Сырье и материалы')

select * from Store
--1
select  *,N.Nm

from Card as C,Nom as N
--2

 select C.Id,C.Qt,Party.Nm
 from Card as C
 join Party on Party.Id=C.Id
 --3
 select C.Nm as [Name]
 from Contractor as C
 join Card on Card.Id=C.Id
 --4
 
  declare @name nvarchar(50),@name_a nvarchar(50),@name_b nvarchar(50),@name_c nvarchar(50),@name_d nvarchar(50),
  @name_e nvarchar(50),@name_g nvarchar(50),@name_t nvarchar(50)
  set @name='1-ООО"Веллатрест"';
  set @name_a='2-ООО"Оникс"';
  set @name_b='3-ООО"Прогресс"';
  set @name_c='4-ООО"Интеллект Сервис"';
  set @name_d='5-"Укрспецэкспорт"';
  set @name_e='6-Готовая продукция';
  set @name_g='7-Товары на складе';
  set @name_t='8-Сырье и материалы';
  print @name print @name_a print @name_b print @name_c print @name_d print @name_e print @name_g print @name_t 

  --5
  select sum(C.Qt)[Non],sum(C.Nom_ID)[Store]
  from Card as C
  join Card as Ca on Ca.Id=Ca.Store_ID 
  join Card as car on car.Id=car.Nom_ID
  
  --6
  select Distinct N.Nm,N.Id 
  from Nom as N,Card
  where N.Id=Card.Nom_ID