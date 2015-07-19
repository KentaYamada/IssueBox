/*
 * ログイン認証
 * @param LoginID String ログインID
 * @param LoginPassword String パスワード
 * @return ログイン結果
 */

IF OBJECT_ID('dbo.LoginAuthorication') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.LoginAuthorication
END

GO
CREATE PROCEDURE LoginAuthorication (
   @LoginID nvarchar(10)
  ,@LoginPassword nvarchar(10)
)
AS
BEGIN
  DECLARE @EnableFlag bit = CONVERT(bit, 'TRUE')
  SELECT
     m.name
  FROM MEMBERS AS m
  WHERE m.enable_flag = @EnableFlag
    AND m.login_id = @LoginID
    AND m.login_password = @LoginPassword
END