create database bakery1;
use bakery1;


create table tb_login(
user_name varchar(30) not null,
password varchar(15) not null    
);

insert into tb_login(user_name,password)
values
('Arslan','abcdef'),
('Abrar','ghijk'),
('Mahad','lmnop'),
('Tayab','qrstu'),
('Usama','vwxyz');



create table Employee(
ID int primary key auto_increment,
Name varchar(30),
Email varchar(30),
PhoneNumber int null, 
Adress varchar(100) not null,
City varchar(30) not null,
Salary int not null,
HireDate  DATE
);

insert into Employee (Name,city,salary,Email, PhoneNumber,Adress)
values
('Rimsha','Okara',5000,'Rim@Gmail.com',030498,'Bajwa Colony Okara'),
('Haris','Lahore',20000,'Fazia@Gmail.com',030445,'12ACB ajwa Colony33'),
('Faizan','Lahore',15000,'Haris@yahoo.com',03444,'Askari tank'),
('Hamza','Faislabad',15000,'hmz@Gmail.com',030489,'12Bnf ajwa Colony35'),
('Aqib','Lahore',35000,'aqib@Gmail.com',030445,'12ACB ajwa Colony33'),
('Naveed','Gujranwala',15000,'naveed@hotmail.com',0304445,'Manga mandi 2'),
('Nabeel','Multan',25000,'nab@Gmail.com',030445,'Chung mutltan 33'),
('Haris','Lahore',30000,'Haris@gmail.com',03256,'Johar town'),
('Hamza','Islamabad',28000,'Aqib@gmail.com',0304445,'Baheria block C');


create table Customer(
ID int primary key auto_increment,
Name varchar(30) not null,
Email varchar(30) null, 
Adress varchar(30) not null,
City varchar(30) not null,
PhoneNumber int null,
Grade varchar(50) not null
);

insert into Customer(Name,City,Grade ,Email , Adress ,PhoneNumber ) 
values
('zamzam','Lahore','A','zama@yahoo.com','wapda town ER34 4',030493),
('zama','Lahore','C','zama@yGmail.com','wapda town ER34 4',0304673),
('Mahnoor','Lahore','B','mah67@yahoo.com','Shahdera3432C',0344558),
('Umar','Islambad','C','Umar@Gmail.com','Ali_HouseingRt54',0345775),
('Umair','Faislabad','A','Umair@yahoo.com','Ali_HouseingRt54',0345875),
('saad','Lahore','C','sadi@yahoo.com','Defence Phase1455',03445566),
('Bilal','Lahore','D','Bilal@Hotmail.com','jubliee Town E144',03457756),
('Haseeb','Gujranwala','B','Haseeb@yahoo.com','Satellite town23',0345775),
('Mohsin','Sakkhar','C','mohsin@yahoo.com','Sikandar townG33',0322115),
('Aqib','Gujranwala','A','aqib@yahoo.com','Maraka23',0345775);


create table Products(
ID int primary key auto_increment,
Name varchar(30) not null,
Price int not null,
qty int not null
);

insert into Products (Name,Price,qty )
values
('Cake',400,3),
('Buiscuit',300,5),
('Cream_Paistary',150,6),
('sweets',600,7),
('Milk',200,8),
('Rusk',200,7),
('Bread',200,4),
('Coke',400,20),
('Choclate_Paistary',150,9);


create table Orders(
ID int primary key auto_increment,
cust_ID int ,
emp_ID int ,
ord_Date DATE,
foreign key(cust_ID) references Customer(ID)
on delete cascade
on update cascade,
foreign key(emp_ID) references Employee(ID)
on delete cascade
on update cascade);

insert into Orders(cust_ID,emp_ID,ord_Date)
 values
(5,3,'2020-06-15'),
(5,5,'2020-06-16'),
(2,2,'2020-07-16'),
(6,4,'2020-07-17'),
(4,2,'2020-07-22'),
(3,4,'2020-07-23'),
(1,1,'2020-07-24'),
(3,3,'2020-07-27'),
(4,5,'2020-07-29'),
(7,9,'2020-08-01'),
(5,3,'2020-08-03'),
(8,7,'2020-08-05'),
(2,9,'2020-08-09'),
(3,7,'2020-08-10'),
(2,1,'2020-09-13'),
(8,9,'2020-09-14'),
(8,3,'2020-09-15'),
(3,1,'2020-09-15'),
(9,4,'2020-09-16'),
(7,2,'2020-10-17'),
(3,8,'2020-10-19'),
(2,3,'2020-10-15'),
(3,6,'2020-10-14'),
(6,6,'2020-10-16'),
(5,6,'2020-11-04'),
(7,6,'2020-11-06'),
(7,3,'2020-11-08'),
(2,6,'2020-11-12'),
(3,4,'2020-12-20'),
(4,6,'2020-12-15'),
(3,5,'2020-12-22');


