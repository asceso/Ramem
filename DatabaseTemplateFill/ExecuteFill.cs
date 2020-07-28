using DatabaseCreating;
using DatabaseCreating.Entities;
using DatabaseTemplateFill.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace DatabaseTemplateFill
{
    class ExecuteFill
    {
        DataContext db;
        List<FirstNameModel> firstNames = new List<FirstNameModel>();
        List<SecondNameModel> secondNames = new List<SecondNameModel>();
        List<FathersNameModel> fathersNames = new List<FathersNameModel>();
        static void Main(string[] args)
        {
            ExecuteFill execute = new ExecuteFill();
        }
        public ExecuteFill()
        {
            db = new DataContext();
            System.Console.WriteLine("Reading Json...");
            ReadSource();
        }
        private void ReadSource()
        {
            int counter = 0;
            string buffer;

            //FirstNames
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.CurrentDirectory}\\FirstNames.json"))
                {
                    buffer = sr.ReadToEnd();
                    Console.WriteLine("Received FirstNames.");
                }
                firstNames.AddRange(JsonConvert.DeserializeObject<FirstNameModel[]>(buffer));
                foreach (FirstNameModel item in firstNames)
                {
                    if (db.FirstNames.Any(x => x.FirstNameValue == item.FirstNameValue))
                        continue;
                    db.FirstNames.Add(new FirstName
                    {
                        FirstNameValue = item.FirstNameValue,
                        IsMale = item.IsMale
                    });
                    counter++;
                }
                db.SaveChanges();
                Console.WriteLine($"{counter} FirstNames added to Database");
                counter = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //SecondNames
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.CurrentDirectory}\\SecondNames.json"))
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
                        SecondNameValue = item.SecondNameValue,
                        IsMale = item.IsMale
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

            //FathersName
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.CurrentDirectory}\\FathersNames.json"))
                {
                    buffer = sr.ReadToEnd();
                    Console.WriteLine("Received FathersNames.");
                }
                fathersNames.AddRange(JsonConvert.DeserializeObject<FathersNameModel[]>(buffer));
                foreach (FathersNameModel item in fathersNames)
                {
                    if (db.FathersNames.Any(x => x.FathersNameValue == item.FathersNameValue))
                        continue;
                    db.FathersNames.Add(new FathersName
                    {
                        FathersNameValue = item.FathersNameValue,
                        IsMale = item.IsMale
                    });
                    counter++;
                }
                db.SaveChanges();
                Console.WriteLine($"{counter} FathersNames added to Database");
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
