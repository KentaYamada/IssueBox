/*
 * カテゴリ情報保存
 */

IF OBJECT_ID('dbo.SaveCategories') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveCategories
END

GO
CREATE PROCEDURE SaveCategories (
    @category PROJECT_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO PROJECTS AS t1
      USING(SELECT * FROM @category) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = t2.name
       ,enable_flag = t2.enable_flag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        name
       ,enable_flag
       ,upd_date
      )
      VALUES (
        t2.name
       ,t2.enable_flag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
