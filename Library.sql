use Library

CREATE TABLE Users
(

	Id int not null identity primary key,
    Name nvarchar (50),
	Lastname nvarchar (50),
	BooksUserId int null,
    Date_open date  null,
	Date_close date null,
   
    
);

insert into Users

values ('Joan','Clar',4,'2021-03-12','2021-03-30'),
('Alex','Dim',3,'2021-03-09','2021-03-24'),
('Ann','Cip',2,'2021-02-04','2021-02-19')

select * from Users

CREATE TABLE Books
(

	BooksId int not null identity primary key,
    NameBooks nvarchar (50),
	Autor nvarchar(50)
	
   
    
);
insert into Books
values('Pinocio','Grim'),('King Leon','Garry'),('History Egipt','ac.Dean'),('Mistikas map','Merli'),('My campf','Adolf')

select * from Books 

CREATE TABLE Reputation
(

	ReputationId int not null identity primary key,
    Name nvarchar (50),
	Lastname nvarchar (50),
	BooksId int null,
    
   
    
);

insert into Reputation
values ('Fles','Cocok',1),('Joann','Fill',3)

select * from Reputation

select distinct NameBooks
from Books,Users 
where Users.BooksUserId!=Books.BooksId

select Id,Name,BooksUserId,Books.NameBooks
from Users,Books
where Users.BooksUserId=Books.BooksId