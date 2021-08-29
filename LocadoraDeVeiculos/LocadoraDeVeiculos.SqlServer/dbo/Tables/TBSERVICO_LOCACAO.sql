CREATE TABLE [dbo].[TBSERVICO_LOCACAO] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [id_locacao] INT NOT NULL,
    [id_servico]  INT NOT NULL,
    CONSTRAINT [PK_TBSERVICO_LOCACAO] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [id_locacao] FOREIGN KEY ([id_locacao]) REFERENCES [dbo].[TBLOCACAO] ([Id]),
    CONSTRAINT [id_servico] FOREIGN KEY ([id_servico]) REFERENCES [dbo].[TBSERVICO] ([Id])
);



