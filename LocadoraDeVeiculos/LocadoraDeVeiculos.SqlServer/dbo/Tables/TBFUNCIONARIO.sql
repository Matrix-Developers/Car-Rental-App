CREATE TABLE [dbo].[TBFUNCIONARIO] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [Nome]             VARCHAR (50) NOT NULL,
    [RegistroUnico]    VARCHAR (50) NOT NULL,
    [Endereco]         VARCHAR (50) NULL,
    [Telefone]         VARCHAR (50) NULL,
    [Email]            VARCHAR (50) NULL,
    [EhPessoaFisica]   BIT          NOT NULL,
    [MatriculaInterna] VARCHAR (50) NOT NULL,
    [UsuarioAcesso]    VARCHAR (50) NOT NULL,
    [Senha]    VARCHAR (50) NOT NULL,
    [Cargo]            VARCHAR (50) NOT NULL,
    [Salario]          FLOAT (53)   NOT NULL,
    [dataAdmissao]     DATETIME     NOT NULL,
    CONSTRAINT [PK__TBFUNCIO__3214EC074F92C5D7] PRIMARY KEY CLUSTERED ([Id] ASC)
);



