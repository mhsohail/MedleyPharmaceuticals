
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2015 06:36:02
-- Generated from EDMX file: C:\Users\pc\documents\visual studio 2013\Projects\MedleyPharmaceuticals\MedleyPharmaceuticals\MedleyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MedleyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StockReceivedGood]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceivedGoods] DROP CONSTRAINT [FK_StockReceivedGood];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ReceivedGoods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceivedGoods];
GO
IF OBJECT_ID(N'[dbo].[Stocks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stocks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ReceivedGoods'
CREATE TABLE [dbo].[ReceivedGoods] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ReceivingDate] datetime  NOT NULL,
    [GRNNo] nvarchar(max)  NOT NULL,
    [MaterialName] nvarchar(max)  NOT NULL,
    [BatchNo] nvarchar(max)  NOT NULL,
    [MfgDate] datetime  NOT NULL,
    [ExpDate] datetime  NOT NULL,
    [QuantityReceived] nvarchar(max)  NOT NULL,
    [NoOfCartons] int  NOT NULL,
    [Supplier] nvarchar(max)  NOT NULL,
    [ReferenceNo] nvarchar(max)  NOT NULL,
    [DeliveredToStore] bit  NOT NULL,
    [StockId] int  NOT NULL
);
GO

-- Creating table 'Stocks'
CREATE TABLE [dbo].[Stocks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NoOfCartons] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ReceivedGoods'
ALTER TABLE [dbo].[ReceivedGoods]
ADD CONSTRAINT [PK_ReceivedGoods]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Stocks'
ALTER TABLE [dbo].[Stocks]
ADD CONSTRAINT [PK_Stocks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StockId] in table 'ReceivedGoods'
ALTER TABLE [dbo].[ReceivedGoods]
ADD CONSTRAINT [FK_StockReceivedGood]
    FOREIGN KEY ([StockId])
    REFERENCES [dbo].[Stocks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StockReceivedGood'
CREATE INDEX [IX_FK_StockReceivedGood]
ON [dbo].[ReceivedGoods]
    ([StockId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------