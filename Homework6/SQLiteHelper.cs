using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

namespace Homework6
{
    public class SQLiteHelper
    {
        private static string connectionString = string.Empty;


        public static void SetConnection(string dataSource)
        {
            connectionString = $"Data Source={dataSource};Version=3;";
            if (!File.Exists(dataSource)) CreateDB(dataSource);
        }

        public static void CreateDB(string dbName)
        {
            if (!string.IsNullOrEmpty(dbName))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbName);
                    ExecuteNonQuery("CREATE TABLE college (CollegeId INT PRIMARY KEY, Name VARCHAR)");
                    ExecuteNonQuery("CREATE TABLE class (ClassId INT PRIMARY KEY, Name VARCHAR, CollegeId INT, FOREIGN KEY (CollegeId) REFERENCES college(CollegeId))");
                    ExecuteNonQuery("CREATE TABLE student (StuId INT, Name VARCHAR, CollegeId INT, ClassId INT, Sex INT,PRIMARY KEY(StuId, CollegeId), FOREIGN KEY (CollegeId) REFERENCES college(CollegeId), FOREIGN KEY (ClassId) REFERENCES class(ClassId))");
                    ExecuteNonQuery("CREATE TABLE sqlitelog (Timestamp INT PRIMARY KEY, Command VARCHAR)");
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    throw;
                }
            }
        }

        public static int ExecuteNonQuery(string sqlCommand, params SQLiteParameter[] parameters)
        {
            int affectedRows = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                        //command.CommandText = sqlCommand;
                        if (parameters.Length != 0)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        affectedRows = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
            return affectedRows;
        }

        public static object ExecuteScalar(string sqlCommand, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sqlCommand, conn))
                {
                    try
                    {
                        conn.Open();
                        if (parameters.Length != 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteScalar();
                    }
                    catch (Exception) { throw; }
                }
            }
        }

        public static int ExecuteCount(string sqlCommand, params SQLiteParameter[] parameters)
        {
            return Convert.ToInt32(ExecuteScalar(sqlCommand, parameters));
        }

        public static DataTable ExecuteQuery(string sqlCommand, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
                {
                    if (parameters.Length != 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable data = new DataTable();
                    try
                    {
                        adapter.Fill(data);
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    return data;
                }
            }
        }

        public static SQLiteDataReader ExecuteReader(string sqlCommand, params SQLiteParameter[] parameters)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, connection);
            try
            {
                if (parameters.Length != 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception) { throw; }
        }

    }
}
