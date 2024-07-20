using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Capstone
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "workouts.db");
        private static string connectionString = $"Data Source={dbPath}";

        static DatabaseHelper()
        {
            if (!File.Exists(dbPath))
            {
                InitializeDatabase();
            }
        }

        private static void InitializeDatabase()
        {
            // create Workouts table if it does not exist
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();
                string createWorkoutsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Workouts (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    WorkoutName TEXT NOT NULL,
                    Weight INTEGER NOT NULL,
                    Sets INTEGER NOT NULL,
                    Reps INTEGER NOT NULL,
                    Date TEXT NOT NULL
                );";
                using (var cmd = new SqliteCommand(createWorkoutsTableQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Create Users table if it does not exist
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();
                string createUsersTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    Email TEXT
                );";
                using (var cmd = new SqliteCommand(createUsersTableQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertWorkout(string username, string workoutName, int weight, int sets, int reps)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Workouts (Username, WorkoutName, Weight, Sets, Reps, Date) VALUES (@Username, @WorkoutName, @Weight, @Sets, @Reps, @Date)";
                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@WorkoutName", workoutName);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Sets", sets);
                    cmd.Parameters.AddWithValue("@Reps", reps);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static SqliteDataReader GetWorkoutsByDateAndUser(string username, string date)
        {
            var con = new SqliteConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Workouts WHERE Date = @Date AND Username = @Username";
            var cmd = new SqliteCommand(query, con);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Username", username);
            return cmd.ExecuteReader();
        }

        public static void CreateUser(string username, string password, string email)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Users (Username, PasswordHash, Email) VALUES (@Username, @PasswordHash, @Email)";
                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool VerifyUser(string username, string password)
        {
            using (var con = new SqliteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                using (var cmd = new SqliteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(0);
                            return VerifyPassword(password, storedHash);
                        }
                    }
                }
            }
            return false;
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            string hashOfInput = HashPassword(password);
            return string.Equals(hashOfInput, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}