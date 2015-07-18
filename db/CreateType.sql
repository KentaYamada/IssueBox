/*
 * ユーザー定義タイプSQL
 * v1.0:新規作成
 */

IF TYPE_ID('dbo.PROJECT_T') IS NOT NULL
BEGIN
    DROP TYPE dbo.PROJECTS_T
END

IF TYPE_ID('dbo.MEMBER_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.MEMBER_T
END

IF TYPE_ID('dbo.CATEGORIE_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.CATEGORY_T
END

IF TYPE_ID('dbo.PRODUCT_T') IS NOT NULL
BEGIN
    DROP TYPE dbo.PRODUCT_T
END

IF TYPE_ID('dbo.EQUIPMENTS_T') IS NOT NULL
BEGIN
  DROP TYPE dbo.EQUIPMENTS_T
END

--案件
CREATE TYPE PROJECT_T AS TABLE (
     id            int
    ,project_id    nvarchar(20)
    ,name          nvarchar(20)
    ,member_id     int
    ,enable_flag   bit
)

--メンバー
CREATE TYPE MEMBER_T AS TABLE (
     id             int
    ,name           nvarchar(20)
    ,login_id       nvarchar(10)
    ,login_password nvarchar(10)
    ,enable_flag    bit
)

--カテゴリ
CREATE TYPE CATEGORY_T AS TABLE(
     id            int
    ,name          nvarchar(20)
    ,enable_flag   bit
)

--製品
CREATE TYPE PRODUCT_T AS TABLE(
     id            int
    ,name          nvarchar(20)
    ,varsion       nvarchar(10)
    ,enable_flag   bit
)

--機器
CREATE TYPE EQUIPMENTS_T AS TABLE (
   id          int
  ,name        nvarchar(20)
  ,maker_id    int
  ,enable_flag bit
  ,upd_date    datetime
)

