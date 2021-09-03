EXECUTE tSQLt.NewTestClass 'Assessment';
GO

CREATE OR ALTER PROCEDURE Assessment.[Test GetHistoryItem] AS

/*Assemble*/
DECLARE @Return INT;

/*create a table to store the expected result-set*/
SELECT TOP (0) [Id]
      ,[CalculationHandler]
      ,[GivenValue]
      ,[CalculationTime]
      ,[LastStatus]
      ,[CreatedDate]
   INTO Assessment.Expected FROM [ABNAmro_Assessment].[history].[calculations];

/*create a table to store the actual result-set*/
SELECT TOP (0) [Id]
      ,[CalculationHandler]
      ,[GivenValue]
      ,[CalculationTime]
      ,[LastStatus]
      ,[CreatedDate]
   INTO Assessment.Actual FROM [ABNAmro_Assessment].[history].[calculations];


EXECUTE tSQLt.FakeTable
@TableName = N'history.calculation';

INSERT INTO history.calculation (CalculationHandler, GivenValue, CalculationTime, LastStatus) VALUES
( N'ab2bd817-98cd-4cf3-a80a-53ea0cd9c100', 10, 25),
( N'ab2bd817-98cd-4cf3-a80a-53ea0cd9c100', 9, 30);

INSERT INTO history.Expected (CalculationHandler, GivenValue, CalculationTime, LastStatus) VALUES
( N'ab2bd817-98cd-4cf3-a80a-53ea0cd9c100', 10, 25),

/*Act*/
INSERT INTO history.Actual (CalculationHandler, GivenValue, CalculationTime, LastStatus)
EXECUTE @Return = dbo.GetHistory @ID = 1;

/*Assert*/
EXECUTE tsqlt.AssertEquals
@Expected = 0,
@Actual = @Return,
@Message = N'dbo.GetHistory is returning an incorrect value';

EXECUTE tSQLt.AssertEqualsTable
@Expected = N'history.Expected',
@Actual = N'history.Actual',
@FailMsg = N'dbo.GetHistory is returning an incorrect resultset';

GO