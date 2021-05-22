use bakery1;
/*to delete employee and references*/
DELIMITER //
CREATE PROCEDURE tbEmployee(in i_id int)
BEGIN
	Delete from Employee where ID = i_id;
END//
DELIMITER ;
/*to delete supplier and the references*/
DELIMITER //
CREATE PROCEDURE `tbSuppliers`(IN i_id int)
BEGIN
	Delete from Suppliers where ID = i_id;
END//
DELIMITER ;
/* to delete customer and the references*/
DELIMITER //
CREATE PROCEDURE `tbCustomer`(IN i_id int)
BEGIN
	Delete from Customer where ID = i_id;
END//
DELIMITER ;
/*to delete Products and the references*/
DELIMITER //
CREATE PROCEDURE `tbProducts`(IN i_id int)
BEGIN
	Delete from products where ID = i_id;
END//
DELIMITER ;
/*to delete Stocke and the references*/
DELIMITER //
CREATE PROCEDURE `tbStock`(IN i_id int)
BEGIN
	Delete from Stock where ID = i_id;
END//
DELIMITER ;
/*to delete Orders and the references*/
DELIMITER //
CREATE PROCEDURE `tbOrders`(IN i_id int)
BEGIN
	Delete from Orders where ID = i_id;
END//
DELIMITER ;
/*to Display order data */
DELIMITER //
CREATE PROCEDURE `display_Orders`()
BEGIN
	select o.ID,o.ord_Date as order_date,c.Name as Customer,e.Name as salesman
	from Customer c inner join Orders o
	on c.ID = o.cust_ID 
	inner join Employee e on e.ID = o.emp_ID ; 
END//
DELIMITER ;
/*to display order record  */
DELIMITER //
CREATE PROCEDURE `ord_detail`(in idd int)
BEGIN
	select o.ID,p.Name as Product,p.Price,d.Qty as Quantity ,d.bill as total_Price
	from products p inner join ord_Drived d
	on d.prdct_ID=p.ID inner join Orders o
	on o.ID = d.ord_ID 
	where o.ID = idd;
END//
DELIMITER ;
/*to calculate the total amount of product purchased*/
DELIMITER //
CREATE PROCEDURE `total_amount`(in i_id int)
BEGIN
	select sum(d.bill) as Total from ord_Drived d where ord_ID = i_id;
END//
DELIMITER ;
/*to add the order*/
DELIMITER //
CREATE PROCEDURE `add_order`(in i_cid int,in i_eid int)
BEGIN
	insert into Orders(cust_ID,emp_ID) values(i_cid,i_eid);
END//
DELIMITER ;
/*to take the order*/
DELIMITER //
CREATE PROCEDURE `take_order`(in i_pid int,in i_qdy int)
BEGIN
	if exists (select * from Products where id = i_pid and qty>i_qty) then
	insert into ord_Drived values(i_pid,i_qty,(select Price * i_qty from Products where ID = i_pid),(select max(ID) from Orders));
	update Products set qty = qty-i_qty where id=i_pid;
    End if;
END//
DELIMITER ;
/*to display  stock names*/
DELIMITER //
CREATE PROCEDURE `display_Stock`()
BEGIN
	select s.ID,p.Name as Product,su.Name as Suplier,s.Qty as Quantity,s.supplied_amnt as Supplied_Amount
	from Products p  inner join Stock s 
	on s.prdct_ID = p.ID inner join 
	Suppliers su on su.ID = s.Sup_ID;
END//
DELIMITER ;
/*to keep the records of the supplied procedures*/
DELIMITER //
CREATE PROCEDURE `proc_accounts`(in i_pid int)
BEGIN
	update Products set qty = qty+(select qty from Stock where prdct_ID=2008) where id=i_pid ;
	insert into Accounts(prdct_ID,sell_amnt) values (i_pid,(select supplied_amnt from Stock where prdct_ID=i_pid));

END//
DELIMITER ;
/*to show the account detail*/
DELIMITER //
CREATE PROCEDURE `proc_acnt_detail`(in i_from datetime,in i_to datetime)
BEGIN
	select a.id as ID, p.name,sell_amnt as Buy_In,a.purch_date as purchase_Date from Accounts a
	inner join Products p on a.prdct_id = p.ID 
	where a.purch_date>=i_from and a.purch_date<=i_to;
