/* Create Entities  */

USE ORDERINLITE

IF OBJECT_ID('Category') IS NOT NULL
DROP TABLE DBO.Category
GO
CREATE TABLE Category 
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(50) NOT NULL 
  ) 

GO

IF OBJECT_ID('City') IS NOT NULL
DROP TABLE DBO.City
GO
CREATE TABLE City 
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL 
  ) 

GO

IF OBJECT_ID('Restaurant') IS NOT NULL
DROP TABLE DBO.Restaurant
GO
CREATE TABLE Restaurant 
  ( 
     Id       INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name     VARCHAR(20) NOT NULL, 
     CityId   INT FOREIGN KEY REFERENCES City(Id), 
     Suburb   VARCHAR(20) NOT NULL, 
     LogoPath VARCHAR (100) NOT NULL, 
     Rank     INT CHECK (rank<=10)NOT NULL 
  ) 

GO 

IF OBJECT_ID('MenuItem') IS NOT NULL
DROP TABLE DBO.MenuItem
GO
CREATE TABLE MenuItem 
  ( 
     Id           INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name         VARCHAR(50) NOT NULL, 
     RestaurantId INT FOREIGN KEY REFERENCES Restaurant(Id), 
     CategoryId   INT FOREIGN KEY REFERENCES Category(Id), 
     Price        DECIMAL NOT NULL 
  ) 

GO 



/*  orders */

IF OBJECT_ID('OrderStatus') IS NOT NULL
DROP TABLE DBO.OrderStatus
GO
CREATE TABLE OrderStatus
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL 
  ) 
GO 

IF OBJECT_ID('Customer') IS NOT NULL
DROP TABLE DBO.Customer
GO
CREATE TABLE Customer
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL,
	 Address VARCHAR(20) NOT NULL  
  ) 
GO 

IF OBJECT_ID('FoodOrder') IS NOT NULL
DROP TABLE DBO.FoodOrder
GO
CREATE TABLE FoodOrder 
  ( 
     Id           INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     OrderTime    DATETIME  NOT NULL, 
     OrderStatusId     INT FOREIGN KEY REFERENCES OrderStatus(Id), 
     CustomerId   INT FOREIGN KEY REFERENCES Customer(Id)
  ) 

GO 

IF OBJECT_ID('OrderItem') IS NOT NULL
DROP TABLE DBO.OrderItem
GO
CREATE TABLE OrderItem 
  ( 
     FoodOrderId  INT FOREIGN KEY REFERENCES FoodOrder(Id), 
     MenuItemId INT FOREIGN KEY REFERENCES MenuItem(Id)
  ) 

GO 



