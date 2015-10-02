/*
 * 案件テーブル定義変更、データ移行スクリプト
 * 注)デバッグ時は必ず「ROLLBACK TRANSACTION」を使用してデータすること
 */

BEGIN TRANSACTION

--データ退避テーブル作成
CREATE TABLE PROJECTS_BAK (
     id            int          NOT NULL identity
    ,project_id    nvarchar(20) NOT NULL
    ,name          nvarchar(40) NOT NULL
    ,product_id    int          NULL
    ,service_id    int          NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
)
GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT PROJECTS_BAK ON
  
  --データ退避
  INSERT INTO PROJECTS_BAK (
     id
    ,project_id
    ,name
    ,product_id
    ,service_id
    ,enable_flag
    ,upd_date
  )
  SELECT 
     id
    ,project_id
    ,name
    ,NULL
    ,NULL
    ,enable_flag
    ,upd_date 
  FROM PROJECTS
  
  --自動採番列にInsert不可に設定
  SET IDENTITY_INSERT PROJECTS_BAK OFF
  
  --件数確認
  SELECT COUNT(id) FROM PROJECTS
  SELECT COUNT(id) FROM PROJECTS_BAK
GO
  --テーブル削除
  DROP TABLE PROJECTS
GO
--テーブル定義変更  
CREATE TABLE PROJECTS (
     id            int          NOT NULL identity
    ,project_id    nvarchar(20) NOT NULL
    ,name          nvarchar(40) NOT NULL
    ,product_id    int          NULL
    ,service_id    int          NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
    ,unique(project_id)
)
GO
  --自動採番列にInsert可能に設定
  SET IDENTITY_INSERT PROJECTS ON
  
  --退避データ挿入
  INSERT INTO PROJECTS (
     id
    ,project_id
    ,name
    ,product_id
    ,service_id
    ,enable_flag
    ,upd_date
  )
  SELECT 
     id
    ,project_id
    ,name
    ,product_id
    ,service_id
    ,enable_flag
    ,upd_date 
  FROM PROJECTS_BAK
  
  SET IDENTITY_INSERT PROJECTS OFF
  
  --データ保存確認
  SELECT * FROM PROJECTS
  
  --退避用テーブル削除
  DROP TABLE PROJECTS_BAK

ROLLBACK TRANSACTION
--COMMIT TRANSACTION