﻿CREATE TABLE [dbo].[TBSERVICO] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [nome]  VARCHAR (50) NOT NULL,
    [ehTaxadoDiario]  BIT NOT NULL,
    [valor] FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

