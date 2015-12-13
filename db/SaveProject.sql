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
    ,@ProductID  int
    ,@ServiceID  int
    ,@EnableFlag bit
    ,@EquipmentConfigurations EQUIPMENT_CONFIGURATIONS_T READONLY
) AS
BEGIN TRY
  BEGIN TRAN
    
    --案件マスタ登録/更新
    MERGE INTO PROJECTS AS t1
      USING (SELECT @ID AS ID) AS t2 ON t1.id = t2.ID
    WHEN MATCHED THEN
      UPDATE SET
        project_id = @ProjectID
       ,name = @Name
       ,product_id = @ProductID
       ,service_id = @ServiceID
       ,enable_flag = @EnableFlag
       ,upd_date = GETDATE()
    WHEN NOT MATCHED THEN
      INSERT (
        project_id
       ,name
       ,product_id
       ,service_id
       ,enable_flag
       ,upd_date
      )
      VALUES (
        @ProjectID
       ,@Name
       ,@ProductID
       ,@ServiceID
       ,@EnableFlag
       ,GETDATE()
     );

    --機器構成情報登録/更新
    IF @@ROWCOUNT > 0
    BEGIN
      --新規案件の場合、登録後に案件IDを取得する
      IF @ID < 1
      BEGIN
        SET @ID = (SELECT MAX(p.id) FROM PROJECTS AS p)
      END
      
      MERGE INTO EQUIPMENT_CONFIGURATIONS AS t1
        USING (SELECT * FROM @EquipmentConfigurations) t2 ON t1.id = t2.id
      WHEN MATCHED THEN
        UPDATE SET
           project_id = t2.project_id
          ,maker_name = t2.maker_name
          ,equip_name = t2.equip_name
          ,rating = t2.rating
          ,unit_count = t2.unit_count
          ,irr_temp_flag = t2.irr_temp_flag
          ,upd_date = GETDATE()
      WHEN NOT MATCHED THEN
        INSERT (
           project_id
          ,maker_name
          ,equip_name
          ,rating
          ,unit_count
          ,irr_temp_flag
          ,upd_date
       )
         VALUES (
           @ID
          ,t2.maker_name
          ,t2.equip_name
          ,t2.rating
          ,t2.unit_count
          ,t2.irr_temp_flag
          ,GETDATE()
       );
    END

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
