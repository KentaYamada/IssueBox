/*
 * 機器一覧取得
 * @param ID Int メーカーID
 * @return メーカーIDに該当する機器一覧
 */

IF OBJECT_ID('dbo.FindEquipmentsBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindEquipmentsBy
END

GO
CREATE PROCEDURE FindEquipmentsBy (
  @ID int
)
AS
BEGIN
  SELECT
     e.id          AS ID
    ,e.name        AS Name
    ,e.rating      AS Rating
    ,e.maker_id    AS MakerID
    ,e.enable_flag AS EnableFlag
  FROM EQUIPMENTS AS e
  WHERE e.maker_id = @ID
  ORDER BY e.name
END