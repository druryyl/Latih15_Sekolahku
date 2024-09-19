using Dapper;
using Latih15_Sekolahku.Helpers;
using Latih15_Sekolahku.MataPelajaran;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih15_Sekolahku.Mapel
{
    public class MapelDal
    {
        public int Insert(MapelModel mapel)
        {
            const string sql = @"
                INSERT INTO Mapel(MapelName)
                OUTPUT INSERTED.MapelId
                VALUES(@MapelName)";

            var dp = new DynamicParameters();
            dp.Add(@"MapelName", mapel.MapelName, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            var result = conn.QuerySingle<int>(sql, dp);
            return result;
        }

        public void Update(MapelModel mapel)
        {
            const string sql = @"
                UPDATE Mapel
                SET MapelName = @MapelName
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.Add("@MapelId", mapel.MapelId, DbType.Int16);
            dp.Add("@MapelName", mapel.MapelName, DbType.String);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public void Delete(int mapelId)
        {
            const string sql = @"
                DELETE Mapel
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.Add("@MapelId", mapelId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            conn.Execute(sql, dp);
        }

        public MapelModel GetData(int mapelId)
        {
            const string sql = @"
                SELECT MapelId, MapelName
                FROM Mapel
                WHERE MapelId = @MapelId";

            var dp = new DynamicParameters();
            dp.Add("@MapelId", mapelId, DbType.Int16);

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<MapelModel>(sql, dp).FirstOrDefault(); 
        }

        public IEnumerable<MapelModel>  ListData()
        {
            const string sql = @"
                SELECT MapelId, MapelName
                FROM Mapel ";

            using var conn = new SqlConnection(ConnStringHelper.Get());
            return conn.Query<MapelModel>(sql);
        }
    }
}
