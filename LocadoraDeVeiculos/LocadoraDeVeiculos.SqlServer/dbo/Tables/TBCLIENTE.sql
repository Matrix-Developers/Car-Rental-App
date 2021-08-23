CREATE TABLE [dbo].[TBCLIENTE] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    [RegistroUnico]  VARCHAR (50) NOT NULL,
    [Endereco]       VARCHAR (50) NULL,
    [Telefone]       VARCHAR (50) NULL,
    [Email]          VARCHAR (50) NULL,
    [EhPessoaFisica] BIT          NOT NULL,
    [Cnh]            VARCHAR (50) NULL,
    [ValidadeCnh]    DATETIME     NULL,
    CONSTRAINT [PK__TBCLIENT__3214EC07279494AB] PRIMARY KEY CLUSTERED ([Id] ASC)
);



