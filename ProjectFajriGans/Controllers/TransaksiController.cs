using Npgsql;
using ProjectFajriGans.Database;

namespace ProjectFajriGans.Controllers
{
    public class TransaksiController
    {
        public static bool SimpanTransaksi(int totalItem, int totalHarga)
        {
            try
            {
                using (NpgsqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO transaksi 
                        (total_item, total_harga)
                        VALUES 
                        (@total_item, @total_harga)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@total_item", totalItem);
                        cmd.Parameters.AddWithValue("@total_harga", totalHarga);
                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}