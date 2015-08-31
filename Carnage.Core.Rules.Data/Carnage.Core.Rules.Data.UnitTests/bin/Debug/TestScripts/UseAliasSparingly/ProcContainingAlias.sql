CREATE PROCEDURE ProcContainingBadAlias
AS 
BEGIN
    RETURN SELECT * FROM dbo.Table1 AS tb -- This Alias is not recommended.
END

GO

CREATE PROCEDURE ProcContainingOkAlias
AS 
BEGIN
    RETURN 
        SELECT c1 FROM 
            dbo.Table1 AS tb1 
        JOIN dbo.Table2 ON tb1.c1 = Table2.c1
END
