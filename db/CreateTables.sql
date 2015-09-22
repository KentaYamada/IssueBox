/*
 * テーブル定義SQL
 * v1.0:新規作成
 */


IF DB_ID('IssueBox_Dev') IS NULL
BEGIN
  CREATE DATABASE IssueBox_Dev
END

use IssueBox_Dev

IF OBJECT_ID('dbo.PROJECTS') IS NOT NULL
BEGIN
    DROP TABLE dbo.PROJECTS
END

IF OBJECT_ID('dbo.EQUIPMENT_CONFIGURATIONS') IS NOT NULL
BEGIN
    DROP TABLE dbo.EQUIPMENT_CONFIGURATIONS
END

IF OBJECT_ID('dbo.MEMBERS') IS NOT NULL
BEGIN
  DROP TABLE dbo.MEMBERS
END

IF OBJECT_ID('dbo.CATEGORIES') IS NOT NULL
BEGIN
  DROP TABLE dbo.CATEGORIES
END

IF OBJECT_ID('dbo.PRODUCTS') IS NOT NULL
BEGIN
    DROP TABLE dbo.PRODUCTS
END

IF OBJECT_ID('dbo.ISSUES') IS NOT NULL
BEGIN
  DROP TABLE dbo.ISSUES
END

IF OBJECT_ID('dbo.MAKERS') IS NOT NULL
BEGIN
  DROP TABLE dbo.MAKERS
END

IF OBJECT_ID('dbo.EQUIPMENTS') IS NOT NULL
BEGIN
  DROP TABLE dbo.EQUIPMENTS
END

IF OBJECT_ID('dbo.UNITS') IS NOT NULL
BEGIN
  DROP TABLE dbo.UNITS
END

IF OBJECT_ID('dbo.COMMUNICATION_METHOD') IS NOT NULL
BEGIN
  DROP TABLE dbo.COMMUNICATION_METHOD
END

--案件マスタ
CREATE TABLE PROJECTS (
     id            int          NOT NULL identity
    ,project_id    nvarchar(20) NOT NULL
    ,name          nvarchar(40) NOT NULL
    ,product_id    int          NULL
    ,service_id    int          NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
    ,unique(project_id)
)

--案件機器構成マスタ
CREATE TABLE EQUIPMENT_CONFIGURATIONS (
   id            int           NOT NULL identity
  ,project_id    int           NOT NULL
  ,maker_name    nvarchar(20)  NOT NULL
  ,equip_name    nvarchar(20)  NOT NULL
  ,rating        decimal(4, 1) NULL
  ,unit_count    int           NULL
  ,irr_temp_flag bit           NOT NULL
  ,upd_date    datetime        NOT NULL
  ,primary key(id, project_id)
)

--メンバマスタ
CREATE TABLE MEMBERS (
     id             int          NOT NULL identity
    ,name           nvarchar(20) NOT NULL
    ,login_id       nvarchar(10) NOT NULL
    ,login_password nvarchar(10) NOT NULL
    ,enable_flag    bit          NOT NULL
    ,upd_date       datetime     NOT NULL
)

--カテゴリマスタ
CREATE TABLE CATEGORIES (
     id            int          NOT NULL identity
    ,name          nvarchar(20) NOT NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
)

--製品マスタ
CREATE TABLE PRODUCTS (
     id            int          NOT NULL identity
    ,name          nvarchar(20) NOT NULL
    ,[version]     nvarchar(15) NULL
    ,product_type  int          NOT NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
)

--メーカーマスタ
CREATE TABLE MAKERS (
   id          int          NOT NULL identity
  ,name        nvarchar(20) NOT NULL
  ,enable_flag bit          NOT NULL
  ,upd_date    datetime     NOT NULL
  ,primary key(id)
)

--機器マスタ
CREATE TABLE EQUIPMENTS (
   id          int           NOT NULL identity
  ,name        nvarchar(20)  NOT NULL
  ,rating      decimal(5, 1) NULL
  ,maker_id    int           NOT NULL
  ,enable_flag bit           NOT NULL
  ,upd_date    datetime      NOT NULL
  ,primary key(id)
)

--単位マスタ
CREATE TABLE UNITS (
     id            int          NOT NULL identity
    ,name          nvarchar(20) NOT NULL
    ,enable_flag   bit          NOT NULL
    ,upd_date      datetime     NOT NULL
    ,primary key(id)
)

--通信方式マスタ
CREATE TABLE COMMUNICATION_METHOD (
    id          int          NOT NULL identity
   ,name        nvarchar(40) NOT NULL
   ,enable_flag bit          NOT NULL
   ,upd_date    datetime     NOT NULL
   ,primary key(id)
)

--課題テーブル
CREATE TABLE ISSUES (
     id                    int           NOT NULL identity
    ,project_id            int           NOT NULL
    ,origination_date      datetime      NOT NULL
    ,category_id           int           NOT NULL
    ,product_id            int           NOT NULL
    ,issuing_member_id     int           NOT NULL
    ,responced_member_id   int           NULL
    ,checked_member_id     int           NULL
    ,deadline              datetime      NULL
    ,[status]              int           NOT NULL
    ,finished_date         datetime      NULL
    ,[comment]             nvarchar(max) NULL
    ,upd_date              datetime      NOT NULL
    ,primary key(id)
)
