CREATE TABLE [Tasks] (
    [Id] int NOT NULL IDENTITY,
    [Tasktitle] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Tasks] PRIMARY KEY ([Id])
);
GO