using BusinesLogic.LogicClasses;
using BusinesLogic.LogicInterfaces;
using BusinesLogic.LogicModels;
using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsProject.Forms
{
    public partial class AppSettingsForm : XtraForm , ISettingsInterface
    {
        #region Fields
        public ApplicationSettingsModel Settings { get; set; }
        bool[] IsModified;
        enum Modify
        {
            ConnectionName,
            DataSource,
            AttachDbFilename,
            IntegratedSecurity,
            ProviderName,
            Login,
            Password
        }
        #endregion
        #region Ctor and Load // Конструктор и метод загрузки
        public AppSettingsForm()
        {
            int ModifyCount = Enum.GetNames(typeof(Modify)).Length;
            IsModified = new bool[ModifyCount];
            InitializeComponent();
            progressPanel.Show();
            Settings = SettingsLogic.ReadConfiguration();
            FillSettingsFields();
            progressPanel.Hide();
        }
        #endregion
        #region Events // События
        private void CheckeditAuth_CheckedChanged(object sender, EventArgs e)
        {
            switch (CheckeditAuth.Checked)
            {
                case true:
                    {
                        LoginEdit.Enabled = false;
                        PasswordEdit.Enabled = false;
                    }
                    break;
                case false:
                    {
                        LoginEdit.Enabled = true;
                        PasswordEdit.Enabled = true;
                    }
                    break;
            }
            IsModified[(int)Modify.IntegratedSecurity] = (CheckeditAuth.Checked != Settings.ConnectionString.IntegratedSecurity) ? true : false;
            ToggleSaveButtonEnabled();
        }
        private void ToggleSaveButtonEnabled()
        {
            if (IsModified.Any(b => b == true))
                ButtonSaveSettings.Enabled = true;
            else
                ButtonSaveSettings.Enabled = false;
        }
        private void SelectedIndexChangedEvent(object sender, EventArgs e)
        {
            ComboBoxEdit edit = sender as ComboBoxEdit;
            switch (edit.Name)
            {
                case nameof(DataSourceComboEdit):
                        IsModified[(int)Modify.DataSource] = (edit.SelectedItem.ToString() != Settings.ConnectionString.DataSource) ? true : false;
                    break;
                case nameof(DataProviderComboEdit):
                        IsModified[(int)Modify.ProviderName] = (edit.SelectedItem.ToString() != Settings.ConnectionString.ProviderName) ? true : false;
                    break;
            }
            ToggleSaveButtonEnabled();
        }
        private void EditValueChangedEvent(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            switch (edit.Name)
            {
                case nameof(ConnectionNameEdit):
                    IsModified[(int)Modify.ConnectionName] = (edit.Text != Settings.ConnectionString.ConnectionName) ? true : false;
                    break;
                case nameof(DataPathEdit):
                    IsModified[(int)Modify.AttachDbFilename] = (edit.Text != Settings.ConnectionString.AttachDbFilename) ? true : false;
                    break;
                    // Todo: Доработать аутентификацию
                    //case nameof(LoginEdit):
                    //    IsModified[(int)Modify.Login] = (edit.Text != settings.ConnectionString.Login) ? true : false;
                    //    break;
                    //case nameof(PasswordEdit):
                    //    IsModified[(int)Modify.Password = (edit.Text != settings.ConnectionString.Password) ? true : false;
                    //    break;
            }
            ToggleSaveButtonEnabled();
        }
        async private Task TestSqlConnection(string ConnectionStringProperty)
        {
            SqlConnection connection = new SqlConnection(ConnectionStringProperty);
            try
            {
                await connection.OpenAsync();
                MessageBox.Show($"Подключение выполнено успешно", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Во время подключения к серверу произошла ошибка\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        private void FillSettingsFields()
        {
            ConnectionNameEdit.Text = Settings.ConnectionString.ConnectionName;
            DataSourceComboEdit.SelectedItem = Settings.ConnectionString.DataSource;
            DataPathEdit.Text = Settings.ConnectionString.AttachDbFilename;
            CheckeditAuth.Checked = Settings.ConnectionString.IntegratedSecurity;
            DataProviderComboEdit.SelectedItem = Settings.ConnectionString.ProviderName;
        }
        private void FillSettingsModel()
        {
            Settings.ConnectionString.ConnectionName = ConnectionNameEdit.Text;
            Settings.ConnectionString.DataSource = DataSourceComboEdit.SelectedItem.ToString();
            Settings.ConnectionString.AttachDbFilename = DataPathEdit.Text;
            Settings.ConnectionString.IntegratedSecurity = CheckeditAuth.Checked;
            Settings.ConnectionString.ProviderName = DataProviderComboEdit.SelectedItem.ToString();
        }
        #endregion
        #region Buttons // Кнопки
        private void ButtonOpenDirectoryDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.CurrentDirectory;
            openFile.Filter = "Database files|*.mdf";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DataPathEdit.Text = openFile.FileName+";";
            }
        }
        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                progressPanel.Show();
                SettingsLogic.SetDefaultConnectionString(Settings, Environment.CurrentDirectory + "\\DatabaseCreating.exe.config");
                FillSettingsModel();
                SettingsLogic.SaveConfiguration(Settings);
                MessageBox.Show("Успешно сохранено", "Операция выполнена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressPanel.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Во время сохранения xml конфигурации произошла ошибка\n" + ex.Message,
                    "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        async private void ButtonTestConnection_Click(object sender, EventArgs e)
        {
            string ConnectionStringProperty = $"Data Source={DataSourceComboEdit.SelectedItem}" +
                $"AttachDbFilename = {DataPathEdit.Text}" +
                $"Integrated Security = {CheckeditAuth.Checked}";
            progressPanel.Show();
            switch (DataProviderComboEdit.SelectedItem.ToString())
            {
                case "System.Data.SqlClient":
                    {
                        await TestSqlConnection(ConnectionStringProperty);
                    }
                    break;
            }
            progressPanel.Hide();
        }
        #endregion
    }
}