using System;
using System.Data;
using Npgsql;
using MyBibit.Database;

namespace MyBibit.Controllers
{
    public class RestockController
    {
        public static DataTable AmbilSemuaRestock()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        r.id_restock AS id,
                        r.tanggal,
                        u.username AS karyawan,
                        COALESCE(SUM(dr.harga * dr.kuantitas), 0) AS total_restock,
                        r.status
                    FROM restock r
                    JOIN users u ON r.id_users = u.id_users
                    LEFT JOIN detail_restock dr ON r.id_restock = dr.id_restock
                    GROUP BY r.id_restock, r.tanggal, u.username, r.status
                    ORDER BY r.id_restock DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilDetailRestock(int idRestock)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        COALESCE(p.nama, 'Produk tidak ditemukan') AS produk,
                        COALESCE(p.foto, '') AS foto,
                        dr.harga,
                        dr.kuantitas,
                        (dr.harga * dr.kuantitas) AS subtotal
                    FROM detail_restock dr
                    LEFT JOIN produk p ON dr.id_produk = p.id_produk
                    WHERE dr.id_restock = @idRestock
                    ORDER BY dr.id_detail_restock ASC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@idRestock", idRestock);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilSupplier()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT
                        nama AS ""Nama"",
                        nama_perusahaan AS ""Perusahaan"",
                        alamat AS ""Alamat"",
                        no_telp AS ""No Telepon""
                    FROM supplier
                    ORDER BY id_supplier DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static void UpdateStatusRestock(int idRestock, bool status)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE restock
                    SET status = @status
                    WHERE id_restock = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idRestock);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void TambahRestockOtomatis(int idProduk, int harga, int kuantitas, string username)
        {
            int idRestock;
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        int idUsers = 0;

                        string queryUser = @"
                            SELECT id_users
                            FROM users
                            WHERE username = @username
                            LIMIT 1";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryUser, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            object result = cmd.ExecuteScalar();

                            if (result == null)
                                throw new Exception("User login tidak ditemukan.");

                            idUsers = Convert.ToInt32(result);
                        }

                        string queryRestock = @"
                            INSERT INTO restock (tanggal, id_users, id_supplier, status)
                            VALUES (
                                CURRENT_DATE,
                                @idUsers,
                                (SELECT id_supplier FROM supplier ORDER BY id_supplier ASC LIMIT 1),
                                false
                            )
                            RETURNING id_restock";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryRestock, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idUsers", idUsers);
                            idRestock = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string queryDetail = @"
                            INSERT INTO detail_restock (id_restock, id_produk, harga, kuantitas)
                            VALUES (@idRestock, @idProduk, @harga, @kuantitas)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryDetail, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@idRestock", idRestock);
                            cmd.Parameters.AddWithValue("@idProduk", idProduk);
                            cmd.Parameters.AddWithValue("@harga", harga);
                            cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}