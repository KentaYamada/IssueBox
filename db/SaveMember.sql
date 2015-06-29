/*
 * メンバー情報保存
 */
IF OBJECT_ID('dbo.SaveMember') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveMember
END

GO
CREATE PROCEDURE SaveMember (
     @ID            int
    ,@Name          nvarchar(20)
    ,@LoginID       nvarchar(10)
    ,@LoginPassword nvarchar(10)
    ,@EnableFlag    bit
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO MEMBERS AS t1
      USING(SELECT @ID AS id) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = @Name
       ,login_id = @LoginID
       ,login_password = @LoginPassword
       ,enable_flag = @EnableFlag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        name
       ,login_id
       ,login_password
       ,enable_flag
       ,upd_date
      )
      VALUES (
        @Name
       ,@LoginID
       ,@LoginPassword
       ,@EnableFlag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
