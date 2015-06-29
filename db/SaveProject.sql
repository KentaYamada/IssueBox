/*
 * プロジェクト情報保存
 */

IF OBJECT_ID('dbo.SaveProject') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveProject
END

GO
CREATE PROCEDURE SaveProject (
     @ID         int
    ,@ProjectID  nvarchar(20)
    ,@Name       nvarchar(20)
    ,@EnableFlag bit
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO PROJECTS AS t1
      USING (SELECT @ID AS ID) AS t2 ON t1.id = t2.ID
    WHEN MATCHED THEN
      UPDATE SET
        project_id = @ProjectID
       ,name = @Name
       ,enable_flag = @EnableFlag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        project_id
       ,name
       ,enable_flag
       ,upd_date
      )
      VALUES (
        @ProjectID
       ,@Name
       ,@EnableFlag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
