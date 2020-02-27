

CREATE PROCEDURE GetAllPeople
AS
SELECT Id
      ,Name
      ,Date
      ,Avatar
      ,Salary
  FROM People
GO;