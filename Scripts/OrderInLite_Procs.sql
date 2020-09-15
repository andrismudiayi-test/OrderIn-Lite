/* stored proc: Searching through Menu Items */


SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
ALTER PROCEDURE dbo.SearchFoodByCity @FoodName nvarchar(30), @CityName nvarchar(30)
AS

SELECT
    m.Name AS MenuItemName,
	m.Price,
	c.Name AS CategoryName,
	ct.Name AS CityName,
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

CREATE PROCEDURE dbo.usp_PlaceFoodOrder ( @CustomerIdValue int, @MenuItemId int, @OrderIdValue int OUTPUT )

AS

BEGIN
	 BEGIN TRY
 
       BEGIN TRANSACTION

		INSERT INTO FoodOrder (OrderTime,OrderstatusId, CustomerId) 
		VALUES (GETDATE(), 1,@CustomerIdValue)

 		SET @OrderIdValue = @@Identity

		INSERT INTO OrderItem VALUES (@OrderIdValue, @MenuItemId)

		SELECT @OrderIdValue
		
	   COMMIT TRANSACTION
	  END TRY

   BEGIN CATCH 

      IF @@TRANCOUNT > 0
         ROLLBACK
 
      SELECT ERROR_NUMBER() AS ErrorNumber
      SELECT ERROR_MESSAGE() AS ErrorMessage
 
   END CATCH
END

GO
