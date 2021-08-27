CREATE TABLE [dbo].[TBSERVICO_LOCACAO] (
    [id]         INT NOT NULL,
    [id_locacao] INT NOT NULL,
    [id_sevico]  INT NOT NULL,
    CONSTRAINT [id_locacao] FOREIGN KEY ([id_locacao]) REFERENCES [dbo].[TBLOCACAO] ([Id]),
    CONSTRAINT [id_servico] FOREIGN KEY ([id_sevico]) REFERENCES [dbo].[TBSERVICO] ([Id])
);

