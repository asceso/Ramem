using BusinesLogic.LogicClasses;
using BusinesLogic.LogicInterfaces;
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
    class CreateDatabase : ISettingsInterface
    {
        #region Fields // Поля
        public ApplicationSettingsModel Settings { get; set; }
        string ConnectionStringProperty;
        SqlConnection Connection;
        #endregion
        #region Ctor // Конструктор класса
        public CreateDatabase()
        {
            Settings = SettingsLogic.ReadConfiguration();
            ConnectionStringProperty = $"Data Source={Settings.ConnectionString.DataSource}" +
                $"AttachDbFilename = {Settings.ConnectionString.AttachDbFilename}" +
                $"Integrated Security = {Settings.ConnectionString.IntegratedSecurity}";
        }
        #endregion
        #region Start method // Метод запуска создания БД
        public void StartCreating()
        {
            Console.WriteLine("Reading scripts folder...");
            string[] fileList = Directory.GetFiles($"{Environment.CurrentDirectory}\\Scripts", "*.sql");
            Console.WriteLine("Finded: " + (fileList.Length - 1).ToString() + " scripts.");
            Console.WriteLine("Preparing to execute...");
            Connection = new SqlConnection(ConnectionStringProperty);
            try
            {
                Connection.Open();
                Console.WriteLine("SQL Connection is opened.");
                string scriptText = File.ReadAllText($"{Environment.CurrentDirectory}\\Scripts\\Migrations.sql");
                SqlDataReader reader = new SqlCommand(scriptText, Connection).ExecuteReader();
                List<string> data = new List<string>();
                while (reader.Read())
                {
                    data.Add(reader.GetValue(0).ToString());
                }
                string[] MigrationsInDB = data.ToArray();
                foreach (string script in fileList)
                {
                    if (script.Contains("Migrations.sql")) continue;
                    string filename = script.Replace(Environment.CurrentDirectory + "\\Scripts\\", string.Empty).Replace(".sql", string.Empty);
                    if (MigrationsInDB.Any(p => p.Equals(filename)))
                    {
                        Console.WriteLine($"Script {filename} is already in Database. Skipped");
                        continue;
                    }
                    Console.WriteLine($"Execute script {filename}");
                    scriptText = File.ReadAllText(script);
                    SqlCommand command = new SqlCommand(scriptText, Connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine($"{filename} is success");
                }
                Console.WriteLine("All scripts has executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERORR: {ex.Message} . Press any key to exit");
                Console.ReadKey();
            }
            finally
            {
                Connection.Close();
                Console.WriteLine("SQL Connection is closed.");
                Console.WriteLine("Scripts operations complete . Press any key to exit");
                Console.ReadKey();
            }
        }
        #endregion
    }
}
