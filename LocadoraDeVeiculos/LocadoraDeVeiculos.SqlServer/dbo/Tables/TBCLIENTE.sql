CREATE TABLE [dbo].[TBCLIENTE] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    [RegistroUnico]  VARCHAR (50) NOT NULL,
    [Endereco]       VARCHAR (50) NULL,
    [Telefone]       VARCHAR (50) NULL,
    [Email]          VARCHAR (50) NOT NULL,
    [EhPessoaFisica] BIT          NOT NULL,
    [Cnh]            VARCHAR (50) NOT NULL,
    [ValidadeCnh]    DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

