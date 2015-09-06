/*
 * 通信方式一覧取得
 * @param Name String 通信方式名(部分一致)
 * @param EnableFlag String データ有効(all:全て / true:有効 / false:無効)
 * @return 条件に該当する通信方式一覧
 */

IF OBJECT_ID('dbo.FindCommunicationMethodBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindCommunicationMethodBy
END

GO
CREATE PROCEDURE FindCommunicationMethodBy (
  @Name nvarchar(20)
 ,@EnableFlag nvarchar(5)
)
AS
BEGIN
  SELECT
     c.id          AS ID
    ,c.name        AS Name
    ,c.enable_flag AS EnableFlag
  FROM COMMUNICATION_METHOD AS c
  WHERE (c.name LIKE '%' + @Name + '%' OR @Name IS NULL)
  AND (c.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
  ORDER BY c.id
END
