using System.Data;
using Npgsql;
using ProjectFajriGans.Database;

namespace ProjectFajriGans.Controllers
{
    public class ProdukController
    {
        public static DataTable AmbilSemuaProduk()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.id,
                        p.nama,
                        k.nama AS kategori,
                        p.harga,
                        p.kuantitas,
                        p.tinggi,
                        p.umur,
                        p.foto
                    FROM produk p
                    JOIN kategori k ON p.id_kategori = k.id
                    WHERE p.is_deleted = FALSE
                    ORDER BY p.id";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static void KurangiStok(int idProduk, int jumlah)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE produk
                    SET kuantitas = kuantitas - @jumlah
                    WHERE id = @idProduk";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@idProduk", idProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void HapusProduk(int idProduk)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE produk
                    SET is_deleted = TRUE
                    WHERE id = @idProduk";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProduk", idProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}