using System;
using System.Collections.Generic;
using Npgsql;
using MyBibit.Database;

namespace MyBibit.Controllers
{
    public class TransaksiController
    {
        public static bool SimpanTransaksi(Dictionary<int, int> keranjang)
        {
            try
            {
                using (NpgsqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    using (var trx = conn.BeginTransaction())
                    {
                        string orderQuery = @"
                            INSERT INTO orders (tanggal, status, id_users)
                            SELECT CURRENT_DATE, FALSE, id_users
                            FROM users
                            WHERE username = @username
                            RETURNING id_order";

                        int idOrder;

                        using (NpgsqlCommand cmd = new NpgsqlCommand(orderQuery, conn))
                        {
                            cmd.Transaction = trx;
                            cmd.Parameters.AddWithValue("@username", Session.Username);
                            idOrder = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        foreach (var item in keranjang)
                            SimpanDetail(conn, trx, idOrder, item.Key, item.Value);

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

        private static void SimpanDetail(NpgsqlConnection conn, NpgsqlTransaction trx, int idOrder, int idProduk, int qty)
        {
            if (qty <= 0) return;

            string query = @"
                INSERT INTO detail_order (id_order, id_produk, harga, kuantitas, subtotal)
                SELECT @id_order, id_produk, harga, @kuantitas, harga * @kuantitas
                FROM produk
                WHERE id_produk = @id_produk";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Transaction = trx;
                cmd.Parameters.AddWithValue("@id_order", idOrder);
                cmd.Parameters.AddWithValue("@id_produk", idProduk);
                cmd.Parameters.AddWithValue("@kuantitas", qty);
                cmd.ExecuteNonQuery();
            }
        }
    }
}