create table ord_drived(
prdct_ID int,
Qty int not null,
bill int not null,
ord_ID int,
foreign key(prdct_ID) references Products(ID)
on delete cascade
on update cascade,
foreign key(ord_ID) references Orders(ID)
on delete cascade
on update cascade
);



insert into ord_drived()
 values 
(1,4,(select Price*4 from Products where id=1),1),
(2,2,(select Price*2 from Products where id=2),1),
(3,3,(select Price*3 from Products where id=3),1),
(4,4,(select Price*4 from Products where id=4),2),
(6,3,(select Price*3 from Products where id=6),2),
(7,4,(select Price*4 from Products where id=7),2),
(1,4,(select Price*4 from Products where id=1),3),
(3,5,(select Price*5 from Products where id=3),1),
(6,2,(select Price*2 from Products where id=6),1),
(4,2,(select Price*2 from Products where id=4),3),
(5,4,(select Price*4 from Products where id=5),7),
(8,1,(select Price*1 from Products where id=1),4),
(5,5,(select Price*5 from Products where id=5),8),
(3,2,(select Price*2 from Products where id=3),11),
(7,7,(select Price*7 from Products where id=7),10),
(2,2,(select Price*2 from Products where id=2),14),
(1,5,(select Price*5 from Products where id=1),17),
(5,7,(select Price*7 from Products where id=5),19),
(3,1,(select Price*1 from Products where id=3),20),
(4,4,(select Price*4 from Products where id=4),21),
(6,5,(select Price*5 from Products where id=6),23),
(3,8,(select Price*8 from Products where id=3),22),
(5,1,(select Price*1 from Products where id=5),21),
(6,9,(select Price*9 from Products where id=6),9),
(7,7,(select Price*7 from Products where id=7),3),
(2,6,(select Price*6 from Products where id=2),11),
(6,5,(select Price*5 from Products where id=6),10),
(8,2,(select Price*2 from Products where id=8),16),
(4,5,(select Price*5 from Products where id=4),15),
(5,9,(select Price*9 from Products where id=5),25);

create table Suppliers(
ID int primary key auto_increment,
Name varchar(30) not null,
adress varchar(50) not null,
City varchar(30) not null,
PhoneNumber int null
);

insert into Suppliers (Name,City,adress,PhoneNumber)
values
('Faizan','Lahore','Madina Kalooni',03345241),
('Nveed','Faislabad','Baheria Lahore',03345247),
('Usman','Lahore','AnarKali bazaar',03345104),
('Talal','Multan','Islampua Lahore',0334512045),
('Rana Waqar','Lahore','Johar town',03345104),
('Hussnan','Multan','Sikandar abad',0334789512),
('Abrar','Lahore','Liberty Lahore',03345347);


create table Stock(
ID int primary key auto_increment,
prdct_ID int ,
Sup_ID int,
Supply_Qty int not null,
supplied_amnt int not null,
foreign key(prdct_ID) references Products(ID)
on delete cascade
on update cascade,
foreign key(Sup_ID) references Suppliers(ID)
on delete cascade
on update cascade
);


insert into Stock(prdct_ID, Sup_ID,Supply_Qty,supplied_amnt )
values
(7,1,20,500),
(5,3,50,1000),
(4,4,56,2000),
(8,5,15,250),
(4,2,8,4500),
(6,2,150,600),
(6,6,150,790),
(6,6,150,2800),
(6,1,400,7600),
(6,5,700,2900),
(6,3,330,1000),
(6,2,110,2000),
(6,1,290,3500),
(8,6,50,4000);

use bakery1;
create table accounts(
id int primary key auto_increment,
prdct_ID int,
sell_amnt int,
purch_date DATE,
foreign key(prdct_ID) references Products(ID)
on delete cascade
on update cascade
);

insert into accounts(prdct_ID,sell_amnt,purch_date)
values
(4,500,'2020-12-15'),
(3,300,'2020-12-18'),
(1,240,'2020-12-22'),
(5,310,'2020-12-22'),
(4,570,'2020-12-23'),
(7,690,'2020-12-23'),
(5,700,'2020-12-24'),
(3,200,'2020-12-24'),
(2,250,'2020-12-24');
