using System;
using Npgsql;
using ProjectFajriGans.Database;

namespace ProjectFajriGans.Controllers
{
    public class TransaksiController
    {
        public static bool SimpanTransaksi(
            int mangga, int cabai, int jambu,
            int jeruk, int alpukat, int rambutan)
        {
            try
            {
                using (NpgsqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    using (var trx = conn.BeginTransaction())
                    {
                        string orderQuery = @"
                            INSERT INTO orders (tanggal, status, username)
                            VALUES (CURRENT_DATE, TRUE, 'customer')
                            RETURNING id";

                        int idOrder;

                        using (NpgsqlCommand cmd = new NpgsqlCommand(orderQuery, conn))
                        {
                            cmd.Transaction = trx;
                            idOrder = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        SimpanDetail(conn, trx, idOrder, 1, 15000, mangga);
                        SimpanDetail(conn, trx, idOrder, 2, 8000, cabai);
                        SimpanDetail(conn, trx, idOrder, 3, 12000, jambu);
                        SimpanDetail(conn, trx, idOrder, 4, 10000, jeruk);
                        SimpanDetail(conn, trx, idOrder, 5, 20000, alpukat);
                        SimpanDetail(conn, trx, idOrder, 6, 13000, rambutan);

                        trx.Commit();
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void SimpanDetail(NpgsqlConnection conn, NpgsqlTransaction trx, int idOrder, int idProduk, int harga, int qty)
        {
            if (qty <= 0) return;

            string query = @"
                INSERT INTO detail_order (id_order, id_produk, harga, kuantitas)
                VALUES (@id_order, @id_produk, @harga, @kuantitas)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Transaction = trx;
                cmd.Parameters.AddWithValue("@id_order", idOrder);
                cmd.Parameters.AddWithValue("@id_produk", idProduk);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@kuantitas", qty);
                cmd.ExecuteNonQuery();
            }
        }
    }
}