using System;
using Npgsql;
using ProjectFajriGans.Database;
using ProjectFajriGans.Models;

namespace ProjectFajriGans.Controllers
{
    public class UserController
    {
        public static void Register(User user)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

                string query = @"
                    INSERT INTO users
                    (username, password, alamat, no_telepon, tanggal_lahir)
                    VALUES
                    (@username, @password, @alamat, @no_telepon, @tanggal_lahir)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@alamat", user.Alamat);
                    cmd.Parameters.AddWithValue("@no_telepon", user.NoTelepon);
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
                    SELECT password
                    FROM users
                    WHERE username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return false;

                    string hashedPassword = result.ToString();

                    return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                }
            }
        }

        public static string GetRole(string username)
        {
            using (NpgsqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT role
            FROM users
            WHERE username = @username";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return "";

                    return result.ToString();
                }
            }
        }

    }
}