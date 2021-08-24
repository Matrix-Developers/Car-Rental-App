CREATE TABLE [dbo].[TBGRUPOVEICULO] (
    [Id]                       INT          IDENTITY (1, 1) NOT NULL,
    [Nome]                     VARCHAR (50) NOT NULL,
    [TaxaPlanoDiario]          FLOAT (53)   NOT NULL,
    [TaxaPorKmDiario]          FLOAT (53)   NULL,
    [TaxaPlanoControlado]      FLOAT (53)   NOT NULL,
    [LimiteKmControlado]       INT          NULL,
    [TaxaKmExcedidoControlado] FLOAT (53)   NULL,
    [TaxaPlanoLivre]           FLOAT (53)   NOT NULL,
    CONSTRAINT [PK__TBGRUPOV__3214EC07DABBBF2B] PRIMARY KEY CLUSTERED ([Id] ASC)
);





