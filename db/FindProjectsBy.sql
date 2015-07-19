/*
 * 案件一覧取得
 * @param ProjectID String 案件ID
 * @param Name String 案件名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 検索条件に合致した案件一覧
 */

IF OBJECT_ID('dbo.FindProjectsBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindProjectsBy
END

GO
CREATE PROCEDURE FindProjectsBy (
   @ProjectID nvarchar(20)
  ,@Name nvarchar(20)
  ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     p.id             AS ID
    ,p.project_id     AS ProjectID
    ,p.name           AS Name
    ,p.enable_flag    AS EnableFlag
  FROM PROJECTS AS p
  WHERE (p.project_id LIKE '%' + @ProjectID +'%' OR @ProjectID IS NULL)
    AND (p.name LIKE '%' + @Name +'%' OR @Name IS NULL)
    AND (p.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY p.project_id
END