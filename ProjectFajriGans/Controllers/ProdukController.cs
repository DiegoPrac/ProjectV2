using System;
using System.Data;
using Npgsql;
using MyBibit.Database;

namespace MyBibit.Controllers
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
                        p.id_produk AS id,
                        p.nama,
                        k.nama AS kategori,
                        p.harga,
                        p.kuantitas,
                        p.tinggi,
                        p.umur,
                        p.tanggal_expired,
                        p.foto,
                        p.id_kategori
                    FROM produk p
                    JOIN kategori k ON p.id_kategori = k.id_kategori
                    WHERE p.is_deleted = FALSE
                    ORDER BY p.id_produk";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilProdukById(int idProduk)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT *
                    FROM produk
                    WHERE id_produk = @idProduk";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@idProduk", idProduk);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static void TambahProduk(string nama, int harga, int stok, string foto, int idKategori, DateTime expired)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    INSERT INTO produk
                    (nama, harga, kuantitas, foto, id_kategori, tanggal_expired, is_deleted)
                    VALUES
                    (@nama, @harga, @stok, @foto, @idKategori, @expired, FALSE)";


                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@foto", foto);
                    cmd.Parameters.AddWithValue("@idKategori", idKategori);
                    cmd.Parameters.AddWithValue("@expired", expired.Date);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProduk(int idProduk, string nama, int harga, int stok, string foto, int idKategori, DateTime expired)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE produk
                    SET nama = @nama,
                        harga = @harga,
                        kuantitas = @stok,
                        foto = @foto,
                        id_kategori = @idKategori,
                        tanggal_expired = @expired
                    WHERE id_produk = @idProduk";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProduk", idProduk);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@foto", foto);
                    cmd.Parameters.AddWithValue("@idKategori", idKategori);
                    cmd.Parameters.AddWithValue("@expired", expired.Date);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void KurangiStok(int idProduk, int jumlah)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE produk
                    SET kuantitas = kuantitas - @jumlah
                    WHERE id_produk = @idProduk";

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
                    WHERE id_produk = @idProduk";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProduk", idProduk);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}