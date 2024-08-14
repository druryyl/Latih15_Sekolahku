using Dapper;
using Latih15_Sekolahku.DataIndukSiswa.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using Latih15_Sekolahku.Helpers;

namespace Latih15_Sekolahku.DataIndukSiswa.Dal
{
    public class SiswaDal
    {
        public int Insert(SiswaModel siswa)
        {
            const string sql = @"
                INSERT INTO Siswa(
                    NamaLengkap, NamaPanggilan, TempatLahir,
                    TanggalLahir, Gender, Agama, WargaNegara,
                    AnakKe, JumSaudaraKandung, JumSaudaraTiri, JumSaudaraAngkat,
                    AlamatSiswa, NomorHpRumah, StatusTinggal,
                    JarakKeSekolah, TransportKeSekolah)
                VALUES (
                    @NamaLengkap, @NamaPanggilan, @TempatLahir,
                    @TanggalLahir, @Gender, @Agama, @WargaNegara,
                    @AnakKe, @JumSaudaraKandung, @JumSaudaraTiri, @JumSaudaraAngkat,
                    @AlamatSiswa, @NomorHpRumah, @StatusTinggal,
                    @JarakKeSekolah, @TransportKeSekolah);
                SELECT CAST(SCOPE_IDENTITY() as int;";

            var dp = new DynamicParameters();
            dp.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            dp.Add("@NamaPanggilan", siswa.NamaPanggilan, DbType.String);
            dp.Add("@TempatLahir", siswa.TempatLahir, DbType.String);
            dp.Add("@TanggalLahir", siswa.TanggalLahir, DbType.DateTime);
            dp.Add("@Gender", siswa.Gender, DbType.Int16);
            dp.Add("@Agama", siswa.Agama, DbType.String);
            dp.Add("@WargaNegara", siswa.WargaNegara, DbType.String);
            dp.Add("@AnakKe", siswa.AnakKe, DbType.Int16);
            dp.Add("@JumSaudaraKandung", siswa.JumSaudaraKandung, DbType.Int16);
            dp.Add("@JumSaudaraTiri", siswa.JumSaudaraTiri, DbType.Int16);
            dp.Add("@JumSaudaraAngkat", siswa.JumSaudaraAngkat, DbType.Int16);
            dp.Add("@AlamatSiswa", siswa.AlamatSiswa, DbType.String);
            dp.Add("@NomorHpRumah", siswa.NomorHpRumah, DbType.String);
            dp.Add("@StatusTinggal", siswa.StatusTinggal, DbType.String);
            dp.Add("@JarakKeSekolah", siswa.JarakKeSekolah, DbType.Int16); 
            dp.Add("@TransportKeSekolah", siswa.TransportKeSekolah, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, dp);
            return result;
        }

        public void Update(SiswaModel siswa)
        {
            const string sql = @"
                UPDATE 
                    Siswa
                SET
                    NamaLengkap = @NamaLengkap, 
                    NamaPanggilan = @NamaPanggilan, 
                    TempatLahir = @TempatLahir,
                    TanggalLahir = @TanggalLahir, 
                    Gender = @Gender, 
                    Agama = @Agama, 
                    WargaNegara = @WargaNegara,
                    AnakKe = @AnakKe, 
                    JumSaudaraKandung = @JumSaudaraKandung, 
                    JumSaudaraTiri = @JumSaudaraTiri, 
                    JumSaudaraAngkat = @JumSaudaraAngkat,
                    AlamatSiswa = @AlamatSiswa, 
                    NomorHpRumah = @NomorHpRumah, 
                    StatusTinggal = @StatusTinggal,
                    JarakKeSekolah = @JarakKeSekolah, 
                    TransportKeSekolah = @TransportKeSekolah
                WHERE
                    SiswaId = @SiswaId";     

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswa.SiswaId, DbType.Int16);
            dp.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            dp.Add("@NamaPanggilan", siswa.NamaPanggilan, DbType.String);
            dp.Add("@TempatLahir", siswa.TempatLahir, DbType.String);
            dp.Add("@TanggalLahir", siswa.TanggalLahir, DbType.DateTime);
            dp.Add("@Gender", siswa.Gender, DbType.Int16);
            dp.Add("@Agama", siswa.Agama, DbType.String);
            dp.Add("@WargaNegara", siswa.WargaNegara, DbType.String);
            dp.Add("@AnakKe", siswa.AnakKe, DbType.Int16);
            dp.Add("@JumSaudaraKandung", siswa.JumSaudaraKandung, DbType.Int16);
            dp.Add("@JumSaudaraTiri", siswa.JumSaudaraTiri, DbType.Int16);
            dp.Add("@JumSaudaraAngkat", siswa.JumSaudaraAngkat, DbType.Int16);
            dp.Add("@AlamatSiswa", siswa.AlamatSiswa, DbType.String);
            dp.Add("@NomorHpRumah", siswa.NomorHpRumah, DbType.String);
            dp.Add("@StatusTinggal", siswa.StatusTinggal, DbType.String);
            dp.Add("@JarakKeSekolah", siswa.JarakKeSekolah, DbType.Int16);
            dp.Add("@TransportKeSekolah", siswa.TransportKeSekolah, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int siswaId)
        {
            const string sql = @"
                DELETE FROM 
                    Siswa
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public SiswaModel GetData(int siswaId)
        {
            const string sql = @"
                SELECT
                    NamaLengkap, NamaPanggilan, TempatLahir,
                    TanggalLahir, Gender, Agama, WargaNegara,
                    AnakKe, JumSaudaraKandung, JumSaudaraTiri, JumSaudaraAngkat,
                    AlamatSiswa, NomorHpRumah, StatusTinggal,
                    JarakKeSekolah, TransportKeSekolah
                FROM
                    Siswa
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.QuerySingle<SiswaModel>(sql, dp);
        }

        public IEnumerable<SiswaModel> ListData()
        {
            const string sql = @"
                SELECT
                    SiswaId, NamaLengkap, NamaPanggilan, TempatLahir,
                    TanggalLahir, Gender, Agama, WargaNegara,
                    AnakKe, JumSaudaraKandung, JumSaudaraTiri, JumSaudaraAngkat,
                    AlamatSiswa, NomorHpRumah, StatusTinggal,
                    JarakKeSekolah, TransportKeSekolah
                FROM
                    Siswa";

            var dp = new DynamicParameters();

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<SiswaModel>(sql, dp);
        }
    }
}
