CREATE TABLE SiswaRiwayat(
    SiswaId INT NOT NULL DEFAULT(0),
    GolDarah VARCHAR(50) NOT NULL DEFAULT(0),
    SakitPernahDiderita VARCHAR(50) NOT NULL DEFAULT(''),
    KelainanJasmani VARCHAR(50) NOT NULL DEFAULT(''),
    TinggiBadan INT NOT NULL DEFAULT(''),
    BeratBadan INT NOT NULL DEFAULT(''),

    PendidikanSebelumnya VARCHAR(50) NOT NULL DEFAULT(''),
    TglIjazah DATETIME NOT NULL DEFAULT('3000-01-01'),
    NoIjazah VARCHAR(50) NOT NULL DEFAULT(''),
    LamaBelajar VARCHAR(50) NOT NULL DEFAULT(''),

    PindahanDari VARCHAR(50) NOT NULL DEFAULT(''),
    AlasanPindah VARCHAR(50) NOT NULL DEFAULT(''),

    KelasPenerimaan VARCHAR(50) NOT NULL DEFAULT(''),
    KompetensiKeahlian VARCHAR(50) NOT NULL DEFAULT(''),
    TglDiterima DATETIME NOT NULL DEFAULT('3000-01-01'),

    CONSTRAINT PK_SiswaRiwayat PRIMARY KEY CLUSTERED(SiswaId)
)
GO