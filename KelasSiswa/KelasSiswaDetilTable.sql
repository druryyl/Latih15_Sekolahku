CREATE TABLE KelasSiswaDetil(
	KelasId INT NOT NULL CONSTRAINT DF_KelasSiswaDetil_KelasId DEFAULT(0),
	SiswaId INT NOT NULL CONSTRAINT DF_KelasSiswaDetil_SiswaId DEFAULT(0),
)
GO

CREATE CLUSTERED INDEX CX_KelasSiswaDetil_KelasId
	ON KelasSiswaDetil(KelasId)
GO