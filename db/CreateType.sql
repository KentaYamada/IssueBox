/*
 * ユーザー定義タイプSQL
 * v1.0:新規作成
 */


IF TYPE_ID('dbo.EQUIPMENTS_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.EQUIPMENTS_T
END

--機器
CREATE TYPE EQUIPMENTS_T AS TABLE (
   id          int
  ,name        nvarchar(20)
  ,rating      real
  ,maker_id    int
  ,enable_flag bit
)

