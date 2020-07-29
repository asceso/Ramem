using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DatabaseTemplateFill.Models;
using System.IO;
using System;
using Newtonsoft.Json;

namespace UrlParser
{
    class SecondNamesParser
    {
        List<string> famElements;
        private List<SecondNameModel> models;
        string request;
        bool IsReady = false;
        async void Parsing(string url)
        {
            famElements = new List<string>();
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
            IsReady = true;
        }
        void CreatingModels(string OutputName)
        {
            Console.WriteLine($"Creating Json..{OutputName}");
            models = new List<SecondNameModel>();
            for (int i = 0; i < famElements.Count; i += 3)
            {
                models.Add(new SecondNameModel { SecondNameValue = famElements[i] });
            }
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Output\\SecondNames\\" + OutputName))
            {
                string json = JsonConvert.SerializeObject(models, Formatting.Indented);
                sw.WriteLine(json);
                Console.WriteLine("model created.");
            }
        }
        public void GetParsed(string url, string OutputName)
        {
            IsReady = false;
            Console.WriteLine($"Start parsing url: {url}");
            Parsing(url);
            while (!IsReady) ;
            CreatingModels(OutputName);
        }
    }
}
