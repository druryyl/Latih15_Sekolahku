using Dapper;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.KelasSiswa;

public class KelasSiswaDal
{
    public void Insert(KelasSiswaModel kelasSiswa)
    {
        const string sql = @"
            INSERT INTO KelasSiswa(KelasId, TahunAjaran, WaliKelasId)
            VALUES (@KelasId, @TahunAjaran, @WaliKelasId)";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasSiswa.KelasId, DbType.Int32);
        dp.Add("@TahunAjaran", kelasSiswa.TahunAjaran, DbType.String);
        dp.Add("@WaliKelasId", kelasSiswa.WaliKelasId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.Execute(sql, dp);
    }

    public void Update(KelasSiswaModel kelasSiswa)
    {
        const string sql = @"
            UPDATE
                KelasSiswa
            SET
                TahunAjaran = @TahunAjaran, 
                WaliKelasId = @WaliKelasId
            WHERE
                KelasId = @KelasId";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasSiswa.KelasId, DbType.Int32);
        dp.Add("@TahunAjaran", kelasSiswa.TahunAjaran, DbType.String);
        dp.Add("@WaliKelasId", kelasSiswa.WaliKelasId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.Execute(sql, dp);
    }

    public void Delete(int kelasId)
    {
        const string sql = @"
            DELETE FROM
                KelasSiswa
            WHERE
                KelasId = @KelasId";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasId, DbType.String);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.Execute(sql, dp);
    }

    public KelasSiswaModel GetData(int kelasId)
    {
        const string sql = @"
            SELECT
                aa.KelasId, aa.TahunAjaran, aa.WaliKelasId,
                ISNULL(bb.KelasName, '') KelasName,
                ISNULL(cc.GuruName, '') WaliKelasName
            FROM
                KelasSiswa aa
                LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                LEFT JOIN Guru cc ON aa.WaliKelasId = cc.GuruId
            WHERE
                aa.KelasId = @KelasId";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.Query<KelasSiswaModel>(sql, dp).FirstOrDefault();
        return result;
    }

    public IEnumerable<KelasSiswaModel> ListData()
    {
        const string sql = @"
            SELECT
                aa.KelasId, aa.TahunAjaran, aa.WaliKelasId,
                ISNULL(bb.KelasName, '') KelasId,
                ISNULL(cc.GuruName, '') WaliKelasName
            FROM
                KelasSiswa aa
                LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                LEFT JOIN Guru cc ON aa.WaliKelasId = cc.GuruId";

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.Query<KelasSiswaModel>(sql);
        return result;
    }


}
