/* SCRIPT: Create_DB.sql */
/* Building OrderInLite database */

SET NOCOUNT ON
GO

PRINT 'starting...'
IF EXISTS (SELECT 1 FROM SYS.DATABASES WHERE NAME = 'ORDERINLITE')
DROP DATABASE ORDERINLITE
GO
CREATE DATABASE ORDERINLITE
GO

:On Error exit

:r OrderInLite_entities.sql
:r OrderInLiteData.sql

PRINT 'Done!'
GO