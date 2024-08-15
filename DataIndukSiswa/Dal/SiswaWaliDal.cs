using Dapper;
using Latih15_Sekolahku.DataIndukSiswa.Models;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.DataIndukSiswa.Dal
{
    public class SiswaWaliDal
    {
        public void Insert(IEnumerable<SiswaWaliModel> listWali)
        {
            const string sql = @"
                INSERT INTO SiswaWali(
                    SiswaId, JenisWali, NamaLengkap, TempatLahir,
                    TglLahir, Kewarganegaraan, Pendidikan,
                    Pekerjaan, Penghasilan, Nik, NoKk)
                VALUES(
                    @SiswaId, @JenisWali, @NamaLengkap, @TempatLahir,
                    @TglLahir, @Kewarganegaraan, @Pendidikan,
                    @Pekerjaan, @Penghasilan, @Nik, @NoKk)";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            foreach (var item in listWali)
            {
                var dp = new DynamicParameters();
                dp.Add("@SiswaId", item.SiswaId, System.Data.DbType.Int32);
                dp.Add("@JenisWali", item.JenisWali, DbType.Int16);
                dp.Add("@NamaLengkap", item.NamaLengkap, DbType.String);
                dp.Add("@TempatLahir", item.TempatLahir, DbType.String);
                dp.Add("@TglLahir", item.TglLahir, DbType.DateTime);
                dp.Add("@Kewarganegaraan", item.Kewarganegaraan, DbType.String); 
                dp.Add("@Pendidikan", item.Pendidikan, DbType.String);
                dp.Add("@Pekerjaan", item.Pekerjaan, DbType.String); 
                dp.Add("@Penghasilan", item.Penghasilan, DbType.Decimal); 
                dp.Add("@Nik", item.Nik, DbType.String); 
                dp.Add("@NoKk", item.NoKk, DbType.String);
                conn.Execute(sql, dp);
            }
        }

        public void Delete(int siswaId)
        {
            const string sql = @"
                DELETE FROM
                    SiswaWali
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int32);
            
            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public IEnumerable<SiswaWaliModel> ListData(int siswaId)
        {
            const string sql = @"
                SELECT
                    SiswaId, JenisWali, NamaLengkap, TempatLahir,
                    TglLahir, Kewarganegaraan, Pendidikan,
                    Pekerjaan, Penghasilan, Nik, NoKk
                FROM
                    SiswaWali
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int32);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<SiswaWaliModel>(sql, dp);
        }
    }
}
