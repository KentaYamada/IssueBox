/*
 * Bit^»θ
 * param:@condition String υπ
 * return bit^ΙΟ·:True:1 False:0 »κΘO:null
 */

IF OBJECT_ID('dbo.IsBit') IS NOT NULL
BEGIN
  DROP FUNCTION dbo.IsBit
END

GO

CREATE FUNCTION IsBit (
  @condition nvarchar(5)
) RETURNS bit
AS
BEGIN

  DECLARE @t AS TABLE (id nvarchar(10), value bit)
  INSERT INTO @t (id, value) VALUES ('true', 1)
                                   ,('false', 0)
                                   ,('all', null)
  DECLARE @b bit
  SET @b = (SELECT t.value FROM @t AS t WHERE t.id = LOWER(@condition))
  
  RETURN @b
END