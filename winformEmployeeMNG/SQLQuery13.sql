  CREATE PROCEDURE GetAllBankAccountByEmployessId

AS
SELECT Id
      ,Code
      ,Name
      ,Branch
  FROM AccountBank
  WHERE IdPeople= @PeopleId
GO;