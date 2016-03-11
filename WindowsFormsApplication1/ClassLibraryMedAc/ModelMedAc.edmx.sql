
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2016 13:30:59
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [Gender] bit  NOT NULL,
    [Alergies] nvarchar(max)  NOT NULL,
    [Height] int  NOT NULL,
    [NexOfKinContat] int  NOT NULL,
    [Weight] int  NOT NULL,
    [Age] int  NOT NULL
);
GO

-- Creating table 'ValoresSet'
CREATE TABLE [dbo].[ValoresSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BloodPressure] nvarchar(max)  NOT NULL,
    [HeartRate] nvarchar(max)  NOT NULL,
    [OxygenSaturation] nvarchar(max)  NOT NULL,
    [Utente_Id] int  NOT NULL,
    [Alertas_Id] int  NOT NULL
);
GO

-- Creating table 'AlertasSet'
CREATE TABLE [dbo].[AlertasSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL
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

-- Creating foreign key on [Alertas_Id] in table 'ValoresSet'
ALTER TABLE [dbo].[ValoresSet]
ADD CONSTRAINT [FK_ValoresAlertas]
    FOREIGN KEY ([Alertas_Id])
    REFERENCES [dbo].[AlertasSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ValoresAlertas'
CREATE INDEX [IX_FK_ValoresAlertas]
ON [dbo].[ValoresSet]
    ([Alertas_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------