/*
 * メーカー一覧取得
 * @param Name String メーカー名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 条件に該当するメーカー一覧
 */

IF OBJECT_ID('dbo.FindMakersBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindMakersBy
END

GO
CREATE PROCEDURE FindMakersBy (
  @Name nvarchar(20)
 ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     m.id          AS ID
    ,m.name        AS Name
    ,m.enable_flag AS EnableFlag
  FROM MAKERS AS m
  WHERE (m.name LIKE '%' + @Name + '%' OR @Name IS NULL)
  AND (m.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY m.name
END