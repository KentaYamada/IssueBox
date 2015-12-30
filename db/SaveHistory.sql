/*
 * 対応履歴保存
 */
IF OBJECT_ID('dbo.SaveHistory') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveHistory
END

GO
CREATE PROCEDURE SaveHistory (
     @PostDate       datetime
    ,@PostMemberName nvarchar(20)
    ,@IssueID        int
    ,@Comment        nvarchar(400)
) AS
BEGIN TRY
  BEGIN TRAN

      INSERT INTO HISTORIES (
          post_date
         ,issue_id
         ,post_member_name
         ,comment
         ,upd_date
      )
      VALUES (
          @PostDate
         ,@IssueID
         ,@PostMemberName
         ,@Comment
         ,GETDATE()
     )

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK
  SELECT ERROR_MESSAGE()
END CATCH
