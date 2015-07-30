/*
 * 単位一覧取得
 * @param Name String 単位名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 条件に該当する単位一覧
 */

IF OBJECT_ID('dbo.FindUnitsBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindUnitsBy
END

GO
CREATE PROCEDURE FindUnitsBy (
  @Name nvarchar(20)
 ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     u.id          AS ID
    ,u.name        AS Name
    ,u.enable_flag AS EnableFlag
  FROM UNITS AS u
  WHERE (u.name LIKE '%' + @Name + '%' OR @Name IS NULL)
  AND (u.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY u.id
END