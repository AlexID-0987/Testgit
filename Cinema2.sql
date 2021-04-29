use Cinema2

CREATE TABLE Users
(

	UserId int not null identity primary key,
    Name nvarchar (50),
	Lastname nvarchar (50),
	Film nvarchar(50),
    Date date  null,
	Palañe int
   
    
);
insert into Users

values ('Joan','Clar','Garry poter','2021-03-10',3),
('Alex','Dim','Terminator','2021-03-09',5),
('Ann','Cip','Father','2021-02-04',4)
CREATE TABLE Films
(

	FilmsId int not null identity primary key,
    NameFilm nvarchar (50),
    Date date  null,
	Price money
   
    
);

insert into Films
values ('Father','2021-03-04',34)

select * from Users