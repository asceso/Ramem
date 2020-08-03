namespace BusinesLogic.LogicModels
{
    /// <summary>
    /// Модель настроек
    /// </summary>
    public class ApplicationSettingsModel
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        public ConnectionString ConnectionString { get; set; }
        public AccessConnection AccessConnection { get; set; }
    }
    public class ConnectionString
    {
        /// <summary>
        /// Имя подключения
        /// </summary>
        public string ConnectionName { get; set; }
        /// <summary>
        /// Источник
        /// </summary>
        public string DataSource { get; set; }
        /// <summary>
        /// Файл базы данных
        /// </summary>
        public string AttachDbFilename { get; set; }
        /// <summary>
        /// Встроенная проверка пользователя
        /// </summary>
        public bool IntegratedSecurity { get; set; }
        /// <summary>
        /// Имя провайдера источника данных
        /// </summary>
        public string ProviderName { get; set; }
    }
    public class AccessConnection
    {
        public string Provider { get; set; }
        public string DataSource { get; set; }
        public bool PersistSecurityInfo { get; set; }
        public string Password { get; set; }
    }
}
