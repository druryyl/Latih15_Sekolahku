using Dapper;
using Latih15_Sekolahku.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Latih15_Sekolahku.Guru;

public class GuruDal
{
    public int Insert(GuruModel model)
    {
        const string sql = @"
            INSERT INTO Guru(
                GuruName, TglLahir, JurusanPendidikan, 
                TingkatPendidikan, TahunLulus, InstansiPendidikan, 
                KotaPendidikan)
            OUTPUT inserted.GuruID
            VALUES(
                @GuruName, @TglLahir, @JurusanPendidikan, 
                @TingkatPendidikan, @TahunLulus, @InstansiPendidikan, 
                @KotaPendidikan";

        var dp = new DynamicParameters();
        dp.Add("@GuruName", model.GuruName, DbType.String); 
        dp.Add("@TglLahir", model.TglLahir, DbType.DateTime); 
        dp.Add("@JurusanPendidikan", model.JurusanPendidikan, DbType.String); 
        dp.Add("@TingkatPendidikan", model.TingkatPendidikan, DbType.String); 
        dp.Add("@TahunLulus", model.TahunLulus, DbType.String); 
        dp.Add("@InstansiPendidikan", model.InstansiPendidikan, DbType.String); 
        dp.Add("@KotaPendidikan", model.KotaPendidikan, DbType.String);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        var result = conn.QuerySingle<int>(sql, dp);
        return result;
    }

    public void Update(GuruModel model)
    {
        const string sql = @"
            UPDATE GURU
            SET
                GuruName = @GuruName,
                TglLahir  = @TglLahir,
                JurusanPendidikan = @JurusanPendidikan,
                TingkatPendidikan  = @TingkatPendidikan,
                TahunLulus = @TahunLulus,
                InstansiPendidikan = @InstansiPendidikan,
                KotaPendidikan = @KotaPendidikan
            WHERE
                GuruId = @GuruId ";

        var dp = new DynamicParameters();
        dp.Add("@GuruName", model.GuruName, DbType.String);
        dp.Add("@TglLahir", model.TglLahir, DbType.DateTime);
        dp.Add("@JurusanPendidikan", model.JurusanPendidikan, DbType.String);
        dp.Add("@TingkatPendidikan", model.TingkatPendidikan, DbType.String);
        dp.Add("@TahunLulus", model.TahunLulus, DbType.String);
        dp.Add("@InstansiPendidikan", model.InstansiPendidikan, DbType.String);
        dp.Add("@KotaPendidikan", model.KotaPendidikan, DbType.String);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        conn.Execute(sql, dp);
    }

    public void Delete(int guruId)
    {
        const string sql = @"
            DELETE FROM Guru
            WHERE GuruId @GuruId";
        
        var dp = new DynamicParameters();
        dp.Add("@GuruId", guruId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        conn.Execute(sql, dp);
    }

    public GuruModel GetData(int guruId)
    {
        const string sql = @"
            SELECT
                GuruId, GuruName, TglLahir,
                JurusanPendidikan, TingkatPendidikan, TahunLulus,
                InstansiPendidikan, KotaPendidikan
            FROM
                Guru
            WHERE
                GuruId = @GuruId";

        var dp = new DynamicParameters();
        dp.Add("@GuruId", guruId, DbType.Int32);

        using var conn = new SqlConnection(ConnStringHelper.Get());
        return conn.QuerySingle<GuruModel>(sql, dp);
    }

    public GuruModel ListData(int guruId)
    {
        const string sql = @"
            SELECT
                GuruId, GuruName, TglLahir,
                JurusanPendidikan, TingkatPendidikan, TahunLulus,
                InstansiPendidikan, KotaPendidikan
            FROM
                Guru ";

        using var conn = new SqlConnection(ConnStringHelper.Get());
        return conn.QuerySingle<GuruModel>(sql);
    }

}
