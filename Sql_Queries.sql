CREATE TABLE [FlashcardDetails] (
    [Id] UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL PRIMARY KEY,
    [Question] varchar(max),
    [Answer] varchar(max),
);

select * from FlashcardDetails