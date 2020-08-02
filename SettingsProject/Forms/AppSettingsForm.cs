using BusinesLogic.LogicClasses;
using BusinesLogic.LogicInterfaces;
using BusinesLogic.LogicModels;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace SettingsProject.Forms
{
    public partial class AppSettingsForm : XtraForm , ISettingsInterface
    {
        #region Fields
        public ApplicationSettingsModel Settings { get; set; }
        bool IsModified;
        #endregion
        #region Ctor and Load // Конструктор и метод загрузки
        public AppSettingsForm()
        {
            InitializeComponent();
            progressPanel.Show();
            Settings = SettingsLogic.ReadConfiguration();
            FillSettingsFields();
            IsModified = false;
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
            IsModified = (CheckeditAuth.Checked != Settings.ConnectionString.IntegratedSecurity && IsModified) ? true : false;
            ToggleSaveButtonEnabled();
        }
        private void ToggleSaveButtonEnabled()
        {
            if (IsModified)
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
                        IsModified = (edit.SelectedItem.ToString() != Settings.ConnectionString.DataSource && IsModified) ? true : false;
                    break;
                case nameof(DataProviderComboEdit):
                        IsModified = (edit.SelectedItem.ToString() != Settings.ConnectionString.ProviderName && IsModified) ? true : false;
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
                        IsModified = (edit.Text != Settings.ConnectionString.ConnectionName && IsModified) ? true : false;
                    break;
                case nameof(DataPathEdit):
                    IsModified = (edit.Text != Settings.ConnectionString.AttachDbFilename && IsModified) ? true : false;
                    break;
                    // Todo: Доработать аутентификацию
                    //case nameof(LoginEdit):
                    //    IsModified = (edit.Text != settings.ConnectionString.Login  && IsModified) ? true : false;
                    //    break;
                    //case nameof(PasswordEdit):
                    //    IsModified = (edit.Text != settings.ConnectionString.Password  && IsModified) ? true : false;
                    //    break;
            }
            ToggleSaveButtonEnabled();
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
        #endregion
    }
}