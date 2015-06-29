/*
 * カテゴリ登録テスト
 * 期待値:ロールバック
 */
use IssueBox_Dev
--テストデータ作成
INSERT INTO CATEGORIES (name, enable_flag, upd_date)
                VALUES ('test1', 'TRUE', GETDATE())
                      ,('test2', 'FALSE', GETDATE())
                      ,('test3', 'TRUE', GETDATE())

--テストデータ確認
SELECT * FROM CATEGORIES AS c ORDER BY c.id

--新規挿入データ作成
DECLARE @ID int
DECLARE @Name nvarchar(20)
DECLARE @EnableFlag bit
SET @ID = 0
SET @Name = 'this is new row'
SET @EnableFlag = 'TRUE'

--テスト対象プログラム実行
EXEC SaveCategory @ID, @Name, @EnableFlag

--テストデータ確認
SELECT * FROM CATEGORIES AS c ORDER BY c.id DESC

--更新用データ作成
SET @ID = 3
SET @Name = null
SET @EnableFlag = 'False'

--テスト対象プログラム実行
EXEC SaveCategory @ID, @Name, @EnableFlag

--テストデータ確認
SELECT * FROM CATEGORIES AS c ORDER BY c.id

--投入データ削除
DELETE FROM CATEGORIES

--ID列採番リセット
DBCC CHECKIDENT(CATEGORIES, RESEED, 0)
