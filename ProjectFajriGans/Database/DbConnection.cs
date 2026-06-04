using Npgsql;

namespace ProjectFajriGans.Database
{
    public class DbConnection
    {
        private static string connString =
            "Host=localhost;Port=5432;Username=postgres;Password=Mandigo86;Database=BijiFajri";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}