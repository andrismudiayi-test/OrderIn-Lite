/* Data Inserts */

USE ORDERINLITE

/* City: Id, Name */

SET IDENTITY_INSERT City ON
INSERT INTO City (Id, Name) VALUES(1, N'Johannesburg');
INSERT INTO City (Id, Name) VALUES(2, N'Cape Town');
INSERT INTO City (Id, Name) VALUES(3, N'Pretoria'); 
SET IDENTITY_INSERT City OFF

/* Category: */

SET IDENTITY_INSERT Category ON
INSERT INTO Category (Id, Name) VALUES(1, N'Wholesome Vegetarian Meals'); 
INSERT INTO Category (Id, Name) VALUES(2, N'Mains'); 
INSERT INTO Category (Id, Name) VALUES(3, N'Vegetarian Curries'); 
INSERT INTO Category (Id, Name) VALUES(4, N'Grills'); 
INSERT INTO Category (Id, Name) VALUES(5, N'Tacos'); 
INSERT INTO Category (Id, Name) VALUES(6, N'Vegetarian Menu'); 
INSERT INTO Category (Id, Name) VALUES(7, N'appetizers'); 
INSERT INTO Category (Id, Name) VALUES(8, N'Salads'); 
INSERT INTO Category (Id, Name) VALUES(9, N'Sandwiches & Tacos'); 
INSERT INTO Category (Id, Name) VALUES(10, N'Seafood'); 
INSERT INTO Category (Id, Name) VALUES(11, N'Vegetarian Dishes'); 
INSERT INTO Category (Id, Name) VALUES(12, N'Vegetarian & Banting Meals');
INSERT INTO Category (Id, Name) VALUES(13, N'Tacos (Served Day & Night)');
INSERT INTO Category (Id, Name) VALUES(14, N'Vegan Light Meals');
INSERT INTO Category (Id, Name) VALUES(15, N'Vegetarian Burger (Served Day & Night)');
SET IDENTITY_INSERT Category OFF

/*
Restaurant: Id, Name, CityId, Suburb, LogoPath, RankId
*/

SET IDENTITY_INSERT Restaurant ON
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(2380, N'Barcelos',3 , N'Pretoria', N'https:\/\/restaurantbanners.orderin.co.za\/barcelos_109_cropped\/620.jpg', 0); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1361, N'CHIAPAS eat mexican', 1, N'Rosebank','https:\/\/restaurantbanners.orderin.co.za\/chiapas-eat-mexican_736_cropped\/620.jpg', 1);
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(2438, N'CHIAPAS eat mexican', 3, N'Brooklyn','https:\/\/restaurantbanners.orderin.co.za\/chiapas-eat-mexican_736_cropped\/620.jpg', 8); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1343, N'Curry Up', 1, N'Randburg', N'https:\/\/restaurantbanners.orderin.co.za\/curry-up_722_cropped\/620.jpg', 3); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1029, N'El Jalapeno', 1, N'Linden', N'https:\/\/restaurantbanners.orderin.co.za\/el-jalapeno_528_cropped\/620.jpg', 9); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1558, N'Hokey Poke', 2, N'CBD', N'https:\/\/restaurantbanners.orderin.co.za\/hokey-poke_839_cropped\/620.jpg', 8); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1641, N'Hokey Poke', 2, N'Sea Point', N'https:\/\/restaurantbanners.orderin.co.za\/hokey-poke_839_cropped\/620.jpg', 1); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(830, N'Hooters', 1, N'Fourways', N'https:\/\/restaurantbanners.orderin.co.za\/hooters_413_cropped\/620.jpg', 0); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1076, N'Hooters', 3, N'Pretoria', N'https:\/\/restaurantbanners.orderin.co.za\/hooters_413_cropped\/620.jpg', 6); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(935, N'Hudsons', 2, N'Green Point', N'https:\/\/restaurantbanners.orderin.co.za\/hudsons_470_cropped\/620.jpg', 5); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(989, N'Hudsons', 2, N'Gardens', N'https:\/\/restaurantbanners.orderin.co.za\/hudsons_470_cropped\/620.jpg', 9); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1028, N'Hudsons', 2, N'Claremont', N'https:\/\/restaurantbanners.orderin.co.za\/hudsons_470_cropped\/620.jpg', 9); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1031, N'Hudsons', 1, N'Parkhusrt', N'https:\/\/restaurantbanners.orderin.co.za\/hudsons_470_cropped\/620.jpg', 9); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1200, N'Hudsons', 3, N'Hazelwood', N'https:\/\/restaurantbanners.orderin.co.za\/hudsons_470_cropped\/620.jpg', 9); 

INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(859, N'jewel of India', 2, 'Foreshore', 'https:\/\/restaurantbanners.orderin.co.za\/jewel-of-india_437_cropped\/620.jpg', 9); 

INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1491, N'Jimmys Killer Prawns',3 , N'Umhlanga','https:\/\/restaurantbanners.orderin.co.za\/jimmy-s-killer-prawns_158_cropped\/620.jpg', 1); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1524, N'Jimmys Killer Prawns',1 , N'Fordsberg','https:\/\/restaurantbanners.orderin.co.za\/jimmy-s-killer-prawns_158_cropped\/620.jpg', 4); 

INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1269, N'Knead', 2, N'Gardens', N'https:\/\/restaurantbanners.orderin.co.za\/knead_652_cropped\/620.jpg', 9); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1381, N'Knead', 2, N'Panorama', N'https:\/\/restaurantbanners.orderin.co.za\/knead_652_cropped\/620.jpg', 7); 
INSERT INTO Restaurant (Id, Name, CityId, Suburb, LogoPath, Rank) VALUES(1488, N'Knead', 2, N'Kenilworth', N'https:\/\/restaurantbanners.orderin.co.za\/knead_652_cropped\/620.jpg', 8); 
SET IDENTITY_INSERT Restaurant OFF


/*
MenuItems: Id, Name,RestaurantId, CategoryId, Price 
*/

SET IDENTITY_INSERT MenuItem ON
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(941580, N'Vegetarian Burger', 2380, 1 ,16.9000); 
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(941581, N'Vegetarian Stir Fry & Rice',2380, 1, 42.9000); 
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(941582, N'Vegetarian Schwarma', 2380, 1, 141.9000); 

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1315807, N'Crispy Tacos',1361,  2, 80.0000); 
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1315808, N'Soft Tacos',1361,  2, 80.0000); 

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1137091, N'Crispy Tacos',2438,  2, 80.0000); 
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1137092, N'Soft Tacos',2438,  2, 80.0000); 


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346579, N'The OMG Dhal & Brinjals',1343,3, 73.9500);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346580, N'The Powerhouse Dhal Makhni', 1343, 3, 79.9500);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346584, N'Howzit Chana Masala', 1343, 3, 73.900 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346585, N'Bombay Potatoes', 1343, 3, 74.950 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346586, N'The cant get enough of Aloo Jeera', 1343, 3, 67.098 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346587, N'The Green Velvet Aloo Palak', 1343, 3, 56.9000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346588, N'Paneer & Aloo Palak', 1343, 3, 79.8000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346589, N'Paneer & Aloo Tikka Masala', 1343, 3, 78.950);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346590, N'Paneer & Aloo Makhni', 1343, 3, 48.9999);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346591, N' "The oh so comforting Paneer Korma', 1343, 3, 59.9999);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346592, N'Paneer Palak', 1343, 3, 50.9000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346593, N'Gentle Paneer Makhni', 1343, 3, 65.999 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346594, N'Paneer Tikka Masala', 1343, 3, 80.3000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346595, N'Our Veg & Paneer Signature Meal', 1343, 3, 99.005 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346596, N'Chickpea, Veg & Coconut Exotica', 1343, 3, 95.9000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1346597, N't hurts so good Vegetable Jalfrezi', 1343, 3, 75.9000 );



INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263596, N'Grilled Hard Tacos', 1029 , 4, 92.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263588, N'Carne Tacos', 1029 , 5, 74.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263589, N'Pollo Tacos', 1029 , 5, 93.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263590, N'Puerco Tacos', 1029 , 5, 27.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263591, N'Pescado Tacos', 1029 , 5, 89.950);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1263592, N'Vegetarino Tacos', 1029 , 5, 35.000);


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1392554, N'Teriyaki Tofu Starter (Vegan)', 1558, 6, 90.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1392555, N'LA Flight Bowl (Gluten-free)', 1558, 6, 45.000 );
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1392558, N'Naughty Girl (Vegan)', 1558, 6, 75.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1392568, N'Red Summer (Vegan\/Gluten-free)', 1558, 6, 78.650 );


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1392598, N'Teriyaki Tofu Starter (Vegan)', 1641, 6, 40.000 );

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266160, N'Wise Choice Fish Tacos', 830, 7, 89.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266161, N'Wise Choice Shrimp Tacos', 830, 7, 112.098);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266199, N'Taco Salad', 830, 8, 59.897);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266189, N'Smothered Chicken Sandwich', 830, 9, 60.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266190, N'Philly Cheese Steak Sandwich', 830, 9, 90.222);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266191, N'Chicken Speed Way Sandwich', 830, 9, 19.089);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266192, N'Buffalo Chicken Tacos', 830, 9, 25.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266193, N'Baja Fish Tacos', 830, 9, 36.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266194, N'Baja Shrimp Tacos', 830, 9, 98.675);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266202, N'Baja Fish Tacos', 830, 10, 25.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266203, N'Baja Shrimp Tacos', 830, 10 , 90.000);


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266282, N'Wise Choice Fish Tacos', 1076, 7, 89.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266283, N'Wise Choice Shrimp Tacos', 1076, 7, 112.098);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266321, N'Taco Salad', 1076, 8, 59.897);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266311, N'Smothered Chicken Sandwich', 1076, 9, 60.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266312, N'Philly Cheese Steak Sandwich', 1076, 9, 90.222);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266313, N'Chicken Speed Way Sandwich', 1076, 9, 19.089);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266314, N'Buffalo Chicken Tacos', 1076, 9, 25.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266315, N'Baja Fish Tacos', 1076, 9, 36.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266316, N'Baja Shrimp Tacos', 1076, 9, 98.675);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266324, N'Baja Fish Tacos', 1076, 10, 25.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1266325, N'Baja Shrimp Tacos', 1076, 10 , 90.000);


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389883, N'Falafel Taco', 935, 4, 123.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389884, N'Free Range Chicken Taco', 935, 4, 100.000 );

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1288551, N'Falafel Taco', 989, 4, 123.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1288632, N'Free Range Chicken Taco', 989, 4, 100.000 );

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389786, N'Falafel Taco', 1028, 4, 123.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389787, N'Free Range Chicken Taco', 1028, 4, 100.000 );

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1390077, N'Falafel Taco', 1031, 4, 123.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1390078, N'Free Range Chicken Taco', 1031, 4, 100.000 );

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389980, N'Falafel Taco', 1200, 4, 123.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1389981, N'Free Range Chicken Taco', 1200, 4, 100.000 );



INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(207208, N'304 Aloo Peas-Dry', 859, 3 ,91.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(207209, N'305 Aloo Jeera', 859, 3, 91.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(207215, N'311 Methi Malai Mutter', 859 , 3, 92.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(769348, N'303 Palak Paneer', 859 , 3, 103.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020532, N'302 Paneer Makhani', 859 , 3, 103.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020535, N'307 Punjabi Dum Aloo', 859 , 3, 97.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020537, N'308 Vegetable Korma', 859 , 3, 109.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020538, N'309 Vegetable Hyderabadi', 859 , 3, 97.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020543, N'312 Veg Jalfrezi', 859 , 3, 97.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020552, N'316 Daal Tadka', 859 , 3, 91.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020553, N'317 Daal Palak Lasooni', 859 , 3, 97.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020566, N'314 Allo Gobhi Adraki', 859 , 3, 103.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020615, N'320 Vegetable Mohini', 859 , 3, 103.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1020623, N'321 Paneer Lababdar', 859 , 3, 109.0000);
			

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(881403,  N'Vegetarian Pizza', 1491 , 4, 85.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1238151, N'Vegetable Soup', 1491 , 4, 50.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1238152, N'Vegetable Burger & Chips', 1491 , 4, 65.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1238153, N'Vegetarian Pasta', 1491 , 4, 95.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1238154, N'Vegetable Curry', 1491 , 4, 99.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1238155, N'Vegetable Platter', 1491 , 4, 110.000);

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184604, N'Grilled Lamb Chops', 1524, 12, 150.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184606, N'Prawns & Veggies Stir Fry',1524, 12, 130.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184607, N'Vegetable Soup', 1524, 12, 50.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184608, N'Vegetable Burger & Chips', 1524, 12, 65.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184609, N'Vegetarian Pizza', 1524, 12, 85.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184610, N'Vegetarian Pasta', 1524, 12, 95.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184611, N'Vegetable Curry', 1524, 12, 99.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1184612, N'Vegetable Platter', 1524, 12, 110.0000);


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332565, N'BBQ Pulled Pork Taco', 1269, 13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332566, N'Buttermilk Fried Chicken Taco', 1269, 13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332567, N'Falafel Taco', 1269, 13, 99.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332568, N'Loaded Nachos', 1269, 13, 105.000);

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332580, N'Vegan Falafel Taco', 1269, 14, 99.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332665, N'Veggie Burger', 1269, 15, 76.0000);


INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332781, N'BBQ Pulled Pork Taco', 1381, 13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332782, N'Buttermilk Fried Chicken Taco', 1381,13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332783, N'Falafel Taco', 1381, 13, 99.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332784, N'Loaded Nachos', 1381, 13, 105.000);

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332785, N'Vegan Falafel Taco', 1381, 14, 99.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332786, N'Veggie Burger', 1381, 15, 76.0000);

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332997, N'BBQ Pulled Pork Taco', 1488, 13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332998, N'Buttermilk Fried Chicken Taco', 1488,13, 105.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1332999, N'Falafel Taco', 1488, 13, 99.000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1333000, N'Loaded Nachos', 1488, 13, 105.000);

INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1333012, N'Vegan Falafel Taco', 1488, 14, 99.0000);
INSERT INTO MenuItem (Id, Name, RestaurantId, CategoryId, Price) VALUES(1333013, N'Veggie Burger', 1488, 15, 76.0000);
SET IDENTITY_INSERT MenuItem OFF


/* order status :*/

SET IDENTITY_INSERT City ON
INSERT INTO OrderStatus (Id, Name) VALUES(1, N'Processing');
INSERT INTO OrderStatus (Id, Name) VALUES(2, N'Complete'); 
SET IDENTITY_INSERT City OFF



/* Customer: */

SET IDENTITY_INSERT City ON
INSERT INTO Customer (Id, Name, Address) VALUES(1, N'foo bar', N'14 benefits close woodstock, cape town');
INSERT INTO Customer (Id, Name, Address) VALUES(2, N'bar foo', N'');
INSERT INTO Customer (Id, Name, Address) VALUES(3, N'foo foo', N''); 
SET IDENTITY_INSERT City OFF




/* stored proc: Searching through Menu Items */


CREATE PROCEDURE dbo.SearchFoodByCity ( @FoodName nvarchar(30), @CityName nvarchar(30) )
AS

SELECT
    m.name,
	m.price,
	c.name,
	ct.Name,
	r.Rank
FROM
	MenuItem m
	INNER JOIN Category c ON m.CategoryId = c.Id
	INNER JOIN Restaurant r ON r.id = m.RestaurantId
	INNER JOIN City ct ON r.CityId = ct.Id
WHERE
	c.name LIKE '%' + @FoodName + '%'
	AND ct.name LIKE '%' + @CityName + '%'

ORDER BY r.Rank asc

GO

/* stored proc: insert items */

CREATE PROCEDURE dbo.PlaceFoodOrder ( @CustomerIdValue int, @MenuItemId int, @OrderIdValue int OUT )

AS

INSERT INTO FoodOrder VALUES (new datetime(), 1, @CustmerIdValue)

SET OrderIdValue = SELECT @@Identity

INSERT INTO OrderItems VALUES (@OrderIdValue, @MenuItemId)

SELECT @OrderIdValue

GO





