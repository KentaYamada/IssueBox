/*
 * メンバー一覧取得
 * @param Name String メンバー名
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 検索条件に合致したメンバー一覧
 */

IF OBJECT_ID('dbo.FindMembersBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindMembersBy
END

GO
CREATE PROCEDURE FindMembersBy (
   @Name nvarchar(20)
  ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
    m.id             AS ID
   ,m.name           AS Name
   ,m.login_id       AS LoginID
   ,m.login_password AS LoginPassword
   ,m.enable_flag    AS EnableFlag
  FROM MEMBERS AS m
  WHERE (m.name LIKE '%' + @Name +'%' OR @Name IS NULL)
    AND (m.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY m.id
END