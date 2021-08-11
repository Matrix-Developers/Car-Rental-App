CREATE TABLE [dbo].[TBGRUPOVEICULO] (
    [Id]                                INT          IDENTITY (1, 1) NOT NULL,
    [Nome]                              VARCHAR (50) NOT NULL,
    [TaxaPlanoDiario]                   FLOAT (53)   NOT NULL,
    [TaxaKmControlado]                  FLOAT (53)   NOT NULL,
    [TaxaKmLivre]                       FLOAT (53)   NOT NULL,
    [QuantidadeQuilometrosKmControlado] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

