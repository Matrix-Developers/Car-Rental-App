﻿CREATE TABLE [dbo].[TBLOCACAO] (
    [Id]                    INT          IDENTITY (1, 1) NOT NULL,
    [Id_Veiculo]            INT          NOT NULL,
    [Id_Funcionario]        INT          NOT NULL,
    [Id_ClienteContratante] INT          NOT NULL,
    [Id_ClienteCondutor]    INT          NULL,
    [Id_Cupom]              INT          NULL,
    [dataDeSaida]           DATETIME     NOT NULL,
    [dataPrevistaDeChegada] DATETIME     NOT NULL,
    [dataDeChegada]           DATETIME NULL,
    [tipoDoPlano]          VARCHAR (50) NOT NULL,
    [tipoDeSeguro]          VARCHAR(50)   NOT NULL,
    [precoLocacao] FLOAT NOT NULL, 
    [precoDevolucao] FLOAT NOT NULL, 
    [estaAberta] BIT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBLOCACAO_TBCLIENTE] FOREIGN KEY ([Id_ClienteContratante]) REFERENCES [dbo].[TBCLIENTE] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBCLIENTE1] FOREIGN KEY ([Id_ClienteCondutor]) REFERENCES [dbo].[TBCLIENTE] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBCUPOM] FOREIGN KEY ([Id_Cupom]) REFERENCES [dbo].[TBCUPOM_DESCONTO] ([Id]),
    CONSTRAINT [FK_TBLOCACAO_TBFUNCIONARIO] FOREIGN KEY ([Id_Funcionario]) REFERENCES [dbo].[TBFUNCIONARIO] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TBLOCACAO_TBVEICULO] FOREIGN KEY ([Id_Veiculo]) REFERENCES [dbo].[TBVEICULO] ([Id]) ON DELETE CASCADE
);

