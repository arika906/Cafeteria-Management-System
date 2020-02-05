CREATE TABLE [dbo].[Employees] (
    [EId]         INT           NOT NULL,
    [Name]        VARCHAR (MAX) NOT NULL,
    [Designation] VARCHAR (50)  NOT NULL,
    [Salary]      NUMERIC (18)  NOT NULL,
    [Experience]  INT           NOT NULL,
    [NId]         NVARCHAR (50) NOT NULL,
    [DateOfBirth] DATE          NOT NULL,
    [Address]     VARCHAR (MAX) NOT NULL,
    [Contact]     VARCHAR (50)  NOT NULL
);

