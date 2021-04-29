
CREATE TABLE Clients
(

	Id int not null identity primary key,
    Name nvarchar (50),
    Password nvarchar (20) NOT NULL,
    
    
);

insert into Clients
values('Alex','123'),('Fred','8080A'),('Sara','S0987'),('Dred','115')

select * from Clients