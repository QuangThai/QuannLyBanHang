USE NhaHang
GO

CREATE  PROCEDURE dbo.DeleteAllProcedures
AS 
  DECLARE @procName   VARCHAR(500)
  DECLARE cur  CURSOR
  FOR  SELECT [name]  FROM sys.objects  WHERE type = 'p'
  OPEN cur
 
  FETCH  NEXT  FROM cur  INTO @procName
  WHILE  @@fetch_status = 0
  BEGIN
  IF @procName <> 'DeleteAllProcedures'
  EXEC('drop procedure ' + @procName)
  FETCH  NEXT  FROM cur  INTO @procName
  END
  CLOSE cur
  DEALLOCATE cur
GO 
  GRANT  EXECUTE  ON dbo.DeleteAllProcedures  TO  PUBLIC
GO 
--drop proc  dbo.DeleteAllProcedures