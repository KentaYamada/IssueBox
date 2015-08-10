/*
 * サービス取得
 */

IF OBJECT_ID('dbo.FindAllServices') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindAllServices
END

GO
CREATE PROCEDURE FindAllServices
AS
BEGIN
  DECLARE @EnableFlag bit = CONVERT(bit, 'TRUE')
  DECLARE @ProductType int = 2  --製品種別(1:製品/2:サービス)
   
  SELECT
    p.id
   ,p.name
  FROM PRODUCTS AS p
  WHERE p.product_type = @ProductType
    AND p.enable_flag = @EnableFlag
END