/*
 * メンバー情報保存
 */
IF OBJECT_ID('dbo.SaveMembers') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveMembers
END

GO
CREATE PROCEDURE SaveMembers (
    @member MEMBER_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO MEMBERS AS t1
      USING(SELECT * FROM @member) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = t2.name
       ,login_id = t2.login_id
       ,login_password = t2.login_password
       ,enable_flag = t2.enable_flag
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
        t2.name
       ,t2.login_id
       ,t2.login_password
       ,t2.enable_flag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
