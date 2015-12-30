/*
 * 対応履歴一覧取得
 * @param IssueID Integer タスクID
 * @return 検索条件に合致した対応履歴
 */

IF OBJECT_ID('dbo.FindHistoriesBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindHistoriesBy
END

GO
CREATE PROCEDURE FindHistoriesBy (
   @IssueID int
)
AS
BEGIN

  SELECT
    h.post_date        AS PostDate
   ,h.post_member_name AS PostMemberName
   ,h.issue_id         AS IssueID
   ,h.comment          AS Comment
  FROM HISTORIES AS h
  ORDER BY h.post_date DESC

END