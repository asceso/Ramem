﻿using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DatabaseTemplateFill.Models;
using System.IO;
using System;
using Newtonsoft.Json;

namespace UrlParser.Parsers
{
    class FirstNameParser
    {
        #region Fields // Поля
        List<string> table;
        List<FirstNameModel> models;
        string request;
        bool IsReady = false;
        #endregion
        #region Parse and Create model // Методы парсинга и создания модели
        async void Parsing(string url)
        {
            table = new List<string>();
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync(url);
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                HttpContent content = httpResponse.Content;
                request = await content.ReadAsStringAsync();
            }
            var parser = new HtmlParser();
            var document = parser.ParseDocument(request);
            var items = document
                .QuerySelectorAll("table")
                .Where(item => item.ClassName.Contains("table table-hover"));
            foreach (var item in items)
            {
                var dd = item.QuerySelectorAll("td");
                for (int i = 0; i < dd.Length; i++)
                {
                    table.Add(dd[i].InnerHtml);
                }
            }
            IsReady = true;
        }
        void CreatingModels(bool isMale,string OutputName)
        {
            Console.WriteLine($"Creating Json..{OutputName}");
            models = new List<FirstNameModel>();
            for (int i = 0; i < table.Count; i+=3)
            {
                if (table[i].Contains(';') || table[i].Contains('(') || table[i].Contains(')'))
                    continue;
                models.Add(new FirstNameModel{
                    FirstNameValue = table[i],
                    Genesis = table[i + 2],
                    IsMale = isMale
                });
            }
            try
            {
                string directoryPath = Environment.CurrentDirectory + "\\Output\\FirstNames\\";
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);
                using (StreamWriter sw = new StreamWriter(directoryPath + OutputName))
                {
                    string json = JsonConvert.SerializeObject(models, Formatting.Indented);
                    sw.WriteLine(json);
                    Console.WriteLine("model created.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                Console.ReadKey();
            }
        }
        #endregion
        #region Run parsing // Запуск парсера
        public void GetParsed(string url,bool isMale,string OutputName)
        {
            IsReady = false;
            Console.WriteLine($"Start parsing url: {url}");
            Parsing(url);
            while (!IsReady) ;
            CreatingModels(isMale,OutputName);
        }
        #endregion
    }
}
