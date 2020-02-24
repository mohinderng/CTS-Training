
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 09:42:07
-- Generated from EDMX file: D:\HTML Mohinder\C#\ModelFirstFinal\ModelFirstFinal\ExamStudent.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookDb];
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

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [Ename] nvarchar(max)  NOT NULL,
    [TotalMarks] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Sid] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [Score] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Rid] int IDENTITY(1,1) NOT NULL,
    [StudentSid] int  NOT NULL,
    [ExamEid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- Creating primary key on [Sid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [Rid] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Rid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentSid] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_StudentResult]
    FOREIGN KEY ([StudentSid])
    REFERENCES [dbo].[Students]
        ([Sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentResult'
CREATE INDEX [IX_FK_StudentResult]
ON [dbo].[Results]
    ([StudentSid]);
GO

-- Creating foreign key on [ExamEid] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_ExamResult]
    FOREIGN KEY ([ExamEid])
    REFERENCES [dbo].[Exams]
        ([Eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamResult'
CREATE INDEX [IX_FK_ExamResult]
ON [dbo].[Results]
    ([ExamEid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------