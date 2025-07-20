CREATE TABLE [dbo].[RaceResults]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RaceId] INT NOT NULL, 
    [Jockey] NVARCHAR(100) NOT NULL, 
    [FinishingPosition] INT NOT NULL, 
    [DistanceBeaten] DECIMAL(18, 2) NOT NULL, 
    [TimeBeaten] DECIMAL(18, 2) NOT NULL 
)
