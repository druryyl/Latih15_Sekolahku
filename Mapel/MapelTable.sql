﻿CREATE TABLE Mapel(
	MapelId INT IDENTITY(1,1),
	MapelName VARCHAR(30) NOT NULL DEFAULT(''),

	CONSTRAINT PK_Mapel PRIMARY KEY CLUSTERED(MapelId)
)