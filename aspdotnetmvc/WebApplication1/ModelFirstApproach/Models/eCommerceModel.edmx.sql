
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/19/2023 16:40:18
-- Generated from EDMX file: D:\kaushalya\consultancy\inube\2023\apr2023\aspdotnetmvc\WebApplication1\ModelFirstApproach\Models\eCommerceModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [inubeapr2023];
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

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [dept] nvarchar(max)  NOT NULL,
    [desg] nvarchar(max)  NOT NULL,
    [salary] int  NOT NULL
);
GO

-- Creating table 'addresses'
CREATE TABLE [dbo].[addresses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [address1] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL,
    [pincode] int  NOT NULL,
    [EmployeeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'addresses'
ALTER TABLE [dbo].[addresses]
ADD CONSTRAINT [PK_addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmployeeId] in table 'addresses'
ALTER TABLE [dbo].[addresses]
ADD CONSTRAINT [FK_Employeeaddress]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employeeaddress'
CREATE INDEX [IX_FK_Employeeaddress]
ON [dbo].[addresses]
    ([EmployeeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------