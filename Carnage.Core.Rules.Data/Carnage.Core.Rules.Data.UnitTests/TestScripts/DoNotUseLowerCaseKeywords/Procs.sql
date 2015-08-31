CREATE PROCEDURE ProcContainingLowerCaseSelect
AS 
BEGIN
    RETURN select * FROM dbo.Table1 -- This select is lower cased and not allowed. 
END

GO
CREATE proc ProcContainingLowerCaseProc
AS 
BEGIN
    RETURN select * FROM dbo.Table1 -- This select is lower cased and not allowed. 
END