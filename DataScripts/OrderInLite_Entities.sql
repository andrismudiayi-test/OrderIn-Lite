CREATE TABLE Category 
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(50) NOT NULL 
  ) 

GO

CREATE TABLE City 
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL 
  ) 

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

CREATE TABLE OrderStatus
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL 
  ) 
GO 

CREATE TABLE Customer
  ( 
     Id   INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     Name VARCHAR(20) NOT NULL,
	 Address VARCHAR(20) NOT NULL  
  ) 
GO 


CREATE TABLE FoodOrder 
  ( 
     Id           INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
     OrderTime    DATETIME  NOT NULL, 
     OrderStatusId     INT FOREIGN KEY REFERENCES OrderStatus(Id), 
     CustomerId   INT FOREIGN KEY REFERENCES Customer(Id)
  ) 

GO 


CREATE TABLE OrderItem 
  ( 
     FoodOrderId  INT FOREIGN KEY REFERENCES FoodOrder(Id), 
     MenuItemId INT FOREIGN KEY REFERENCES MenuItem(Id)
  ) 

GO 



