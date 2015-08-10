/*
 * 機器構成取得
 */
IF OBJECT_ID('dbo.FindEquipmentConfigurationBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindEquipmentConfigurationBy
END

GO
CREATE PROCEDURE FindEquipmentConfigurationBy (
  @ProjectID int
) AS
BEGIN

  SELECT
     e.id            AS ID
    ,e.project_id    AS ProjectID
    ,e.maker_name    AS MakerName
    ,e.equip_name    AS EquipName
    ,e.rating        AS Rating
    ,e.unit_count    AS UnitCount
    ,e.irr_temp_flag AS IrrTempFlag
  FROM EQUIPMENT_CONFIGURATIONS AS e
  WHERE e.project_id = @ProjectID
  ORDER BY e.id
END