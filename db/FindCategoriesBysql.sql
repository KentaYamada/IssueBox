/*
 * カテゴリ一覧取得
 * @param Name String カテゴリ名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 条件に該当するカテゴリ一覧
 */

IF OBJECT_ID('dbo.FindCategoriesBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindCategoriesBy
END

GO
CREATE PROCEDURE FindCategoriesBy (
  @Name nvarchar(20)
 ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     c.id          AS ID
    ,c.name        AS Name
    ,c.enable_flag AS EnableFlag
  FROM CATEGORIES AS c
  WHERE (c.name LIKE '%' + @Name + '%' OR @Name IS NULL)
  AND (c.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY c.id
END