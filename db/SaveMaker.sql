/*
 * メーカー情報保存
 */

IF OBJECT_ID('dbo.SaveMaker') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveMaker
END

GO
CREATE PROCEDURE SaveMaker (
   @ID          int
  ,@Name        nvarchar(20)
  ,@EnableFlag  bit
  ,@Equipments  EQUIPMENTS_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    --メーカーマスタ登録/更新
    MERGE INTO MAKERS AS t1
      USING (SELECT @ID AS id) t2 ON t1.id = t2.id
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

     --機器登録件数取得
     DECLARE @count int
     SET @count = (SELECT COUNT(id) FROM @Equipments)
     
     IF @@ROWCOUNT > 0 AND @count > 0
     BEGIN
       --メーカーID取得
       IF @ID < 1
       BEGIN
         SET @ID = (SELECT MAX(m.id) FROM MAKERS AS m)
       END
       
       --機器マスタ登録/更新
       MERGE INTO EQUIPMENTS AS t1
         USING (SELECT * FROM @Equipments) t2 ON t1.id = t2.id
       WHEN MATCHED THEN
         UPDATE SET
           name = t2.name
          ,rating = t2.rating
          ,communication_method_id = t2.communication_method_id
          ,output_control_flag = t2.output_control_flag
          ,maker_id = @ID
          ,enable_flag = t2.enable_flag
          ,upd_date = GETDATE()
       WHEN NOT MATCHED THEN
         INSERT (
           name
          ,rating
          ,communication_method_id
          ,output_control_flag
          ,maker_id
          ,enable_flag
          ,upd_date
         )
         VALUES (
           t2.name
          ,t2.rating
          ,t2.communication_method_id
          ,t2.output_control_flag
          ,@ID
          ,t2.enable_flag
          ,GETDATE()
         );
     END

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
