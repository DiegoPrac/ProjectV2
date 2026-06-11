using System;
using System.Data;
using Npgsql;
using MyBibit.Database;

namespace MyBibit.Controllers
{
    public class OrderController
    {
        public static DataTable AmbilSemuaOrderAdmin()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        o.id_order AS id,
                        o.tanggal AS ""Tanggal"",
                        u.username AS ""Customer"",
                        COALESCE(SUM(d.subtotal), 0) AS ""Total Order"",
                        CASE 
                            WHEN o.status = true THEN 'Selesai'
                            ELSE 'Diproses'
                        END AS ""Status""
                    FROM orders o
                    JOIN users u ON o.id_users = u.id_users
                    LEFT JOIN detail_order d ON o.id_order = d.id_order
                    GROUP BY o.id_order, o.tanggal, u.username, o.status
                    ORDER BY o.id_order DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilPenjualanPerBulan()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT 
                EXTRACT(MONTH FROM o.tanggal) AS bulan,
                COALESCE(SUM(d.subtotal), 0) AS total
            FROM orders o
            JOIN detail_order d ON o.id_order = d.id_order
            WHERE EXTRACT(YEAR FROM o.tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)
            AND o.status = true
            GROUP BY EXTRACT(MONTH FROM o.tanggal)
            ORDER BY bulan";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilSemuaOrder()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        o.id_order AS id,
                        o.tanggal,
                        u.username AS customer,
                        COALESCE(SUM(d.subtotal), 0) AS total_order,
                        o.status
                    FROM orders o
                    JOIN users u ON o.id_users = u.id_users
                    LEFT JOIN detail_order d ON o.id_order = d.id_order
                    GROUP BY o.id_order, o.tanggal, u.username, o.status
                    ORDER BY o.id_order DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable AmbilDetailOrder(int idOrder)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.nama AS produk,
                        p.foto,
                        d.harga,
                        d.kuantitas,
                        d.subtotal
                    FROM detail_order d
                    JOIN produk p ON d.id_produk = p.id_produk
                    WHERE d.id_order = @idOrder";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@idOrder", idOrder);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static int AmbilTotalPenjualanBulanIni()
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT COALESCE(SUM(d.subtotal), 0)
                    FROM orders o
                    JOIN detail_order d ON o.id_order = d.id_order
                    WHERE EXTRACT(MONTH FROM o.tanggal) = EXTRACT(MONTH FROM CURRENT_DATE)
                    AND EXTRACT(YEAR FROM o.tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)
                    AND o.status = true";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static void UpdateStatusOrder(int idOrder, bool status)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    UPDATE orders
                    SET status = @status
                    WHERE id_order = @idOrder";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idOrder", idOrder);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}