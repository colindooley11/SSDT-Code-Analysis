CREATE PROCEDURE ProcContainingSelectAll
AS 
BEGIN
    RETURN SELECT * FROM dbo.Table1 -- This select all is not allowed. 
END



