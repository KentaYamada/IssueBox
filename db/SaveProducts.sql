/*
 * 製品情報保存
 */

IF OBJECT_ID('dbo.SaveProducts') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveProducts
END

GO
CREATE PROCEDURE SaveProducts (
    @product PRODUCT_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO PRODUCT AS t1
      USING(SELECT * FROM @product) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = t2.name
       ,version = t2.version
       ,enable_flag = t2.enable_flag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        name
       ,version
       ,enable_flag
       ,upd_date
      )
      VALUES (
        t2.name
       ,t2.version
       ,t2.enable_flag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
