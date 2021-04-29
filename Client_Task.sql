use Client

CREATE TABLE Clients
(

	Id int not null identity primary key,
    Name nvarchar (50),
    Amount money NOT NULL,
    
    
);

select * from Clients
insert into Clients
values('A',100),('B',80),('C',60),('D',115)

CREATE TABLE Transactions
(

	Id int not null identity primary key,
    UserId int not null,
    SendAmount money NOT NULL,
    
    
);

insert into Transactions
values(1,12),(1,17),(2,21),(3,33)




select Name,Amount -Sum (SendAmount) as Transactions 
from Clients as C
join Transactions as SendAmount on UserID=C.ID Group by Amount,Name
union Select Name,Amount from Clients
Left Join Transactions as T on T.UserID=Clients.ID
where T.ID is Null

