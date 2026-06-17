using System.Collections.Generic;
using Npgsql;
using MyBibit.Database;

namespace MyBibit.Controllers
{
    public class BibitController
    {
        public static Dictionary<string, int> AmbilSemuaStok()
        {
            Dictionary<string, int> stok = new Dictionary<string, int>();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT nama, stok FROM bibit";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stok[reader.GetString(0)] = reader.GetInt32(1);
                    }
                }
            }

            return stok;
        }

        public static void KurangiStok(string namaBibit, int jumlah)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE bibit
                    SET stok = stok - @jumlah
                    WHERE nama = @namaBibit";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@namaBibit", namaBibit);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}