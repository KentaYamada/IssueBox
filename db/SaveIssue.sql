/*
 * 課題情報保存
 */

IF OBJECT_ID('dbo.SaveIssue') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.SaveIssue
END

GO
CREATE PROCEDURE SaveIssue (
   @ID                int
  ,@ProjectID         int
  ,@OriginationDate   datetime
  ,@CategoryID        int
  ,@ProductID         int
  ,@IssuingMemberID   int
  ,@ResponcedMemberID int
  ,@CheckedMemberID   int
  ,@Deadline          datetime
  ,@FinishedDate      datetime
  ,@Status            int
  ,@Comment           nvarchar(10)
) AS
BEGIN TRY
  BEGIN TRAN
    
    UPDATE ISSUES SET
       project_id = @ProjectID
      ,origination_date = @OriginationDate
      ,category_id = @CategoryID
      ,product_id = @ProductID
      ,issuing_member_id = @IssuingMemberID
      ,responced_member_id = @ResponcedMemberID
      ,checked_member_id = @CheckedMemberID
      ,deadline = @Deadline
      ,[status] = @Status
      ,finished_date = @FinishedDate
      ,[comment] = @Comment
      ,upd_date =GETDATE()
    WHERE id = @ID
    
    IF @@ROWCOUNT < 1
    BEGIN
      INSERT INTO ISSUES (
         project_id
        ,origination_date
        ,category_id
        ,product_id
        ,issuing_member_id
        ,responced_member_id
        ,checked_member_id
        ,deadline
        ,[status]
        ,finished_date
        ,[comment]
        ,upd_date
      )
      VALUES (
        @ProjectID
       ,@OriginationDate
       ,@CategoryID
       ,@ProductID
       ,@IssuingMemberID
       ,@ResponcedMemberID
       ,@CheckedMemberID
       ,@Deadline
       ,@Status
       ,@FinishedDate
       ,@Comment
       ,GETDATE()
      )
    END

  COMMIT TRAN
END TRY
BEGIN CATCH
  ROLLBACK TRAN
  SELECT ERROR_MESSAGE()
END CATCH
