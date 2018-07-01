
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2018 14:38:32
-- Generated from EDMX file: C:\Users\urkaNote\source\repos\kip\kip\kip.edmx
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

IF OBJECT_ID(N'[dbo].[FK_EquipmentEquipmentEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentEventSet] DROP CONSTRAINT [FK_EquipmentEquipmentEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentReplacingLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReplacingLogSet] DROP CONSTRAINT [FK_EquipmentReplacingLog];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentReplacingLog1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReplacingLogSet] DROP CONSTRAINT [FK_EquipmentReplacingLog1];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentRuleEquipmentType_EquipmentRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentRuleEquipmentType] DROP CONSTRAINT [FK_EquipmentRuleEquipmentType_EquipmentRule];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentRuleEquipmentType_EquipmentType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentRuleEquipmentType] DROP CONSTRAINT [FK_EquipmentRuleEquipmentType_EquipmentType];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentRuleMVPS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSSet] DROP CONSTRAINT [FK_EquipmentRuleMVPS];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentServiceLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceLogSet] DROP CONSTRAINT [FK_EquipmentServiceLog];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipmentTypeEquipment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentSet] DROP CONSTRAINT [FK_EquipmentTypeEquipment];
GO
IF OBJECT_ID(N'[dbo].[FK_ManufacturerEquipmentType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentTypeSet] DROP CONSTRAINT [FK_ManufacturerEquipmentType];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSEquipment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentSet] DROP CONSTRAINT [FK_MVPSEquipment];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSMVPSRole]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSSet] DROP CONSTRAINT [FK_MVPSMVPSRole];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSReplacingLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReplacingLogSet] DROP CONSTRAINT [FK_MVPSReplacingLog];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSRoleEquipmentRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentRuleSet] DROP CONSTRAINT [FK_MVPSRoleEquipmentRule];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSShedule_MVPS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSShedule] DROP CONSTRAINT [FK_MVPSShedule_MVPS];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSShedule_Shedule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSShedule] DROP CONSTRAINT [FK_MVPSShedule_Shedule];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSShedule1_MVPS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSShedule1] DROP CONSTRAINT [FK_MVPSShedule1_MVPS];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSShedule1_Shedule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSShedule1] DROP CONSTRAINT [FK_MVPSShedule1_Shedule];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSTypeEquipmentRule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentRuleSet] DROP CONSTRAINT [FK_MVPSTypeEquipmentRule];
GO
IF OBJECT_ID(N'[dbo].[FK_MVPSTypeMVPS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MVPSSet] DROP CONSTRAINT [FK_MVPSTypeMVPS];
GO
IF OBJECT_ID(N'[dbo].[FK_PositionWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkerSet] DROP CONSTRAINT [FK_PositionWorker];
GO
IF OBJECT_ID(N'[dbo].[FK_SystemTypeEquipmentType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipmentTypeSet] DROP CONSTRAINT [FK_SystemTypeEquipmentType];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerReplacingLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReplacingLogSet] DROP CONSTRAINT [FK_WorkerReplacingLog];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkerServiceLog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceLogSet] DROP CONSTRAINT [FK_WorkerServiceLog];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EquipmentEventSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentEventSet];
GO
IF OBJECT_ID(N'[dbo].[EquipmentRuleEquipmentType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentRuleEquipmentType];
GO
IF OBJECT_ID(N'[dbo].[EquipmentRuleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentRuleSet];
GO
IF OBJECT_ID(N'[dbo].[EquipmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentSet];
GO
IF OBJECT_ID(N'[dbo].[EquipmentTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentTypeSet];
GO
IF OBJECT_ID(N'[dbo].[ManufacturerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ManufacturerSet];
GO
IF OBJECT_ID(N'[dbo].[MVPSRoleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MVPSRoleSet];
GO
IF OBJECT_ID(N'[dbo].[MVPSSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MVPSSet];
GO
IF OBJECT_ID(N'[dbo].[MVPSShedule]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MVPSShedule];
GO
IF OBJECT_ID(N'[dbo].[MVPSShedule1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MVPSShedule1];
GO
IF OBJECT_ID(N'[dbo].[MVPSTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MVPSTypeSet];
GO
IF OBJECT_ID(N'[dbo].[PositionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PositionSet];
GO
IF OBJECT_ID(N'[dbo].[ReplacingLogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReplacingLogSet];
GO
IF OBJECT_ID(N'[dbo].[ServiceLogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceLogSet];
GO
IF OBJECT_ID(N'[dbo].[SheduleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SheduleSet];
GO
IF OBJECT_ID(N'[dbo].[SystemTypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemTypeSet];
GO
IF OBJECT_ID(N'[dbo].[WorkerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EquipmentSet'
CREATE TABLE [dbo].[EquipmentSet] (
    [Id] uniqueidentifier  NOT NULL,
    [number] nchar(12)  NOT NULL,
    [repairDate] datetime  NOT NULL,
    [serviceDate] datetime  NOT NULL,
    [nextVerificationDate] datetime  NULL,
    [termDate] datetime  NULL,
    [isWorking] bit  NOT NULL,
    [isFree] bit  NOT NULL,
    [EquipmentType_Id] int  NOT NULL,
    [MVPS_Id] uniqueidentifier  NULL
);
GO

-- Creating table 'EquipmentTypeSet'
CREATE TABLE [dbo].[EquipmentTypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [description] nvarchar(max)  NULL,
    [servicePeriod] int  NOT NULL,
    [verfPeriod] int  NULL,
    [SystemType_Id] int  NOT NULL,
    [Manufacturer_Id] int  NOT NULL
);
GO

-- Creating table 'ManufacturerSet'
CREATE TABLE [dbo].[ManufacturerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
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

-- Creating table 'ReplacingLogSet'
CREATE TABLE [dbo].[ReplacingLogSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [description] nvarchar(max)  NULL,
    [date] datetime  NOT NULL,
    [onShedule] bit  NOT NULL,
    [MVPS_Id] uniqueidentifier  NOT NULL,
    [Worker_Id] int  NOT NULL,
    [Installed_Id] uniqueidentifier  NOT NULL,
    [Removed_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Family] nvarchar(max)  NOT NULL,
    [Patronymic] nvarchar(max)  NOT NULL,
    [PersonnelNumber] int  NOT NULL,
    [PinCodeHash] nvarchar(max)  NOT NULL,
    [Position_Id] int  NOT NULL
);
GO

-- Creating table 'PositionSet'
CREATE TABLE [dbo].[PositionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EquipmentEventSet'
CREATE TABLE [dbo].[EquipmentEventSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date] datetime  NOT NULL,
    [description] nvarchar(max)  NULL,
    [event] smallint  NOT NULL,
    [Equipment_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ServiceLogSet'
CREATE TABLE [dbo].[ServiceLogSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date] datetime  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [isRepair] bit  NOT NULL,
    [Performer_Id] int  NOT NULL,
    [Equipment_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'SheduleSet'
CREATE TABLE [dbo].[SheduleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [date] datetime  NOT NULL
);
GO

-- Creating table 'EquipmentRuleEquipmentType'
CREATE TABLE [dbo].[EquipmentRuleEquipmentType] (
    [EquipmentRule_Id] int  NOT NULL,
    [EquipmentType_Id] int  NOT NULL
);
GO

-- Creating table 'MVPSShedule'
CREATE TABLE [dbo].[MVPSShedule] (
    [MVPS_Maintenance_Id] uniqueidentifier  NOT NULL,
    [Shedule_Maintenance_Id] int  NOT NULL
);
GO

-- Creating table 'MVPSShedule1'
CREATE TABLE [dbo].[MVPSShedule1] (
    [MVPS_Repair_Id] uniqueidentifier  NOT NULL,
    [Shedule_Repair_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EquipmentSet'
ALTER TABLE [dbo].[EquipmentSet]
ADD CONSTRAINT [PK_EquipmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EquipmentTypeSet'
ALTER TABLE [dbo].[EquipmentTypeSet]
ADD CONSTRAINT [PK_EquipmentTypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ManufacturerSet'
ALTER TABLE [dbo].[ManufacturerSet]
ADD CONSTRAINT [PK_ManufacturerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
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

-- Creating primary key on [Id] in table 'ReplacingLogSet'
ALTER TABLE [dbo].[ReplacingLogSet]
ADD CONSTRAINT [PK_ReplacingLogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PositionSet'
ALTER TABLE [dbo].[PositionSet]
ADD CONSTRAINT [PK_PositionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EquipmentEventSet'
ALTER TABLE [dbo].[EquipmentEventSet]
ADD CONSTRAINT [PK_EquipmentEventSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceLogSet'
ALTER TABLE [dbo].[ServiceLogSet]
ADD CONSTRAINT [PK_ServiceLogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SheduleSet'
ALTER TABLE [dbo].[SheduleSet]
ADD CONSTRAINT [PK_SheduleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [EquipmentRule_Id], [EquipmentType_Id] in table 'EquipmentRuleEquipmentType'
ALTER TABLE [dbo].[EquipmentRuleEquipmentType]
ADD CONSTRAINT [PK_EquipmentRuleEquipmentType]
    PRIMARY KEY CLUSTERED ([EquipmentRule_Id], [EquipmentType_Id] ASC);
GO

-- Creating primary key on [MVPS_Maintenance_Id], [Shedule_Maintenance_Id] in table 'MVPSShedule'
ALTER TABLE [dbo].[MVPSShedule]
ADD CONSTRAINT [PK_MVPSShedule]
    PRIMARY KEY CLUSTERED ([MVPS_Maintenance_Id], [Shedule_Maintenance_Id] ASC);
GO

-- Creating primary key on [MVPS_Repair_Id], [Shedule_Repair_Id] in table 'MVPSShedule1'
ALTER TABLE [dbo].[MVPSShedule1]
ADD CONSTRAINT [PK_MVPSShedule1]
    PRIMARY KEY CLUSTERED ([MVPS_Repair_Id], [Shedule_Repair_Id] ASC);
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

-- Creating foreign key on [Manufacturer_Id] in table 'EquipmentTypeSet'
ALTER TABLE [dbo].[EquipmentTypeSet]
ADD CONSTRAINT [FK_ManufacturerEquipmentType]
    FOREIGN KEY ([Manufacturer_Id])
    REFERENCES [dbo].[ManufacturerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerEquipmentType'
CREATE INDEX [IX_FK_ManufacturerEquipmentType]
ON [dbo].[EquipmentTypeSet]
    ([Manufacturer_Id]);
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

-- Creating foreign key on [EquipmentType_Id] in table 'EquipmentRuleEquipmentType'
ALTER TABLE [dbo].[EquipmentRuleEquipmentType]
ADD CONSTRAINT [FK_EquipmentRuleEquipmentType_EquipmentType]
    FOREIGN KEY ([EquipmentType_Id])
    REFERENCES [dbo].[EquipmentTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentRuleEquipmentType_EquipmentType'
CREATE INDEX [IX_FK_EquipmentRuleEquipmentType_EquipmentType]
ON [dbo].[EquipmentRuleEquipmentType]
    ([EquipmentType_Id]);
GO

-- Creating foreign key on [EquipmentType_Id] in table 'EquipmentSet'
ALTER TABLE [dbo].[EquipmentSet]
ADD CONSTRAINT [FK_EquipmentTypeEquipment]
    FOREIGN KEY ([EquipmentType_Id])
    REFERENCES [dbo].[EquipmentTypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentTypeEquipment'
CREATE INDEX [IX_FK_EquipmentTypeEquipment]
ON [dbo].[EquipmentSet]
    ([EquipmentType_Id]);
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

-- Creating foreign key on [MVPS_Id] in table 'ReplacingLogSet'
ALTER TABLE [dbo].[ReplacingLogSet]
ADD CONSTRAINT [FK_MVPSReplacingLog]
    FOREIGN KEY ([MVPS_Id])
    REFERENCES [dbo].[MVPSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSReplacingLog'
CREATE INDEX [IX_FK_MVPSReplacingLog]
ON [dbo].[ReplacingLogSet]
    ([MVPS_Id]);
GO

-- Creating foreign key on [Position_Id] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [FK_PositionWorker]
    FOREIGN KEY ([Position_Id])
    REFERENCES [dbo].[PositionSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PositionWorker'
CREATE INDEX [IX_FK_PositionWorker]
ON [dbo].[WorkerSet]
    ([Position_Id]);
GO

-- Creating foreign key on [Worker_Id] in table 'ReplacingLogSet'
ALTER TABLE [dbo].[ReplacingLogSet]
ADD CONSTRAINT [FK_WorkerReplacingLog]
    FOREIGN KEY ([Worker_Id])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerReplacingLog'
CREATE INDEX [IX_FK_WorkerReplacingLog]
ON [dbo].[ReplacingLogSet]
    ([Worker_Id]);
GO

-- Creating foreign key on [Installed_Id] in table 'ReplacingLogSet'
ALTER TABLE [dbo].[ReplacingLogSet]
ADD CONSTRAINT [FK_EquipmentReplacingLog]
    FOREIGN KEY ([Installed_Id])
    REFERENCES [dbo].[EquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentReplacingLog'
CREATE INDEX [IX_FK_EquipmentReplacingLog]
ON [dbo].[ReplacingLogSet]
    ([Installed_Id]);
GO

-- Creating foreign key on [Removed_Id] in table 'ReplacingLogSet'
ALTER TABLE [dbo].[ReplacingLogSet]
ADD CONSTRAINT [FK_EquipmentReplacingLog1]
    FOREIGN KEY ([Removed_Id])
    REFERENCES [dbo].[EquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentReplacingLog1'
CREATE INDEX [IX_FK_EquipmentReplacingLog1]
ON [dbo].[ReplacingLogSet]
    ([Removed_Id]);
GO

-- Creating foreign key on [Equipment_Id] in table 'EquipmentEventSet'
ALTER TABLE [dbo].[EquipmentEventSet]
ADD CONSTRAINT [FK_EquipmentEquipmentEvent]
    FOREIGN KEY ([Equipment_Id])
    REFERENCES [dbo].[EquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentEquipmentEvent'
CREATE INDEX [IX_FK_EquipmentEquipmentEvent]
ON [dbo].[EquipmentEventSet]
    ([Equipment_Id]);
GO

-- Creating foreign key on [Performer_Id] in table 'ServiceLogSet'
ALTER TABLE [dbo].[ServiceLogSet]
ADD CONSTRAINT [FK_WorkerServiceLog]
    FOREIGN KEY ([Performer_Id])
    REFERENCES [dbo].[WorkerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkerServiceLog'
CREATE INDEX [IX_FK_WorkerServiceLog]
ON [dbo].[ServiceLogSet]
    ([Performer_Id]);
GO

-- Creating foreign key on [Equipment_Id] in table 'ServiceLogSet'
ALTER TABLE [dbo].[ServiceLogSet]
ADD CONSTRAINT [FK_EquipmentServiceLog]
    FOREIGN KEY ([Equipment_Id])
    REFERENCES [dbo].[EquipmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipmentServiceLog'
CREATE INDEX [IX_FK_EquipmentServiceLog]
ON [dbo].[ServiceLogSet]
    ([Equipment_Id]);
GO

-- Creating foreign key on [MVPS_Maintenance_Id] in table 'MVPSShedule'
ALTER TABLE [dbo].[MVPSShedule]
ADD CONSTRAINT [FK_MVPSShedule_MVPS]
    FOREIGN KEY ([MVPS_Maintenance_Id])
    REFERENCES [dbo].[MVPSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Shedule_Maintenance_Id] in table 'MVPSShedule'
ALTER TABLE [dbo].[MVPSShedule]
ADD CONSTRAINT [FK_MVPSShedule_Shedule]
    FOREIGN KEY ([Shedule_Maintenance_Id])
    REFERENCES [dbo].[SheduleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSShedule_Shedule'
CREATE INDEX [IX_FK_MVPSShedule_Shedule]
ON [dbo].[MVPSShedule]
    ([Shedule_Maintenance_Id]);
GO

-- Creating foreign key on [MVPS_Repair_Id] in table 'MVPSShedule1'
ALTER TABLE [dbo].[MVPSShedule1]
ADD CONSTRAINT [FK_MVPSShedule1_MVPS]
    FOREIGN KEY ([MVPS_Repair_Id])
    REFERENCES [dbo].[MVPSSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Shedule_Repair_Id] in table 'MVPSShedule1'
ALTER TABLE [dbo].[MVPSShedule1]
ADD CONSTRAINT [FK_MVPSShedule1_Shedule]
    FOREIGN KEY ([Shedule_Repair_Id])
    REFERENCES [dbo].[SheduleSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MVPSShedule1_Shedule'
CREATE INDEX [IX_FK_MVPSShedule1_Shedule]
ON [dbo].[MVPSShedule1]
    ([Shedule_Repair_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------