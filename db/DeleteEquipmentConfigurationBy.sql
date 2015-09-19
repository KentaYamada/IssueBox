/*
 * 機器構成削除
 */

GO
IF OBJECT_ID('dbo.DeleteEquipmentConfigurationBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.DeleteEquipmentConfigurationBy
END

GO
CREATE PROCEDURE dbo.DeleteEquipmentConfigurationBy (
  @ID int
) AS
BEGIN
  DELETE FROM EQUIP_CONFIGURATIONS WHERE id = @ID
END
