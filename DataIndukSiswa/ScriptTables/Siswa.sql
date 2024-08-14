CREATE TABLE Siswa(
    SiswaId INT IDENTITY(1,1),
    NamaLengkap  VARCHAR(50) NOT NULL DEFAULT(''),
    NamaPanggilan  VARCHAR(50) NOT NULL DEFAULT(''),
    TempatLahir  VARCHAR(50) NOT NULL DEFAULT(''),
    TanggalLahir  DATETIME NOT NULL DEFAULT('3000-01-01'),
    Gender  INT NOT NULL DEFAULT(''),
    Agama  VARCHAR(50) NOT NULL DEFAULT(''),
    WargaNegara  VARCHAR(50) NOT NULL DEFAULT(''),
    AnakKe INT NOT NULL DEFAULT(0),
    JumSaudaraKandung  INT NOT NULL DEFAULT(0),
    JumSaudaraTiri  INT NOT NULL DEFAULT(0),
    JumSaudaraAngkat INT NOT NULL DEFAULT(0),
    AlamatSiswa  VARCHAR(50) NOT NULL DEFAULT(''),
    NomorHpRumah  VARCHAR(50) NOT NULL DEFAULT(''),
    StatusTinggal  VARCHAR(50) NOT NULL DEFAULT(''),
    JarakKeSekolah  INT NOT NULL DEFAULT(''),
    TransportKeSekolah  VARCHAR(50) NOT NULL DEFAULT(''),

    CONSTRAINT PK_Siswa PRIMARY KEY CLUSTERED(SiswaId)
)
GO