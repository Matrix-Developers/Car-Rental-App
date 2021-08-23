CREATE TABLE [dbo].[TBGRUPOVEICULO] (
    [Id]                       INT          IDENTITY (1, 1) NOT NULL,
    [Nome]                     VARCHAR (50) NOT NULL,
    [TaxaPlanoDiario]          FLOAT (53)   NOT NULL,
    [TaxaPorKmDiario]          FLOAT (53)   NOT NULL,
    [TaxaPlanoControlado]      FLOAT (53)   NOT NULL,
    [LimiteKmControlado]       INT          NOT NULL,
    [TaxaKmExcedidoControlado] FLOAT (53)   NOT NULL,
    [TaxaPlanoLivre]           FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



