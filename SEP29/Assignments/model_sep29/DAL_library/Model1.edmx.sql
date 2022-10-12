
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 17:59:04
-- Generated from EDMX file: D:\C#\model_sep29\DAL_library\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LoanDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'borrowers'
CREATE TABLE [dbo].[borrowers] (
    [b_id] int IDENTITY(1,1) NOT NULL,
    [b_name] nvarchar(max)  NOT NULL,
    [city] nvarchar(max)  NOT NULL,
    [state] nvarchar(max)  NOT NULL,
    [country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'loans'
CREATE TABLE [dbo].[loans] (
    [loanid] int IDENTITY(1,1) NOT NULL,
    [loantype] nvarchar(max)  NOT NULL,
    [Amt] int  NOT NULL,
    [duration] int  NOT NULL,
    [roi] int  NOT NULL,
    [borrower_b_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [b_id] in table 'borrowers'
ALTER TABLE [dbo].[borrowers]
ADD CONSTRAINT [PK_borrowers]
    PRIMARY KEY CLUSTERED ([b_id] ASC);
GO

-- Creating primary key on [loanid] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [PK_loans]
    PRIMARY KEY CLUSTERED ([loanid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [borrower_b_id] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [FK_borrowerloan]
    FOREIGN KEY ([borrower_b_id])
    REFERENCES [dbo].[borrowers]
        ([b_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_borrowerloan'
CREATE INDEX [IX_FK_borrowerloan]
ON [dbo].[loans]
    ([borrower_b_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------