using Dapper;
using Latih15_Sekolahku.Helpers;
using Latih15_Sekolahku.JadwalMapel;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.TimeslotMapel
{
    public class TimeslotMapelDal
    {
        public int Insert(TimeslotMapelModel timeslot)
        {
            const string sql = @"
                INSERT INTO TimeslotMapel(
                    KelasId, Hari, JenisJadwal, JamMulai, JamSelesai,
                    MapelId, GuruId, Keterangan)
                OUTPUT INSERTED.TimeslotMapelId
                VALUES(
                    @KelasId, @Hari, @JenisJadwal, @JamMulai, @JamSelesai,
                    @MapelId, @GuruId, @Keterangan)";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", timeslot.KelasId, DbType.Int16);
            dp.Add("@Hari", timeslot.Hari, DbType.String);
            dp.Add("@JenisJadwal", timeslot.JenisJadwal, DbType.String);
            dp.Add("@JamMulai", timeslot.JamMulai, DbType.String);
            dp.Add("@JamSelesai", timeslot.JamSelesai, DbType.String);
            dp.Add("@MapelId", timeslot.MapelId, DbType.Int16);
            dp.Add("@GuruId", timeslot.GuruId, DbType.Int16);
            dp.Add("@Keterangan", timeslot.Keterangan, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, dp);
            return result;
        }

        public void Update(TimeslotMapelModel timeslot)
        {
            const string sql = @"
                UPDATE TimeslotMapel    
                SET 
                    KelasId = @KelasId,
                    Hari = @Hari,
                    JenisJadwal = @JenisJadwal,
                    JamMulai = @JamMulai,
                    JamSelesai = @JamSelesai,
                    MapelId = @MapelId,
                    GuruId = @GuruId
                WHERE TimeslotMapelId = @TimeslotMapelId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", timeslot.KelasId, DbType.Int16);
            dp.Add("@Hari", timeslot.Hari, DbType.String);
            dp.Add("@JenisJadwal", timeslot.JenisJadwal, DbType.String);
            dp.Add("@JamMulai", timeslot.JamMulai, DbType.String);
            dp.Add("@JamSelesai", timeslot.JamSelesai, DbType.String);
            dp.Add("@MapelId", timeslot.MapelId, DbType.Int16);
            dp.Add("@GuruId", timeslot.GuruId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int id)
        {
            const string sql = @"
                DELETE FROM TimeslotMapel   
                WHERE TimeslotMapelId = @TimeslotMapelId";

            var dp = new DynamicParameters();
            dp.Add("@TimeslotMapelId", id, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public TimeslotMapelModel GetData(int id)
        {
            const string sql = @"
                SELECT 
                    aa.TimeslotMapelId, aa.KelasId, aa.Hari, aa.JenisJadwal, 
                    aa.JamMulai, aa.JamSelesai,
                    aa.MapelId, aa.GuruId, aa.Keterangan,
                    ISNULL(bb.KelasName, '') AS KelasName,
                    ISNULL(cc.MapelName, '') AS MapelName,  
                    ISNULL(dd.GuruName, '') AS GuruName
                FROM TimeslotMapel aa
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Mapel cc ON aa.MapelId = cc.MapelId       
                    LEFT JOIN Guru dd ON aa.GuruId = dd.GuruId
                WHERE 
                    aa.TimeslotMapelId = @TimeslotMapelId";

            var dp = new DynamicParameters();
            dp.Add("@TimeslotMapelId", id, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.QuerySingle<TimeslotMapelModel>(sql, dp);
        }

        public IEnumerable<TimeslotMapelModel> ListData(int kelasId)
        {
            const string sql = @"
                SELECT 
                    aa.TimeslotMapelId, aa.KelasId, aa.Hari, aa.JenisJadwal, 
                    aa.JamMulai, aa.JamSelesai,
                    aa.MapelId, aa.GuruId, aa.Keterangan,
                    ISNULL(bb.KelasName, '') AS KelasName,
                    ISNULL(cc.MapelName, '') AS MapelName,  
                    ISNULL(dd.GuruName, '') AS GuruName
                FROM TimeslotMapel aa
                    LEFT JOIN Kelas bb ON aa.KelasId = bb.KelasId
                    LEFT JOIN Mapel cc ON aa.MapelId = cc.MapelId       
                    LEFT JOIN Guru dd ON aa.GuruId = dd.GuruId
                WHERE 
                    aa.KelasId= @KelasId";

            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelasId, DbType.Int16);
            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<TimeslotMapelModel>(sql, dp);
        }
    }
}
