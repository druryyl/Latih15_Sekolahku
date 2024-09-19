using Dapper;
using Latih15_Sekolahku.DataIndukSiswa.Models;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;

namespace Latih15_Sekolahku.DataIndukSiswa.Dal
{
    public class SiswaBeasiswaDal
    {
        public void Insert(IEnumerable<SiswaBeasiswaModel> listBeasiswa)
        {
            const string sql = @"
                INSERT INTO SiswaBeasiswa
                    (SiswaId, NoUrut, Tahun, Kelas, PenyediaBeasiswa)
                VALUES
                    (@SiswaId, @NoUrut, @Tahun, @Kelas, @PenyediaBeasiswa)";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            foreach (var item in listBeasiswa)
            {
                var dp = new DynamicParameters();
                dp.Add("@SiswaId", item.SiswaId);
                dp.Add("@NoUrut", item.NoUrut);
                dp.Add("@Tahun", item.Tahun);
                dp.Add("@Kelas", item.Kelas);
                dp.Add("@PenyediaBeasiswa", item.PenyediaBeasiswa);

                conn.Execute(sql, dp);
            }
        }

        public void Delete(int siswaId)
        {
            const string sql = @"
                DELETE FROM 
                    SiswaBeasiswa
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public IEnumerable<SiswaBeasiswaModel> ListData(int siswaId)
        {
            const string sql = @"
                SELECT
                    SiswaId, NoUrut, Tahun, Kelas, PenyediaBeasiswa
                FROM
                    SiswaBeasiswa
                WHERE 
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, System.Data.DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<SiswaBeasiswaModel>(sql, dp);
        }

    }
}
