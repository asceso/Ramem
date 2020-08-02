using BusinesLogic.LogicModels;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;

namespace BusinesLogic.LogicClasses
{
    /// <summary>
    /// Класс логики настроек
    /// </summary>
    public class SettingsLogic
    {
        /// <summary>
        /// Метод устанавливает строку подключения в требуемом конфиге
        /// </summary>
        /// <param name="connectionString">Новая строка подключения</param>
        /// <param name="settingsPath">Путь к конфигу</param>
        /// <returns>True если успех, False при ошибке</returns>
        static public void SetDefaultConnectionString(ApplicationSettingsModel settings,string settingsPath)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(settingsPath);
                XmlElement root = document.DocumentElement;
                foreach (XmlNode node in root)
                {
                    if (node.Name != "connectionStrings")
                        continue;
                    foreach (XmlNode connectionString in node.ChildNodes)
                    {
                        connectionString.Attributes["name"].Value = settings.ConnectionString.ConnectionName;
                        connectionString.Attributes["providerName"].Value = settings.ConnectionString.ProviderName;
                        connectionString.Attributes["connectionString"].Value =
                            $"Data Source={settings.ConnectionString.DataSource}" +
                            $"AttachDbFilename={settings.ConnectionString.AttachDbFilename}" +
                            $"Integrated Security={settings.ConnectionString.IntegratedSecurity}";
                    }
                    break;
                }
                document.Save(settingsPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Метод для чтения настроек из файла Json
        /// </summary>
        /// <returns>Возвращает модель класса ApplicationSettingsModel</returns>
        static public ApplicationSettingsModel ReadConfiguration()
        {
            try
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + "\\ApplicationSettings.json");
                ApplicationSettingsModel settings = JsonConvert.DeserializeObject<ApplicationSettingsModel>(json);
                return settings;
            }
            catch (Exception)
            {
                return new ApplicationSettingsModel();
            }
        }
        /// <summary>
        /// Метод для сохранения настроек в Json файл
        /// </summary>
        /// <param name="settingsModel">Модель ApplicationSettingsModel хранящая в себе настройки</param>
        /// <returns>если True то сохранение было успешно, false - ошибка при сохранении</returns>
        static public bool SaveConfiguration(ApplicationSettingsModel settingsModel)
        {
            try
            {
                string json = JsonConvert.SerializeObject(settingsModel, Newtonsoft.Json.Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\ApplicationSettings.json"))
                {
                    sw.Write(json);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
