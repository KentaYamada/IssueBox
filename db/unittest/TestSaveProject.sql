use IssueBox_Test

--テストデータ生成
DECLARE @ID int = 0
DECLARE @ProjectID nvarchar(20) = 'TEST001-00001'
DECLARE @Name nvarchar(20) = 'Test1'
DECLARE @ProductID int = 1
DECLARE @ServiceID int = 1
DECLARE @EnableFlag bit = CONVERT(bit, 'TRUE')
DECLARE @EquipConf EQUIPMENTCONFIGURATIONS_T

INSERT INTO @EquipConf VALUES (0, 0, 'Test1', 'Type-A', 100, 1, 'TRUE')
                             ,(0, 0, 'Test2', 'Type-B', 50, 1, 'TRUE')
                             ,(0, 0, 'Test3', 'Type-C', 10, 1, 'TRUE')

--データ確認
SELECT * FROM PROJECTS
SELECT * FROM EQUIPMENT_CONFIGURATIONS
SELECT * FROM @EquipConf

--テスト実行
EXEC SaveProject @ID, @ProjectID, @Name, @ProductID, @ServiceID, @EnableFlag, @EquipConf

--データ確認
SELECT * FROM PROJECTS
SELECT * FROM EQUIPMENT_CONFIGURATIONS

--テストデータ削除
DELETE FROM PROJECTS
DELETE FROM EQUIPMENT_CONFIGURATIONS

--連番リセット
DBCC CHECKIDENT(PROJECTS, RESEED, 0)
DBCC CHECKIDENT(EQUIPMENT_CONFIGURATIONS, RESEED, 0)