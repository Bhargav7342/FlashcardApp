CREATE TABLE [FlashcardDetails] (
    [Id] UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
    [Question] varchar(max),
    [Answer] varchar(max),
);