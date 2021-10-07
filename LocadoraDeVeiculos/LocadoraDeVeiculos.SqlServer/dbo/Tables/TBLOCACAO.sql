CREATE TABLE [dbo].[TBLOCACAO] (
    [id]                    INT          IDENTITY (1, 1) NOT NULL,
    [id_Veiculo]            INT          NOT NULL,
    [id_Funcionario]        INT          NOT NULL,
    [id_ClienteContratante] INT          NOT NULL,
    [id_ClienteCondutor]    INT          NULL,
    [id_Cupom]              INT          NULL,
    [dataDeSaida]           DATETIME     NOT NULL,
    [dataPrevistaDeChegada] DATETIME     NOT NULL,
    [dataDeChegada]           DATETIME NULL,
    [tipoDoPlano]          VARCHAR (50) NOT NULL,
    [tipoDeSeguro]          VARCHAR(50)   NOT NULL,
    [precoLocacao] FLOAT NOT NULL, 
    [precoDevolucao] FLOAT NOT NULL, 
    [estaAberta] BIT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TBLOCACAO_TBCLIENTE] FOREIGN KEY ([id_ClienteContratante]) REFERENCES [dbo].[TBCLIENTE] ([id]),
    CONSTRAINT [FK_TBLOCACAO_TBCLIENTE1] FOREIGN KEY ([id_ClienteCondutor]) REFERENCES [dbo].[TBCLIENTE] ([id]),
    CONSTRAINT [FK_TBLOCACAO_TBCUPOM] FOREIGN KEY ([id_Cupom]) REFERENCES [dbo].[TBCUPOM_DESCONTO] ([id]),
    CONSTRAINT [FK_TBLOCACAO_TBFUNCIONARIO] FOREIGN KEY ([id_Funcionario]) REFERENCES [dbo].[TBFUNCIONARIO] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TBLOCACAO_TBVEICULO] FOREIGN KEY ([id_Veiculo]) REFERENCES [dbo].[TBVEICULO] ([id]) ON DELETE CASCADE
);

