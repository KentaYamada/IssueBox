/*
 * 課題一覧取得
 */
IF OBJECT_ID('dbo.FindIssuesBy') IS NOT NULL
BEGIN
  DROP PROCEDURE dbo.FindIssuesBy
END

CREATE PROCEDURE FindIssuesBy (
   @ProjectID int
  ,@ProductID int
  ,@DeadlineFrom datetime
  ,@DeadlineTo datetime
  ,@Status int
) AS
BEGIN
  DECLARE @Enable bit
  SET @Enable = CONVERT(bit, 'TRUE')

  SELECT
     i.id                  AS ID
    ,i.origination_date    AS OriginationDate
    ,i.project_id          AS ProjectID
    ,prj.project_id        AS DispProjectID
    ,prj.name              AS ProjectName
    ,i.category_id         AS CategoryID
    ,c.name                AS CategoryName
    ,i.product_id          AS ProductID
    ,prd.name              AS ProductName
    ,i.issuing_member_id   AS IssuingMemberID
    ,i.responced_member_id AS ResponcedMemberID
    ,m.name                AS ResponcedMemberName
    ,i.checked_member_id   AS CheckedMemberID
    ,i.deadline            AS Deadline
    ,i.[status]            AS [Status]
    ,CASE i.[status]
       WHEN 1 THEN '起票'
       WHEN 2 THEN '対応中'
       WHEN 3 THEN '確認中'
       WHEN 4 THEN '完了'
       ELSE ''
     END                   AS DispStatus
    ,i.finished_date       AS FinishedDate
    ,i.comment             AS Comment
  FROM ISSUES AS i
  LEFT JOIN PROJECTS AS prj
    ON i.project_id = prj.id
   AND prj.enable_flag = @Enable
  LEFT JOIN PRODUCTS AS prd
    ON i.product_id = prd.id
   AND prd.enable_flag = @Enable
  LEFT JOIN MEMBERS AS m
    ON i.responced_member_id = m.id
   AND m.enable_flag = @Enable
  LEFT JOIN CATEGORIES AS c
    ON i.category_id = c.id
   AND c.enable_flag = @Enable
  WHERE (i.project_id = @ProjectID OR @ProjectID IS NULL)
    --AND (i.product_id = @ProductID OR @ProductID IS NULL)
    AND (i.deadline BETWEEN @DeadlineFrom AND @DeadlineTo
         OR @DeadLineFrom IS NULL
         OR @DeadLineTo IS NULL)
    --AND (i.[status] = @Status OR @Status = 0)
  ORDER BY i.id

END