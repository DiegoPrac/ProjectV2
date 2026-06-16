using System;
using System.Data;
using Npgsql;
using MyBibit.Database;
using MyBibit.Models;

namespace MyBibit.Controllers
{
    public class UserController
    {
        public static bool UsernameSudahAda(string username)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static void Register(User user)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

                string query = @"
                    INSERT INTO users
                    (username, passwords, alamat, no_telp, tanggal_lahir, id_roles, status)
                    VALUES
                    (@username, @passwords, @alamat, @no_telp, @tanggal_lahir, 3, TRUE)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@passwords", hashedPassword);
                    cmd.Parameters.AddWithValue("@alamat", user.Alamat);
                    cmd.Parameters.AddWithValue("@no_telp", user.NoTelepon);
                    cmd.Parameters.AddWithValue("@tanggal_lahir", user.TanggalLahir);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool Login(string username, string password)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT passwords
                    FROM users
                    WHERE username = @username
                    AND status = TRUE";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    if (result == null) return false;

                    return BCrypt.Net.BCrypt.Verify(password, result.ToString());
                }
            }
        }

        public static string GetRole(string username)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT r.nama
                    FROM users u
                    JOIN roles r ON u.id_roles = r.id_roles
                    WHERE u.username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    return result == null ? "" : result.ToString();
                }
            }
        }

        public static DataTable AmbilKaryawan()
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        id_users AS id,
                        username AS ""Username"",
                        alamat AS ""Alamat"",
                        no_telp AS ""No Telepon"",
                        CASE 
                            WHEN status = TRUE THEN 'Aktif'
                            ELSE 'Non Aktif'
                        END AS ""Status""
                    FROM users
                    WHERE id_roles = 2
                    ORDER BY id_users DESC";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static void TambahKaryawan(string username, string password, string alamat, string noTelp)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                string query = @"
            INSERT INTO users
            (username, passwords, alamat, no_telp, tanggal_lahir, id_roles, status)
            VALUES
            (@username, @passwords, @alamat, @no_telp, CURRENT_DATE, 2, TRUE)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@passwords", hashedPassword);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@no_telp", noTelp);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EditKaryawan(int id, string username, string passwordBaru, string alamat, string noTelp)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query;

                if (passwordBaru == "")
                {
                    query = @"
                UPDATE users
                SET username = @username,
                    alamat = @alamat,
                    no_telp = @no_telp
                WHERE id_users = @id";
                }
                else
                {
                    query = @"
                UPDATE users
                SET username = @username,
                    passwords = @passwords,
                    alamat = @alamat,
                    no_telp = @no_telp
                WHERE id_users = @id";
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@no_telp", noTelp);

                    if (passwordBaru != "")
                        cmd.Parameters.AddWithValue("@passwords", BCrypt.Net.BCrypt.HashPassword(passwordBaru));

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateStatusKaryawan(int id, bool status)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "UPDATE users SET status = @status WHERE id_users = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void HapusKaryawan(int id)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM users WHERE id_users = @id AND id_roles = 2";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}