use IssueBox_Test

--テストデータ作成
DECLARE @Name       nvarchar(20)
DECLARE @EnableFlag bit
DECLARE @Equipment  EQUIPMENTS_T

SET @Name = 'Test'
SET @EnableFlag = 'TRUE'
INSERT INTO @Equipment VALUES (0, 'Test', 100.2, 0, 'TRUE')
                             ,(0, 'Test2', 100.5, 0, 'TRUE')

--テスト実行前確認
SELECT * FROM MAKERS
SELECT * FROM EQUIPMENTS

--ターゲットメソッド実行
EXEC SaveMaker 0, @Name, @EnableFlag, @Equipment

--テスト実行後確認
SELECT * FROM MAKERS
SELECT * FROM EQUIPMENTS

--テストデータ削除
DELETE FROM MAKERS
DELETE FROM EQUIPMENTS

--連番リセット
DBCC CHECKIDENT(MAKERS, RESEED, 0)
DBCC CHECKIDENT(EQUIPMENTS, RESEED, 0)