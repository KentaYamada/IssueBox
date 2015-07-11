/*
 * 製品情報保存
 */

IF OBJECT_ID('dbo.SaveProduct') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveProduct
END

GO
CREATE PROCEDURE SaveProduct (
     @ID int
    ,@Name nvarchar(20)
    ,@Version nvarchar(10)
    ,@EnableFlag bit
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO PRODUCTS AS t1
      USING(SELECT @ID AS id) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = @Name
       ,[version] = @Version
       ,enable_flag = @EnableFlag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        name
       ,[version]
       ,enable_flag
       ,upd_date
      )
      VALUES (
        @Name
       ,@Version
       ,@EnableFlag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
