CREATE TABLE [dbo].[TBCUPOM_DESCONTO]
(
	[Id]          INT          IDENTITY (1, 1) NOT NULL,
    [NomeCupom]   VARCHAR (50) NOT NULL,
    [Codigo]      VARCHAR (50) NOT NULL,
    [ValorMinimo] FLOAT (53)   NOT NULL,
    [Valor]       FLOAT        NOT NULL,    
    [EhDescontoFixo]        BIT          NOT NULL,
    [Validade]    DATE         NOT NULL,
    [Id_Parceiro] INT          NOT NULL,        
    CONSTRAINT [PK_TBCUPOM_DESCONTO] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBDesconto_TBParceiros] FOREIGN KEY ([Id_Parceiro]) REFERENCES [dbo].[TBPARCEIRO] ([Id])
)
