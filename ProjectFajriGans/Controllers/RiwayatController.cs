using System;
using System.Data;
using Npgsql;
using ProjectFajriGans.Database;

namespace ProjectFajriGans.Controllers
{
    public class RiwayatController
    {
        public static DataTable AmbilRiwayat(DateTime awal, DateTime akhir)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.foto AS FotoFile,
                        o.tanggal AS Tanggal,
                        p.nama AS Produk,
                        d.harga AS Harga,
                        d.kuantitas AS Qty,
                        (d.harga * d.kuantitas) AS Total,
                        CASE 
                            WHEN o.status = TRUE THEN 'Selesai'
                            ELSE 'Proses'
                        END AS Status
                    FROM orders o
                    JOIN detail_order d ON o.id = d.id_order
                    JOIN produk p ON d.id_produk = p.id
                    WHERE o.tanggal BETWEEN @awal AND @akhir
                    ORDER BY o.tanggal DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@awal", awal.Date);
                    da.SelectCommand.Parameters.AddWithValue("@akhir", akhir.Date);
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}