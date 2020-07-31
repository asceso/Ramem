using BusinesLogic.LogicClasses;
using BusinesLogic.LogicModels;
using DatabaseCreating.Entities;
using DatabaseTemplateFill.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DatabaseTemplateFill
{
    class ExecuteFill
    {
        #region Fields // Поля
        DataContext db;
        List<FirstNameModel> firstNames = new List<FirstNameModel>();
        List<SecondNameModel> secondNames = new List<SecondNameModel>();
        ApplicationSettingsModel settings = SettingsLogic.ReadConfiguration();
        #endregion

        #region Ctor // Конструктор класса и метод Main
        static void Main(string[] args)
        {
            ExecuteFill execute = new ExecuteFill();
        }
        public ExecuteFill()
        {
            string conString = $"Data Source={settings.ConnectionString.DataSource}" +
            $"AttachDbFilename = {settings.ConnectionString.AttachDbFilename}" +
            $"Integrated Security = {settings.ConnectionString.IntegratedSecurity}";
            db = new DataContext(conString);
            System.Console.WriteLine("Reading Json...");
            ReadSource();
        }
        #endregion

        /// <summary>
        /// Чтение файлов из папки Output
        /// </summary>
        private void ReadSource()
        {
            int counter = 0;
            string buffer;

            //FirstNames
            try
            {
                string[] fileList = Directory.GetFiles($"{Environment.CurrentDirectory}\\Output\\FirstNames\\", "*.json");
                foreach (var file in fileList)
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        buffer = sr.ReadToEnd();
                        Console.WriteLine($"Received {file.Replace(Environment.CurrentDirectory,"")}.");
                    }
                    firstNames.AddRange(JsonConvert.DeserializeObject<FirstNameModel[]>(buffer));
                    foreach (FirstNameModel item in firstNames)
                    {
                        if (db.FirstNames.Any(x => x.FirstNameValue == item.FirstNameValue))
                            continue;
                        db.FirstNames.Add(new FirstName
                        {
                            FirstNameValue = item.FirstNameValue,
                            IsMale = item.IsMale,
                            Genesis = item.Genesis
                        });
                        counter++;
                    }
                    db.SaveChanges();
                    Console.WriteLine($"{counter} FirstNames added to Database");
                }
                counter = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //SecondNames
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.CurrentDirectory}\\Output\\SecondNames\\SecondNames.json"))
                {
                    buffer = sr.ReadToEnd();
                    Console.WriteLine("Received SecondNames.");
                }
                secondNames.AddRange(JsonConvert.DeserializeObject<SecondNameModel[]>(buffer));
                foreach (SecondNameModel item in secondNames)
                {
                    if (db.SecondNames.Any(x => x.SecondNameValue == item.SecondNameValue))
                        continue;
                    db.SecondNames.Add(new SecondName
                    {
                        SecondNameValue = item.SecondNameValue
                    });
                    counter++;
                }
                db.SaveChanges();
                Console.WriteLine($"{counter} SecondNames added to Database");
                counter = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Complete
            Console.WriteLine("Operation is succes press any key to continue");
            Console.ReadKey();
        }
    }
}
