/*
 * 通信方式情報保存
 */

IF OBJECT_ID('dbo.SaveCommunicationMethod') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveCommunicationMethod
END

GO
CREATE PROCEDURE SaveCommunicationMethod (
     @ID int
    ,@Name nvarchar(20)
    ,@EnableFlag bit
) AS
BEGIN TRY
  BEGIN TRAN
    
    MERGE INTO COMMUNICATION_METHOD AS t1
      USING(SELECT @ID AS id) AS t2 ON t1.id = t2.id
    WHEN MATCHED THEN
      UPDATE SET
        name = @Name
       ,enable_flag = @EnableFlag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        name
       ,enable_flag
       ,upd_date
      )
      VALUES (
        @Name
       ,@EnableFlag
       ,GETDATE()
     );

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
