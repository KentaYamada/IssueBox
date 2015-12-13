/*
 * ユーザー定義タイプSQL
 * v1.0:新規作成
 */


IF TYPE_ID('dbo.EQUIPMENTS_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.EQUIPMENTS_T
END

IF TYPE_ID('dbo.EQUIPMENT_CONFIGURATIONS_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.EQUIPMENT_CONFIGURATIONS_T
END

--機器
CREATE TYPE EQUIPMENTS_T AS TABLE (
   id                      int
  ,name                    nvarchar(20)
  ,rating                  decimal(5, 2)
  ,communication_method_id int
  ,output_control_flag     bit
  ,maker_id                int
  ,enable_flag             bit
)

--機器構成
CREATE TYPE EQUIPMENTCONFIGURATIONS_T AS TABLE (
   id            int
  ,project_id    int
  ,maker_name    nvarchar(20)
  ,equip_name    nvarchar(20)
  ,rating        decimal(4, 1)
  ,unit_count    int
  ,irr_temp_flag bit
)
