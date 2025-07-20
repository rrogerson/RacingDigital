CREATE TABLE [dbo].[Race]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Race] NVARCHAR(500) NOT NULL, 
    [RaceDate] DATE NOT NULL, 
    [RaceTime] INT NOT NULL, 
    [RaceCourse] NVARCHAR(50) NOT NULL, 
    [RaceDistance] INT NOT NULL
)
