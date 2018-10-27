
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/12/2018 10:26:47
-- Generated from EDMX file: C:\Users\uadmin\Desktop\NRE VS\NRE_Repo\Main\Main\NRE_Portal_DBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NRE_Portal_DB];
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

-- Creating table 'PrivateInstallationTestSet'
CREATE TABLE [dbo].[PrivateInstallationTestSet] (
    [IdPrivateInstallationTest] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [ZIP] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPrivateInstallationTest] in table 'PrivateInstallationTestSet'
ALTER TABLE [dbo].[PrivateInstallationTestSet]
ADD CONSTRAINT [PK_PrivateInstallationTestSet]
    PRIMARY KEY CLUSTERED ([IdPrivateInstallationTest] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------