CREATE TABLE [dbo].[TBVEICULO] (
    [Id]                   INT          IDENTITY (1, 1) NOT NULL,
    [Modelo]               VARCHAR (50) NOT NULL,
    [Id_GrupoVeiculo]      INT          NOT NULL,
    [Placa]                VARCHAR (50) NOT NULL,
    [Chassi]               VARCHAR (50) NOT NULL,
    [Marca]                VARCHAR (50) NOT NULL,
    [Cor]                  VARCHAR (50) NOT NULL,
    [TipoCombustivel]      VARCHAR (50) NOT NULL,
    [Ano]                  INT          NOT NULL,
    [Kilometragem]         FLOAT (53)   NOT NULL,
    [NumeroPortas]         INT          NOT NULL,
    [CapacidadePessoas]    INT          NOT NULL,
    [TamanhoPortaMala]     VARCHAR (50) NOT NULL,
    [TemArCondicionado]    BIT          NOT NULL,
    [TemDirecaoHidraulica] BIT          NOT NULL,
    [TemFreiosAbs]         BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

