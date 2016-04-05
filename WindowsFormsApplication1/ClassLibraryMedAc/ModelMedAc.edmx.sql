
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/05/2016 12:16:52
-- Generated from EDMX file: C:\Users\Pedro Camponês\Documents\GitHubVisualStudio\MedAcProjetoV2\WindowsFormsApplication1\ClassLibraryMedAc\ModelMedAc.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyMedAc];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UtenteValores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ValoresSet] DROP CONSTRAINT [FK_UtenteValores];
GO
IF OBJECT_ID(N'[dbo].[FK_UtenteAlertas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlertasSet] DROP CONSTRAINT [FK_UtenteAlertas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UtenteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UtenteSet];
GO
IF OBJECT_ID(N'[dbo].[ValoresSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ValoresSet];
GO
IF OBJECT_ID(N'[dbo].[AlertasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlertasSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UtenteSet'
CREATE TABLE [dbo].[UtenteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Phone] int  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Birthdate] datetime  NOT NULL,
    [BI] int  NOT NULL,
    [SNS] int  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Alergies] nvarchar(max)  NOT NULL,
    [Height] int  NOT NULL,
    [NexOfKinContat] int  NOT NULL,
    [Weight] int  NOT NULL,
    [Age] int  NOT NULL,
    [Ative] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ValoresSet'
CREATE TABLE [dbo].[ValoresSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [DataOfRegist] datetime  NOT NULL,
    [Utente_Id] int  NOT NULL
);
GO

-- Creating table 'AlertasSet'
CREATE TABLE [dbo].[AlertasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Read] nvarchar(max)  NOT NULL,
    [Parametro] nvarchar(max)  NOT NULL,
    [Utente_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UtenteSet'
ALTER TABLE [dbo].[UtenteSet]
ADD CONSTRAINT [PK_UtenteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ValoresSet'
ALTER TABLE [dbo].[ValoresSet]
ADD CONSTRAINT [PK_ValoresSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlertasSet'
ALTER TABLE [dbo].[AlertasSet]
ADD CONSTRAINT [PK_AlertasSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Utente_Id] in table 'ValoresSet'
ALTER TABLE [dbo].[ValoresSet]
ADD CONSTRAINT [FK_UtenteValores]
    FOREIGN KEY ([Utente_Id])
    REFERENCES [dbo].[UtenteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtenteValores'
CREATE INDEX [IX_FK_UtenteValores]
ON [dbo].[ValoresSet]
    ([Utente_Id]);
GO

-- Creating foreign key on [Utente_Id] in table 'AlertasSet'
ALTER TABLE [dbo].[AlertasSet]
ADD CONSTRAINT [FK_UtenteAlertas]
    FOREIGN KEY ([Utente_Id])
    REFERENCES [dbo].[UtenteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UtenteAlertas'
CREATE INDEX [IX_FK_UtenteAlertas]
ON [dbo].[AlertasSet]
    ([Utente_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------