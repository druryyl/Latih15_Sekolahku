using Dapper;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.Jurusan
{
    public class JurusanDal
    {
        public int Insert(JurusanModel jurusan)
        {
            const string sql = @"
                INSERT INTO Jurusan(JurusanName, Code)
                OUTPUT INSERTED.JurusanId
                VALUES (@JurusanName, @Code)";

            var dp = new DynamicParameters();
            dp.Add("@JurusanId", jurusan.JurusanId, DbType.Int16);
            dp.Add("@JurusanName", jurusan.JurusanName, DbType.String);
            dp.Add("@Code", jurusan.Code, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, dp);
            return result;
        }

        public void Update(JurusanModel jurusan)
        {
            const string sql = @"
                UPDATE Jurusan
                SET JurusanName = @JurusanName, 
                    Code = @Code
                WHERE JurusanId = @JurusanId";

            var dp = new DynamicParameters();
            dp.Add("@JurusanId", jurusan.JurusanId, DbType.Int16);
            dp.Add("@JurusanName", jurusan.JurusanName, DbType.String);
            dp.Add("@Code", jurusan.Code, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int jurusanId)
        {
            const string sql = @"
                DELETE FROM Jurusan
                WHERE JurusanId = @JurusanId";

            var dp = new DynamicParameters();
            dp.Add("@JurusanId", jurusanId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public JurusanModel? GetData(int jurusanId)
        {
            const string sql = @"
                SELECT JurusanId, JurusanName, Code
                FROM Jurusan
                WHERE JurusanId = @JurusanId";

            var dp = new DynamicParameters();
            dp.Add("@JurusanId", jurusanId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.QuerySingle<JurusanModel>(sql, dp);
        }

        public IEnumerable<JurusanModel> ListData()
        {
            const string sql = @"
                SELECT JurusanId, JurusanName, Code
                FROM Jurusan";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<JurusanModel>(sql);
        }


    }
}
