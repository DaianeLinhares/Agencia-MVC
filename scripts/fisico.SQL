IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Cliente] DROP CONSTRAINT [FK_Cliente_destino_DestinoId];
GO

ALTER TABLE [Cliente] DROP CONSTRAINT [PK_Cliente];
GO

EXEC sp_rename N'[Cliente]', N'cliente';
GO

EXEC sp_rename N'[cliente].[IX_Cliente_DestinoId]', N'IX_cliente_DestinoId', N'INDEX';
GO

ALTER TABLE [cliente] ADD CONSTRAINT [PK_cliente] PRIMARY KEY ([IdCliente]);
GO

CREATE TABLE [contato] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Mensagem] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_contato] PRIMARY KEY ([Id])
);
GO

ALTER TABLE [cliente] ADD CONSTRAINT [FK_cliente_destino_DestinoId] FOREIGN KEY ([DestinoId]) REFERENCES [destino] ([IdDestino]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211215183424_agencia', N'6.0.1');
GO

COMMIT;
GO

