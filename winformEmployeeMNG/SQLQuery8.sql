/****** Script for SelectTopNRows command from SSMS  ******/

  CREATE PROCEDURE GetAllBank

AS
SELECT Id
      ,Code
      ,Name
      ,Branch
      ,IdPeople
  FROM AccountBank
GO;

  CREATE PROCEDURE GetByIdBank

AS
SELECT Id
      ,Code
      ,Name
      ,Branch
  FROM AccountBank
  WHERE IdPeople= @PeopleId
GO;
