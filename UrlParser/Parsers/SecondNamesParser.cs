using AngleSharp.Html.Parser;
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
    class SecondNamesParser
    {
        #region Parse and Create model // Методы парсинга и создания модели
        async void Parsing(string url, string OutputName)
        {
            string request = string.Empty;
            List<string> famElements = new List<string>();
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = await client.GetAsync(url);
            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                HttpContent content = httpResponse.Content;
                request = await content.ReadAsStringAsync();
            }
            var parser = new HtmlParser();
            var document = parser.ParseDocument(request);
            var items = document.QuerySelectorAll("ul").Where(it=>!it.TextContent.Contains(" "));
            foreach (var item in items)
            {
                var dd = item.QuerySelectorAll("li");
                for (int i = 0; i < dd.Length; i++)
                {
                    famElements.Add(dd[i].TextContent);
                }
            }
            CreatingModels(OutputName, famElements);
        }
        void CreatingModels(string OutputName, List<string> famElements)
        {
            List<SecondNameModel> models = new List<SecondNameModel>();
            for (int i = 0; i < famElements.Count; i += 3)
            {
                models.Add(new SecondNameModel { SecondNameValue = famElements[i] });
            }
            try
            {
                string directoryPath = Environment.CurrentDirectory + "\\Output\\SecondNames\\";
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);
                using (StreamWriter sw = new StreamWriter(directoryPath + OutputName))
                {
                    string json = JsonConvert.SerializeObject(models, Formatting.Indented);
                    sw.WriteLine(json);
                    Console.WriteLine($"{OutputName} model created.");
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
        public void GetParsed(string url, string OutputName)
        {
            Console.WriteLine($"Start parsing url: {url}");
            Parsing(url, OutputName);
        }
        #endregion
    }
}
