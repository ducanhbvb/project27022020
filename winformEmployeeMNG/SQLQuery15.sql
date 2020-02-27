USE [EmployeeMNG]
GO

/****** Object:  StoredProcedure [dbo].[GetAllEmployee]    Script Date: 2/24/2020 3:57:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetAllEmployee]   
AS   
BEGIN
    SELECT	 
			EmployeeId,
			Code,
			Name, 
			Gender, 
			Email, 
			Addess,
			DateOfBrith,
			CMND,
			IssuedDate,
			IssuedAddess,
			Basicsalary 
	 FROM Employee
END

GO;
CREATE PROCEDURE [dbo].[GetAllBankAccountByEmployessId]   
@EmployeeId int
AS   
BEGIN
    SELECT Id
      ,Code
      ,Name
      ,Branch
      ,Note
  FROM BankAccount
  WHERE EmployeeId = @EmployeeId
END

EXEC GetAllBankAccountByEmployessId 1
GO;

CREATE PROCEDURE [dbo].[GetAllEmployeeByName]
@Name nvarchar(255)
AS   
BEGIN
    SELECT 
			EmployeeId,
			Code,
			Name, 
			Gender, 
			Email, 
			Addess,
			DateOfBrith,
			CMND,
			IssuedDate,
			IssuedAddess,
			Basicsalary 
  FROM	Employee
  WHERE		LOWER(Name) LIKE N'%'+ @Name +'%' 
END
GO;

ALTER PROCEDURE [dbo].[GetAllEmployeeByNameSalary]
@Name nvarchar(255),
@Salary decimal(18, 0)
AS   
BEGIN
    SELECT 
			EmployeeId,
			Code,
			Name, 
			Gender, 
			Email, 
			Addess,
			DateOfBrith,
			CMND,
			IssuedDate,
			IssuedAddess,
			Basicsalary 
  FROM	Employee
  WHERE		(ISNULL(@Name, '') = '' OR LOWER(Name) LIKE N'%' + @Name + '%')
		AND	(ISNULL(@Salary, 0) = 0 OR BasicSalary = @Salary)
  
		--(LOWER(Name) LIKE N'%'+ @Name +'%' And Basicsalary = @Salary)
		--or( @Name='' And Basicsalary = @Salary)
		--or(LOWER(Name) LIKE N'%'+ @Name +'%' And @Salary = 0)
		--or(@Name ='' And @Salary = 0)
END
