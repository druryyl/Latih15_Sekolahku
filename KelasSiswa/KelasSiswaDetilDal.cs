using Dapper;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.KelasSiswa;

public class KelasSiswaDetilDal
{
    public void Insert(KelasSiswaDetilModel detil)
    {
        const string sql = @"
            INSERT INTO KelasSiswaDetil(KelasId, SiswaId)
            VALUES(@KelasId, @SiswaId)";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", detil.KelasId, DbType.String);
        dp.Add("@SiswaId", detil.SiswaId, DbType.String);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        conn.Execute(sql, dp);
    }

    public void Delete(int kelasId)
    {
        const string sql = @"
            DELETE FROM KelasSiswaDetil
            WHERE KelasId = @KelasId";

        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasId, DbType.String);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        conn.Execute(sql, dp);
    }

    public IEnumerable<KelasSiswaModel> ListData(int kelasId)
    {
        const string sql = @"
            SELECT 
                aa.KelasId, aa.SiswaId, 
                ISNULL(bb.SiswaName, '') SiswaName
            FROM 
                KelasSiswaDetil aa
                LEFT JOIN Siswa bb ON aa.SiswaId = bb.SiswaId)
            WHERE 
                KelasId = @KelasId";
        
        var dp = new DynamicParameters();
        dp.Add("@KelasId", kelasId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        return conn.Query<KelasSiswaModel>(sql, dp);
    }
}