END//
DELIMITER ;
/*to calculate the net sale*/
DELIMITER //
CREATE PROCEDURE `proc_net_sale`(st_date datetime,
end_date datetime)
BEGIN
	select count(ord.ID)as Total_Orders, sum(d.bill) as Total_Sale
	from Orders ord inner join ord_Drived d on d.ord_ID=ord.ID where ord.ord_Date >= st_date and ord.ord_Date<=end_date;

END//
DELIMITER ;
/*to calculate the total purchase*/
DELIMITER //
CREATE PROCEDURE `proc_net_purchase`(st_date datetime, end_date datetime)
BEGIN
	select count(ID) as Total_Supplies,sum(sell_amnt)as Total_purchase_Amount from Accounts where purch_date >= st_date and purch_date<= end_date ;
END//
DELIMITER ;
/*to sum the salaries*/
DELIMITER //
CREATE PROCEDURE `proc_net_saleries`()
BEGIN
	select count(ID) as Salesman,sum(Salary) as Month_Salary  
    from Employee;
END//
DELIMITER ;
/*to get the top 5 products*/
DELIMITER //
CREATE PROCEDURE `proc_popular_product`(in st_date datetime, in end_date datetime)
BEGIN
	select  p.Name, sum(ord.Qty) as Qty, SUM(ord.bill) as Sale
	from ord_Drived ord inner join Products p on ord.prdct_ID=p.ID inner join Orders o on ord.ord_ID=o.ID
	where o.ord_Date>= st_date And o.ord_Date<= end_date
	group by p.Name
	Order by sum(ord.Qty) desc
    Limit 5;
END//
DELIMITER ;
/*to get the daily customers*/
DELIMITER //
CREATE PROCEDURE `proc_Daily_customer`(in st_date datetime, in end_date datetime)
BEGIN
	select  c.Name As Daily_Customer, c.ID as ID,count(o.cust_ID) as Daily_Purchase
	from Customer c inner join Orders o on o.cust_ID=c.ID
	where o.ord_Date>= st_date And o.ord_Date<= end_date
	group by c.Name,c.ID
	Order by count(o.cust_ID) desc
    Limit 5;
END//
DELIMITER ;
/*to get the sale - purchase */
DELIMITER //
CREATE PROCEDURE `proc_Balance_sheet`(in st_date datetime, in end_date datetime)
BEGIN
	select (select sum(ord.bill)
	from ord_Drived ord inner join Orders o on ord.ord_ID=o.ID 
    where o.ord_Date>= st_date and o.ord_Date<=end_date)-(select sum(sell_amnt) from Accounts where purch_date>= st_date and purch_date <= end_date) as Balance_Sheet;

END//
DELIMITER ;
/*to add the product */
DELIMITER //
CREATE PROCEDURE Add_Products(in Name varchar(50), in Price int, in Qty int)
BEGIN
	insert into Products values (Name,Price,Qty);
END//
DELIMITER ;
/* t0 Add Stock */
DELIMITER //

CREATE PROCEDURE Add_Stock(in i_Sup_ID int,in i_S_Qty int,in Supplied_Amt int)
BEGIN
	insert into Stock(prdct_ID ,Sup_ID,Qty,supplied_amnt) 
    values ((Select max(ID) from Products), i_Sup_ID, i_S_Qty, i_Supplied_Amt);
END //

DELIMITER ;


/*procedure to add Employee*/
DELIMITER //

CREATE PROCEDURE Add_Employee( 
in Name varchar(30),in Email varchar(30), in PhoneNumber int,
 in Adress varchar(30), in City varchar(30), in Salary int, in HireDate datetime)

BEGIN
	insert into Employee(name, email, PhoneNumber, Adress, City, Salary, HireDate ) 
    values(Name,Email,PhoneNumber,Adress,City,Salary,HireDate);
END //

DELIMITER ;



/*Add Supplier*/

DELIMITER //

CREATE PROCEDURE Add_Suppliers(
in Name varchar(30),in adress varchar(30),in city varchar(30), in phoneNumber int)
BEGIN
	insert into Suppliers(Name,Adress,City,phoneNumber) values(Name,Adress,City,phoneNumber);
END //

DELIMITER ;


/*Add Customer*/

DELIMITER //

CREATE PROCEDURE  Add_Customer(
in name varchar(50), in Email varchar(50), in address varchar(50),in city varchar(50),in PhoneNumber int,
in Grade varchar(50))
BEGIN
	insert into Customer(Name,Email,Address,City,PhoneNumber,Grade)
    values();
END //

DELIMITER ;
