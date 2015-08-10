/*
 * サービス取得処理テスト
 */
use IssueBox_Test

INSERT INTO PRODUCTS VALUES ('Product A', NULL, 1, 'TRUE', GETDATE())
                           ,('Product B', NULL, 1, 'TRUE', GETDATE())
                           ,('Service A', NULL, 2, 'TRUE', GETDATE())
                           ,('Service B', NULL, 2, 'FALSE', GETDATE())
SELECT * FROM PRODUCTS

EXEC FindAllServices

DELETE FROM PRODUCTS

--連番リセット
DBCC CHECKIDENT(PRODUCTS, RESEED, 0)