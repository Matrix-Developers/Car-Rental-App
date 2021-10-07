CREATE TABLE [dbo].[TBCUPOM_DESCONTO]
(
	[id]          INT          IDENTITY (1, 1) NOT NULL,
    [NomeCupom]   VARCHAR (50) NOT NULL,
    [Codigo]      VARCHAR (50) NOT NULL,
    [ValorMinimo] FLOAT (53)   NOT NULL,
    [Valor]       FLOAT        NOT NULL,    
    [EhDescontoFixo]        BIT          NOT NULL,
    [Validade]    DATE         NOT NULL,
    [id_Parceiro] INT          NOT NULL,        
    [QtdUtilizada] INT NOT NULL, 
    CONSTRAINT [PK_TBCUPOM_DESCONTO] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBDesconto_TBParceiros] FOREIGN KEY ([id_Parceiro]) REFERENCES [dbo].[TBPARCEIRO] ([id])
)
