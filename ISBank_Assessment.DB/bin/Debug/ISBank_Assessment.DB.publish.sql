﻿/*
Deployment script for ISBank_Assessment.DB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ISBank_Assessment.DB"
:setvar DefaultFilePrefix "ISBank_Assessment.DB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Accounts]...';


GO
CREATE TABLE [dbo].[Accounts] (
    [code]                INT          IDENTITY (1, 1) NOT NULL,
    [person_code]         INT          NOT NULL,
    [account_number]      VARCHAR (50) NOT NULL,
    [outstanding_balance] MONEY        NOT NULL,
    [StatusId]            INT          NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED ([code] ASC)
);


GO
PRINT N'Creating [dbo].[Accounts].[IX_Account_num]...';


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Account_num]
    ON [dbo].[Accounts]([account_number] ASC);


GO
PRINT N'Creating [dbo].[Persons]...';


GO
CREATE TABLE [dbo].[Persons] (
    [code]      INT          IDENTITY (1, 1) NOT NULL,
    [UserId]    INT          NULL,
    [name]      VARCHAR (50) NULL,
    [surname]   VARCHAR (50) NULL,
    [id_number] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([code] ASC)
);


GO
PRINT N'Creating [dbo].[Persons].[IX_Person_id]...';


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Person_id]
    ON [dbo].[Persons]([id_number] ASC);


GO
PRINT N'Creating [dbo].[Status]...';


GO
CREATE TABLE [dbo].[Status] (
    [StatusId]    INT          IDENTITY (1, 1) NOT NULL,
    [StatusTypes] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([StatusId] ASC)
);


GO
PRINT N'Creating [dbo].[Transactions]...';


GO
CREATE TABLE [dbo].[Transactions] (
    [code]             INT           IDENTITY (1, 1) NOT NULL,
    [account_code]     INT           NOT NULL,
    [transaction_date] DATETIME      NOT NULL,
    [capture_date]     DATETIME      NOT NULL,
    [amount]           MONEY         NOT NULL,
    [description]      VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED ([code] ASC)
);


GO
PRINT N'Creating [dbo].[Users]...';


GO
CREATE TABLE [dbo].[Users] (
    [UserId]              INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [UserName]            VARCHAR (255)  NOT NULL,
    [FirstName]           VARCHAR (50)   NOT NULL,
    [LastName]            VARCHAR (50)   NOT NULL,
    [EmailAddress]        VARCHAR (100)  NULL,
    [DateCreated]         DATETIME2 (7)  NOT NULL,
    [LastLogin]           DATETIME2 (7)  NULL,
    [Password]            VARCHAR (8000) NOT NULL,
    [LastUpdatedBy]       VARCHAR (50)   NULL,
    [LoginCount]          INT            NULL,
    [ForceChangePassword] BIT            NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);


GO
PRINT N'Creating unnamed constraint on [dbo].[Accounts]...';


GO
ALTER TABLE [dbo].[Accounts]
    ADD FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId]);


GO
PRINT N'Creating [dbo].[FK_Account_Person]...';


GO
ALTER TABLE [dbo].[Accounts]
    ADD CONSTRAINT [FK_Account_Person] FOREIGN KEY ([person_code]) REFERENCES [dbo].[Persons] ([code]);


GO
PRINT N'Creating unnamed constraint on [dbo].[Persons]...';


GO
ALTER TABLE [dbo].[Persons]
    ADD FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]);


GO
PRINT N'Creating [dbo].[FK_Transaction_Account]...';


GO
ALTER TABLE [dbo].[Transactions]
    ADD CONSTRAINT [FK_Transaction_Account] FOREIGN KEY ([account_code]) REFERENCES [dbo].[Accounts] ([code]);


GO
PRINT N'Creating [dbo].[stpGetAllTransactions]...';


GO
-- =============================================
--Store procedure name is --> stpGetAllTransactions
CREATE PROCEDURE stpGetAllTransactions
-- Add the parameters for the stored procedure here
    @AccountCode nvarchar(30)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Select statements for procedure here
    Select * from Transactions
	where account_code like '%'+@AccountCode+'%'
END
GO
PRINT N'Creating [dbo].[stpUpdateAccountBalance]...';


GO
create PROCEDURE stpUpdateAccountBalance (
    @AccountNumber1 varchar(50) = null,
    @AccountNumber2 varchar(50) = null,
    @amount money = null

) AS 
BEGIN
    SET NOCOUNT ON;

   UPDATE Accounts
        SET outstanding_balance = COALESCE(outstanding_balance, 0) - COALESCE(@amount, 0)
        WHERE account_number = @AccountNumber1;

    UPDATE Accounts
        SET outstanding_balance = COALESCE(outstanding_balance, 0) + COALESCE(@amount, 0)
        WHERE account_number = @AccountNumber2;
END;
GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
