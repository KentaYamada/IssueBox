/*
 * 機器テーブル定義変更、データ移行スクリプト
 * 注)デバッグ時は必ず「ROLLBACK TRANSACTION」を使用してデータすること
 */

BEGIN TRANSACTION

--データ退避テーブル作成
CREATE TABLE EQUIPMENTS_BAK (
   id                      int           NOT NULL identity
  ,name                    nvarchar(20)  NOT NULL
  ,rating                  decimal(5, 1) NULL
  ,communication_method_id int           NULL
  ,output_control_flag     bit           NULL
  ,maker_id                int           NOT NULL
  ,enable_flag             bit           NOT NULL
  ,upd_date                datetime      NOT NULL
  ,primary key(id)
)

GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT EQUIPMENTS_BAK ON
  
  --データ退避
  INSERT INTO EQUIPMENTS_BAK (
     id
    ,name
    ,rating
    ,communication_method_id
    ,output_control_flag
    ,maker_id
    ,enable_flag
    ,upd_date
  )
  SELECT 
     id
    ,name
    ,rating
    ,communication_method_id
    ,output_control_flag
    ,maker_id
    ,enable_flag
    ,upd_date
  FROM EQUIPMENTS
  
  --自動採番列にInsert不可に設定
  SET IDENTITY_INSERT EQUIPMENTS_BAK OFF
  
  --件数確認
  SELECT COUNT(id) FROM EQUIPMENTS
  SELECT COUNT(id) FROM EQUIPMENTS_BAK
GO
  --テーブル削除
  DROP TABLE EQUIPMENTS
GO
--テーブル定義変更  
CREATE TABLE EQUIPMENTS (
   id                      int           NOT NULL identity
  ,name                    nvarchar(20)  NOT NULL
  ,rating                  decimal(5, 1) NULL
  ,communication_method_id int           NULL
  ,output_control_flag     bit           NULL
  ,irr_temp_flag           bit           NULL
  ,maker_id                int           NOT NULL
  ,enable_flag             bit           NOT NULL
  ,upd_date                datetime      NOT NULL
  ,primary key(id)
)
GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT EQUIPMENTS ON
  
  --退避データ挿入
  INSERT INTO EQUIPMENTS (
     id
    ,name
    ,rating
    ,communication_method_id
    ,output_control_flag
    ,irr_temp_flag
    ,maker_id
    ,enable_flag
    ,upd_date
  )
  SELECT 
     id
    ,name
    ,rating
    ,communication_method_id
    ,output_control_flag
    ,NULL
    ,maker_id
    ,enable_flag
    ,upd_date
  FROM EQUIPMENTS_BAK
  
  SET IDENTITY_INSERT EQUIPMENTS OFF
  
  --データ保存確認
  SELECT * FROM EQUIPMENTS
  
  --退避用テーブル削除
  DROP TABLE EQUIPMENTS_BAK

ROLLBACK TRANSACTION
--COMMIT TRANSACTION