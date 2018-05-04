
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/04/2018 22:09:56
-- Generated from EDMX file: C:\Users\User\source\repos\kip\kip\kip.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [kip];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Equipment_EquipmentTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Equipment] DROP CONSTRAINT [FK_Equipment_EquipmentTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Equipment_Manufacturers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Equipment] DROP CONSTRAINT [FK_Equipment_Manufacturers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Equipment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipment];
GO
IF OBJECT_ID(N'[dbo].[EquipmentTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentTypes];
GO
IF OBJECT_ID(N'[dbo].[Manufacturers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Manufacturers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EquipmentSet'
CREATE TABLE [dbo].[EquipmentSet] (
    [id] uniqueidentifier  NOT NULL,
    [number] nchar(12)  NOT NULL,
    [repairDate] datetime  NOT NULL,
    [serviceDate] datetime  NOT NULL,
    [nextVerificationDate] datetime  NOT NULL,
    [termDate] nvarchar(max)  NULL,
    [isWorking] bit  NOT NULL,
    [isFree] bit  NOT NULL,
    [EquipmentType_id] int  NOT NULL,
    [MVPS_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'EquipmentTypeSet'
CREATE TABLE [dbo].[EquipmentTypeSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NULL,
    [SystemType_Id] int  NOT NULL,
    [Manufacturer_id] int  NOT NULL
);
GO

-- Creating table 'ManufacturerSet'
CREATE TABLE [dbo].[ManufacturerSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(50)  NULL,
    [address] nvarchar(max)  NULL,
    [phone] nchar(16)  NULL,
    [email] nchar(50)  NULL
);
GO

-- Creating table 'SystemTypeSet'
CREATE TABLE [dbo].[SystemTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MVPSRoleSet'
CREATE TABLE [dbo].[MVPSRoleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MVPSTypeSet'
CREATE TABLE [dbo].[MVPSTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MVPSSet'
CREATE TABLE [dbo].[MVPSSet] (
    [Id] uniqueidentifier  NOT NULL,
    [number] nvarchar(max)  NOT NULL,
    [series] nvarchar(max)  NOT NULL,
    [MVPSRole_Id] int  NOT NULL,
    [MVPSType_Id] int  NOT NULL,
    [EquipmentRule_Id] int  NOT NULL
);
GO

-- Creating table 'EquipmentRuleSet'
CREATE TABLE [dbo].[EquipmentRuleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MVPSRole_Id] int  NOT NULL,
    [MVPSType_Id] int  NOT NULL
);
GO

-- Creating table 'EquipmentRuleEquipmentType'
CREATE TABLE [dbo].[EquipmentRuleEquipmentType] (
    [EquipmentRule_Id] int  NOT NULL,
    [EquipmentType_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'EquipmentSet'
ALTER TABLE [dbo].[EquipmentSet]
ADD CONSTRAINT [PK_EquipmentSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'EquipmentTypeSet'
ALTER TABLE [dbo].[EquipmentTypeSet]
ADD CONSTRAINT [PK_EquipmentTypeSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'ManufacturerSet'
ALTER TABLE [dbo].[ManufacturerSet]
ADD CONSTRAINT [PK_ManufacturerSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'SystemTypeSet'
ALTER TABLE [dbo].[SystemTypeSet]
ADD CONSTRAINT [PK_SystemTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MVPSRoleSet'
ALTER TABLE [dbo].[MVPSRoleSet]
ADD CONSTRAINT [PK_MVPSRoleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MVPSTypeSet'
ALTER TABLE [dbo].[MVPSTypeSet]
ADD CONSTRAINT [PK_MVPSTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MVPSSet'
ALTER TABLE [dbo].[MVPSSet]
ADD CONSTRAINT [PK_MVPSSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EquipmentRuleSet'
ALTER TABLE [dbo].[EquipmentRuleSet]
ADD CONSTRAINT [PK_EquipmentRuleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [EquipmentRule_Id], [EquipmentType_id] in table 'EquipmentRuleEquipmentType'
ALTER TABLE [dbo].[EquipmentRuleEquipmentType]
ADD CONSTRAINT [PK_EquipmentRuleEquipmentType]
    PRIMARY KEY CLUSTERED ([EquipmentRule_Id], [EquipmentType_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SystemType_Id] in table 'EquipmentTypeSet'
ALTER TABLE [dbo].[EquipmentTypeSet]
ADD CONSTRAINT [FK_SystemTypeEquipmentType]
    FOREIGN KEY ([SystemType_Id])
    REFERENCES [dbo].[SystemTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SystemTypeEquipmentType'
CREATE INDEX [IX_FK_SystemTypeEquipmentType]
ON [dbo].[EquipmentTypeSet]
    ([SystemType_Id]);
GO

-- Creating foreign key on [Manufacturer_id] in table 'EquipmentTypeSet'
ALTER TABLE [dbo].[EquipmentTypeSet]
ADD CONSTRAINT [FK_ManufacturerEquipmentType]
    FOREIGN KEY ([Manufacturer_id])
    REFERENCES [dbo].[ManufacturerSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerEquipmentType'
CREATE INDEX [IX_FK_ManufacturerEquipmentType]
ON [dbo].[EquipmentTypeSet]
    ([Manufacturer_id]);
GO

-- Creating foreign key on [MVPSRole_Id] in table 'MVPSSet'
ALTER TABLE [dbo].[MVPSSet]
ADD CONSTRAINT [FK_MVPSMVPSRole]
    FOREIGN KEY ([MVPSRole_Id])
    REFERENCES [dbo].[MVPSRoleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSMVPSRole'
CREATE INDEX [IX_FK_MVPSMVPSRole]
ON [dbo].[MVPSSet]
    ([MVPSRole_Id]);
GO

-- Creating foreign key on [MVPSType_Id] in table 'MVPSSet'
ALTER TABLE [dbo].[MVPSSet]
ADD CONSTRAINT [FK_MVPSTypeMVPS]
    FOREIGN KEY ([MVPSType_Id])
    REFERENCES [dbo].[MVPSTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSTypeMVPS'
CREATE INDEX [IX_FK_MVPSTypeMVPS]
ON [dbo].[MVPSSet]
    ([MVPSType_Id]);
GO

-- Creating foreign key on [MVPSRole_Id] in table 'EquipmentRuleSet'
ALTER TABLE [dbo].[EquipmentRuleSet]
ADD CONSTRAINT [FK_MVPSRoleEquipmentRule]
    FOREIGN KEY ([MVPSRole_Id])
    REFERENCES [dbo].[MVPSRoleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSRoleEquipmentRule'
CREATE INDEX [IX_FK_MVPSRoleEquipmentRule]
ON [dbo].[EquipmentRuleSet]
    ([MVPSRole_Id]);
GO

-- Creating foreign key on [MVPSType_Id] in table 'EquipmentRuleSet'
ALTER TABLE [dbo].[EquipmentRuleSet]
ADD CONSTRAINT [FK_MVPSTypeEquipmentRule]
    FOREIGN KEY ([MVPSType_Id])
    REFERENCES [dbo].[MVPSTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSTypeEquipmentRule'
CREATE INDEX [IX_FK_MVPSTypeEquipmentRule]
ON [dbo].[EquipmentRuleSet]
    ([MVPSType_Id]);
GO

-- Creating foreign key on [EquipmentRule_Id] in table 'EquipmentRuleEquipmentType'
ALTER TABLE [dbo].[EquipmentRuleEquipmentType]
ADD CONSTRAINT [FK_EquipmentRuleEquipmentType_EquipmentRule]
    FOREIGN KEY ([EquipmentRule_Id])
    REFERENCES [dbo].[EquipmentRuleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EquipmentType_id] in table 'EquipmentRuleEquipmentType'
ALTER TABLE [dbo].[EquipmentRuleEquipmentType]
ADD CONSTRAINT [FK_EquipmentRuleEquipmentType_EquipmentType]
    FOREIGN KEY ([EquipmentType_id])
    REFERENCES [dbo].[EquipmentTypeSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentRuleEquipmentType_EquipmentType'
CREATE INDEX [IX_FK_EquipmentRuleEquipmentType_EquipmentType]
ON [dbo].[EquipmentRuleEquipmentType]
    ([EquipmentType_id]);
GO

-- Creating foreign key on [EquipmentType_id] in table 'EquipmentSet'
ALTER TABLE [dbo].[EquipmentSet]
ADD CONSTRAINT [FK_EquipmentTypeEquipment]
    FOREIGN KEY ([EquipmentType_id])
    REFERENCES [dbo].[EquipmentTypeSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentTypeEquipment'
CREATE INDEX [IX_FK_EquipmentTypeEquipment]
ON [dbo].[EquipmentSet]
    ([EquipmentType_id]);
GO

-- Creating foreign key on [EquipmentRule_Id] in table 'MVPSSet'
ALTER TABLE [dbo].[MVPSSet]
ADD CONSTRAINT [FK_EquipmentRuleMVPS]
    FOREIGN KEY ([EquipmentRule_Id])
    REFERENCES [dbo].[EquipmentRuleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentRuleMVPS'
CREATE INDEX [IX_FK_EquipmentRuleMVPS]
ON [dbo].[MVPSSet]
    ([EquipmentRule_Id]);
GO

-- Creating foreign key on [MVPS_Id] in table 'EquipmentSet'
ALTER TABLE [dbo].[EquipmentSet]
ADD CONSTRAINT [FK_MVPSEquipment]
    FOREIGN KEY ([MVPS_Id])
    REFERENCES [dbo].[MVPSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSEquipment'
CREATE INDEX [IX_FK_MVPSEquipment]
ON [dbo].[EquipmentSet]
    ([MVPS_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------