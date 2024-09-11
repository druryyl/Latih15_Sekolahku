using Dapper;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.Kelas
{
    public class KelasDal
    {
        public int Insert(KelasModel kelas)
        {
            const string sql = @"
                INSERT INTO Kelas(KelasName, Tingkat, JurusanId, Flag)
                OUTPUT INSERTED.KelasId
                VALUES (@KelasName, @Tingkat, @JurusanId, @Flag)";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelas.KelasId, DbType.Int16);
            dp.Add("@KelasName", kelas.KelasName, DbType.String);
            dp.Add("@Tingkat", kelas.Tingkat, DbType.Int16);
            dp.Add("@JurusanId", kelas.JurusanId, DbType.String);
            dp.Add("@Flag", kelas.Flag, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, dp);
            return result;
        }

        public void Update(KelasModel kelas)
        {
            const string sql = @"
                UPDATE Kelas
                SET KelasName = @KelasName, 
                    Tingkat = @Tingkat,
                    JurusanId = @JurusanId,
                    Flag = @Flag
                WHERE KelasId = @KelasId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelas.KelasId, DbType.Int16);
            dp.Add("@KelasName", kelas.KelasName, DbType.String);
            dp.Add("@Tingkat", kelas.Tingkat, DbType.Int16);
            dp.Add("@JurusanId", kelas.JurusanId, DbType.String);
            dp.Add("@Flag", kelas.Flag, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int kelasId)
        {
            const string sql = @"
                DELETE FROM Kelas
                WHERE KelasId = @KelasId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelasId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public KelasModel? GetData(int kelasId)
        {
            const string sql = @"
                SELECT 
                    aa.KelasId, aa.KelasName, aa.Tingkat, aa.JurusanId, aa.Flag,
                    ISNULL(bb.JurusanName, '') AS JurusanName,
                    ISNULL(bb.Code, '') AS Code
                FROM 
                    Kelas aa
                    LEFT JOIN Jurusan bb ON aa.JurusanId = bb.JurusanId
                WHERE 
                    aa.KelasId = @KelasId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelasId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.QuerySingle<KelasModel>(sql, dp);
        }

        public IEnumerable<KelasModel> ListData()
        {
            const string sql = @"
                SELECT 
                    aa.KelasId, aa.KelasName, aa.Tingkat, aa.JurusanId, aa.Flag,
                    ISNULL(bb.JurusanName, '') AS JurusanName,
                    ISNULL(bb.Code, '') AS Code
                FROM 
                    Kelas aa
                    LEFT JOIN Jurusan bb ON aa.JurusanId = bb.JurusanId ";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<KelasModel>(sql);
        }


    }
}
