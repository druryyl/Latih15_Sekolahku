using Dapper;
using Latih15_Sekolahku.DataIndukSiswa.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using Latih15_Sekolahku.Helpers;

namespace Latih15_Sekolahku.DataIndukSiswa.Dal
{
    public class SiswaRiwayatDal
    {
        public void Insert(SiswaRiwayatModel siswaRiwayat)
        {
            const string sql = @"
                INSERT INTO SiswaRiwayat(
                    SiswaId, GolDarah, SakitPernahDiDerita, 
                    KelainanJasmani, TinggiBadan, BeratBadan, 
                    PendidikanSebelumnya, TglIjazah, NoIjazah, LamaBelajar,
                    PindahanDari, AlasanPindah,
                    KelasPenerimaan, KompetensiKeahlian, TglDiterima) 
                VALUES (
                    @SiswaId, @GolDarah, @SakitPernahDiDerita, 
                    @KelainanJasmani, @TinggiBadan, @BeratBadan, 
                    @PendidikanSebelumnya, @TglIjazah, @NoIjazah, @LamaBelajar,
                    @PindahanDari, @AlasanPindah,
                    @KelasPenerimaan, @KompetensiKeahlian, @TglDiterima)";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaRiwayat.SiswaId, DbType.Int32);
            dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.Int16);
            dp.Add("@SakitPernahDiDerita", siswaRiwayat.SakitPernahDiderita, DbType.String); 
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String); 
            dp.Add("@TinggiBadan", siswaRiwayat.TinggiBadan, DbType.Int16); 
            dp.Add("@BeratBadan", siswaRiwayat.BeratBadan, DbType.Int16); 
            dp.Add("@PendidikanSebelumnya", siswaRiwayat.PendidikanSebelumnya, DbType.String); 
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.DateTime); 
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String); 
            dp.Add("@LamaBelajar", siswaRiwayat.LamaBelajar, DbType.String);
            dp.Add("@PindahanDari", siswaRiwayat.PindahanDari, DbType.String); 
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            dp.Add("@KelasPenerimaan", siswaRiwayat.KelasPenerimaan, DbType.String); 
            dp.Add("@KompetensiKeahlian", siswaRiwayat.KompetensiKeahlian, DbType.String); 
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.DateTime);

            var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Update(SiswaRiwayatModel siswaRiwayat)
        {
            const string sql = @"
                UPDATE SiswaRiwayat
                SET
                    GolDarah = @GolDarah, 
                    SakitPernahDiDerita = @SakitPernahDiDerita, 
                    KelainanJasmani = @KelainanJasmani, 
                    TinggiBadan = @TinggiBadan, 
                    BeratBadan = @BeratBadan, 
                    PendidikanSebelumnya = @PendidikanSebelumnya, 
                    TglIjazah = @TglIjazah, 
                    NoIjazah = @NoIjazah, 
                    LamaBelajar = @LamaBelajar,
                    PindahanDari = @PindahanDari, 
                    AlasanPindah = @AlasanPindah,
                    KelasPenerimaan = @KelasPenerimaan, 
                    KompetensiKeahlian = @KompetensiKeahlian, 
                    TglDiterima = @TglDiterima
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaRiwayat.SiswaId, DbType.Int32);
            dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.Int16);
            dp.Add("@SakitPernahDiDerita", siswaRiwayat.SakitPernahDiderita, DbType.String);
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String);
            dp.Add("@TinggiBadan", siswaRiwayat.TinggiBadan, DbType.Int16);
            dp.Add("@BeratBadan", siswaRiwayat.BeratBadan, DbType.Int16);
            dp.Add("@PendidikanSebelumnya", siswaRiwayat.PendidikanSebelumnya, DbType.String);
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.DateTime);
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String);
            dp.Add("@LamaBelajar", siswaRiwayat.LamaBelajar, DbType.String);
            dp.Add("@PindahanDari", siswaRiwayat.PindahanDari, DbType.String);
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            dp.Add("@KelasPenerimaan", siswaRiwayat.KelasPenerimaan, DbType.String);
            dp.Add("@KompetensiKeahlian", siswaRiwayat.KompetensiKeahlian, DbType.String);
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.DateTime);

            var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int siswaId)
        {
            const string sql = @"
                DELETE FROM SiswaRiwayat
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int32);

            var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public SiswaRiwayatModel GetData(int siswaId)
        {
            const string sql = @"
                SELECT
                    GolDarah, SakitPernahDiDerita, KelainanJasmani, 
                    TinggiBadan, BeratBadan, PendidikanSebelumnya, 
                    TglIjazah, NoIjazah, LamaBelajar, PindahanDari, 
                    AlasanPindah, KelasPenerimaan, KompetensiKeahlian, 
                    TglDiterima
                FROM
                    SiswaRiwayat
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int32);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.QuerySingle<SiswaRiwayatModel>(sql, dp);
        }

        public IEnumerable<SiswaRiwayatModel> ListData()
        {
            const string sql = @"
                SELECT
                    SiswaId, GolDarah, SakitPernahDiDerita, KelainanJasmani, 
                    TinggiBadan, BeratBadan, PendidikanSebelumnya, 
                    TglIjazah, NoIjazah, LamaBelajar, PindahanDari, 
                    AlasanPindah, KelasPenerimaan, KompetensiKeahlian, 
                    TglDiterima
                FROM
                    SiswaRiwayat";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<SiswaRiwayatModel>(sql);
        }
    }
}
