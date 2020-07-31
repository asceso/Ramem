using BusinesLogic.LogicModels;
using Newtonsoft.Json;
using System;
using System.IO;

namespace BusinesLogic.LogicClasses
{
    /// <summary>
    /// Класс логики настроек
    /// </summary>
    public class SettingsLogic
    {
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
                string json = JsonConvert.SerializeObject(settingsModel, Formatting.Indented);
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
