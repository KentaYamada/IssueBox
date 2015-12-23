/*
 * Dropdownlistデータ取得
 */

IF OBJECT_ID('dbo.FindAllDropDownList') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindAllDropDownList
END

GO
CREATE PROCEDURE FindAllDropDownList (
    @Name nvarchar(40)
)
AS
BEGIN
  DECLARE @sql nvarchar(max)
  SET @sql = 'SELECT t.id AS ID, t.name AS Value FROM ' + @Name + ' AS t WHERE t.enable_flag = ''TRUE'' ORDER BY t.name'
  EXECUTE sp_executesql @sql
END