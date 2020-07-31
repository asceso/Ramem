using BusinesLogic.LogicClasses;
using BusinesLogic.LogicModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace DatabaseCreating
{
    /// <summary>
    /// Класс создает из пустой БД нужную , для корректной работы каждая миграция создается со скриптом.
    /// Все скрипты поместить в папку Scripts. Важно!!!! Только для пустой БД.
    /// </summary>
    class ExecuteCreating
    {
        static void Main(string[] args)
        {
            ApplicationSettingsModel settings = SettingsLogic.ReadConfiguration();            
            string conString = $"Data Source={settings.ConnectionString.DataSource}" +
                $"AttachDbFilename = {settings.ConnectionString.AttachDbFilename}" +
                $"Integrated Security = {settings.ConnectionString.IntegratedSecurity}";

            Console.WriteLine("Reading scripts folder...");
            string[] fileList = Directory.GetFiles($"{Environment.CurrentDirectory}\\Scripts", "*.sql");
            Console.WriteLine("Finded: " + (fileList.Length-1).ToString() + " scripts.");
            Console.WriteLine("Preparing to execute...");
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                string scriptText = File.ReadAllText($"{Environment.CurrentDirectory}\\Scripts\\Migrations.sql");
                SqlDataReader reader = new SqlCommand(scriptText, connection).ExecuteReader();
                List<string> data = new List<string>();
                while (reader.Read())
                {
                    data.Add(reader.GetValue(0).ToString());
                }
                string[] MigrationsInDB = data.ToArray();
                Console.WriteLine("SQL Connection is opened.");
                foreach (string script in fileList)
                {
                    if (script.Contains("Migrations.sql")) continue;
                    string filename = script.Replace(Environment.CurrentDirectory + "\\Scripts\\", string.Empty).Replace(".sql",string.Empty);
                    if(MigrationsInDB.Any(p=>p.Equals(filename)))
                    {
                        Console.WriteLine($"Script {filename} is already in Database. Skipped");
                        continue;
                    }
                    Console.WriteLine($"Execute script {filename}");
                    scriptText = File.ReadAllText(script);
                    SqlCommand command = new SqlCommand(scriptText, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"{filename} is success");
                }
                Console.WriteLine("All scripts has executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERORR: {ex.Message}");
            }
            finally
            {
                connection.Close();
                Console.WriteLine("SQL Connection is closed.");
                Console.WriteLine("Scripts operations complete . Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
