/*
 * 製品テーブル定義変更、データ移行スクリプト
 * 注)デバッグ時は必ず「ROLLBACK TRANSACTION」を使用してデータすること
 */

BEGIN TRANSACTION

  --データ退避テーブル作成
  CREATE TABLE PRODUCTS_BAK (
     id            int          NOT NULL identity
    ,name          nvarchar(20) NOT NULL
    ,[version]     nvarchar(10) NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
  )
GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT PRODUCTS_BAK ON
  
  --データ退避
  INSERT INTO PRODUCTS_BAK (
     id
    ,name
    ,[version]
    ,enable_flag
    ,upd_date
  )
  SELECT 
     id
    ,name
    ,[version]
    ,enable_flag
    ,upd_date 
  FROM PRODUCTS
  
  --自動採番列にInsert不可に設定
  SET IDENTITY_INSERT PRODUCTS_BAK OFF
  
  --件数確認
  SELECT COUNT(id) FROM PRODUCTS
  SELECT COUNT(id) FROM PRODUCTS_BAK
GO
  --テーブル削除
  DROP TABLE PRODUCTS
GO
  --テーブル定義変更  
  CREATE TABLE PRODUCTS (
     id            int          NOT NULL identity
    ,name          nvarchar(20) NOT NULL
    ,version       nvarchar(15) NULL
    ,product_type  int          NOT NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
)
GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT PRODUCTS ON
  
  --退避データ挿入
  INSERT INTO PRODUCTS (
     id
    ,name
    ,[version]
    ,product_type
    ,enable_flag
    ,upd_date
  )
  SELECT
     id
    ,name
    ,[version]
    ,0
    ,enable_flag
    ,upd_date
  FROM PRODUCTS_BAK
  
  SET IDENTITY_INSERT PRODUCTS OFF
  
  --データ保存確認
  SELECT * FROM PRODUCTS
  
  --退避用テーブル削除
  DROP TABLE PRODUCTS_BAK

ROLLBACK TRANSACTION
--COMMIT TRANSACTION