/*
 * 製品一覧取得
 * @param Name String 製品名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 検索条件に合致した製品一覧
 */

IF OBJECT_ID('dbo.FindProductsBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindProductsBy
END

GO
CREATE PROCEDURE FindProductsBy (
   @Name nvarchar(20)
  ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     p.id             AS ID
    ,p.name           AS Name
    ,p.[version]      AS [Version]
    ,p.enable_flag    AS EnableFlag
  FROM PRODUCTS AS p
  WHERE (p.name LIKE '%' + @Name +'%' OR @Name IS NULL)
    AND (p.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY p.id
END