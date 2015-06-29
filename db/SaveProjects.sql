/*
 * プロジェクト情報保存
 */

IF OBJECT_ID('dbo.SaveProjects') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveProjects
END

GO
CREATE PROCEDURE SaveProjects (
    @project PROJECT_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO PROJECTS AS t1
      USING(SELECT * FROM @project) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        project_id = t2.project_id
       ,name = t2.name
       ,member_id = t2.member_id
       ,enable_flag = t2.enable_flag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        project_id
       ,name
       ,member_id
       ,enable_flag
       ,upd_date
      )
      VALUES (
        t2.project_id
       ,t2.name
       ,t2.member_id
       ,t2.enable_flag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
