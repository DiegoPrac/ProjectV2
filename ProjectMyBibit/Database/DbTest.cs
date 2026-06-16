using Npgsql;

namespace MyBibit.Database
{
    public class DbTest
    {
        public static bool TestConnection()
        {
            try
            {
                using (NpgsqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}