namespace SettingsProject.Forms
{
    partial class AppSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsForm));
            this.SettingsManagmentPanel = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonSaveSettings = new DevExpress.XtraEditors.SimpleButton();
            this.SettingsViewPanel = new DevExpress.XtraEditors.PanelControl();
            this.ConnectionPanel = new DevExpress.XtraEditors.PanelControl();
            this.ButtonUpdateDatabase = new DevExpress.XtraEditors.SimpleButton();
            this.CheckDatabaseImage = new System.Windows.Forms.PictureBox();
            this.DataNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.DataProviderComboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.LoginEdit = new DevExpress.XtraEditors.TextEdit();
            this.CheckeditAuth = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonOpenDirectoryDialog = new DevExpress.XtraEditors.SimpleButton();
            this.DataPathEdit = new DevExpress.XtraEditors.TextEdit();
            this.DataSourceComboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ConnectionNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsManagmentPanel)).BeginInit();
            this.SettingsManagmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewPanel)).BeginInit();
            this.SettingsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionPanel)).BeginInit();
            this.ConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckDatabaseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProviderComboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckeditAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPathEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceComboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsManagmentPanel
            // 
            this.SettingsManagmentPanel.Controls.Add(this.ButtonSaveSettings);
            this.SettingsManagmentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsManagmentPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsManagmentPanel.Name = "SettingsManagmentPanel";
            this.SettingsManagmentPanel.Size = new System.Drawing.Size(522, 38);
            this.SettingsManagmentPanel.TabIndex = 0;
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Enabled = false;
            this.ButtonSaveSettings.ImageOptions.Image = global::SettingsProject.Properties.Resources.save_16x16;
            this.ButtonSaveSettings.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSaveSettings.Location = new System.Drawing.Point(3, 7);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.Size = new System.Drawing.Size(151, 23);
            this.ButtonSaveSettings.TabIndex = 0;
            this.ButtonSaveSettings.Text = "Сохранить настройки";
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // SettingsViewPanel
            // 
            this.SettingsViewPanel.Controls.Add(this.ConnectionPanel);
            this.SettingsViewPanel.Controls.Add(this.progressPanel);
            this.SettingsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsViewPanel.Location = new System.Drawing.Point(0, 38);
            this.SettingsViewPanel.Name = "SettingsViewPanel";
            this.SettingsViewPanel.Size = new System.Drawing.Size(522, 264);
            this.SettingsViewPanel.TabIndex = 1;
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ConnectionPanel.Controls.Add(this.ButtonUpdateDatabase);
            this.ConnectionPanel.Controls.Add(this.CheckDatabaseImage);
            this.ConnectionPanel.Controls.Add(this.DataNameEdit);
            this.ConnectionPanel.Controls.Add(this.labelControl4);
            this.ConnectionPanel.Controls.Add(this.ButtonTestConnection);
            this.ConnectionPanel.Controls.Add(this.DataProviderComboEdit);
            this.ConnectionPanel.Controls.Add(this.PasswordEdit);
            this.ConnectionPanel.Controls.Add(this.LoginEdit);
            this.ConnectionPanel.Controls.Add(this.CheckeditAuth);
            this.ConnectionPanel.Controls.Add(this.ButtonOpenDirectoryDialog);
            this.ConnectionPanel.Controls.Add(this.DataPathEdit);
            this.ConnectionPanel.Controls.Add(this.DataSourceComboEdit);
            this.ConnectionPanel.Controls.Add(this.ConnectionNameEdit);
            this.ConnectionPanel.Controls.Add(this.labelControl7);
            this.ConnectionPanel.Controls.Add(this.labelControl6);
            this.ConnectionPanel.Controls.Add(this.labelControl5);
            this.ConnectionPanel.Controls.Add(this.labelControl3);
            this.ConnectionPanel.Controls.Add(this.labelControl2);
            this.ConnectionPanel.Controls.Add(this.labelControl1);
            this.ConnectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectionPanel.Location = new System.Drawing.Point(2, 2);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(518, 230);
            this.ConnectionPanel.TabIndex = 1;
            // 
            // ButtonUpdateDatabase
            // 
            this.ButtonUpdateDatabase.ImageOptions.Image = global::SettingsProject.Properties.Resources.refreshallpivottable_16x16;
            this.ButtonUpdateDatabase.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonUpdateDatabase.ImageOptions.ImageToTextIndent = 10;
            this.ButtonUpdateDatabase.Location = new System.Drawing.Point(3, 202);
            this.ButtonUpdateDatabase.Name = "ButtonUpdateDatabase";
            this.ButtonUpdateDatabase.Size = new System.Drawing.Size(508, 23);
            this.ButtonUpdateDatabase.TabIndex = 19;
            this.ButtonUpdateDatabase.Text = "Обновить базу с сайта";
            this.ButtonUpdateDatabase.Click += new System.EventHandler(this.ButtonUpdateDatabase_Click);
            // 
            // CheckDatabaseImage
            // 
            this.CheckDatabaseImage.Image = global::SettingsProject.Properties.Resources.apply_16x16;
            this.CheckDatabaseImage.Location = new System.Drawing.Point(491, 78);
            this.CheckDatabaseImage.Name = "CheckDatabaseImage";
            this.CheckDatabaseImage.Size = new System.Drawing.Size(20, 20);
            this.CheckDatabaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckDatabaseImage.TabIndex = 18;
            this.CheckDatabaseImage.TabStop = false;
            // 
            // DataNameEdit
            // 
            this.DataNameEdit.Location = new System.Drawing.Point(101, 78);
            this.DataNameEdit.Name = "DataNameEdit";
            this.DataNameEdit.Size = new System.Drawing.Size(384, 20);
            this.DataNameEdit.TabIndex = 17;
            this.DataNameEdit.EditValueChanged += new System.EventHandler(this.EditValueChangedEvent);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Имя базы данных";
            // 
            // ButtonTestConnection
            // 
            this.ButtonTestConnection.ImageOptions.Image = global::SettingsProject.Properties.Resources.wifi_16x16;
            this.ButtonTestConnection.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonTestConnection.ImageOptions.ImageToTextIndent = 10;
            this.ButtonTestConnection.Location = new System.Drawing.Point(5, 173);
            this.ButtonTestConnection.Name = "ButtonTestConnection";
            this.ButtonTestConnection.Size = new System.Drawing.Size(508, 23);
            this.ButtonTestConnection.TabIndex = 15;
            this.ButtonTestConnection.Text = "Проверить соединение";
            this.ButtonTestConnection.Click += new System.EventHandler(this.ButtonTestConnection_Click);
            // 
            // DataProviderComboEdit
            // 
            this.DataProviderComboEdit.Location = new System.Drawing.Point(109, 147);
            this.DataProviderComboEdit.Name = "DataProviderComboEdit";
            this.DataProviderComboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataProviderComboEdit.Properties.Items.AddRange(new object[] {
            "System.Data.SqlClient"});
            this.DataProviderComboEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DataProviderComboEdit.Size = new System.Drawing.Size(404, 20);
            this.DataProviderComboEdit.TabIndex = 14;
            this.DataProviderComboEdit.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedEvent);
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Location = new System.Drawing.Point(302, 124);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Properties.UseSystemPasswordChar = true;
            this.PasswordEdit.Size = new System.Drawing.Size(211, 20);
            this.PasswordEdit.TabIndex = 13;
            this.PasswordEdit.EditValueChanged += new System.EventHandler(this.EditValueChangedEvent);
            // 
            // LoginEdit
            // 
            this.LoginEdit.Location = new System.Drawing.Point(41, 124);
            this.LoginEdit.Name = "LoginEdit";
            this.LoginEdit.Size = new System.Drawing.Size(211, 20);
            this.LoginEdit.TabIndex = 12;
            this.LoginEdit.EditValueChanged += new System.EventHandler(this.EditValueChangedEvent);
            // 
            // CheckeditAuth
            // 
            this.CheckeditAuth.Location = new System.Drawing.Point(5, 100);
            this.CheckeditAuth.Name = "CheckeditAuth";
            this.CheckeditAuth.Properties.Caption = "Использовать встроенную аутентификацию";
            this.CheckeditAuth.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckeditAuth.Properties.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.Green;
            this.CheckeditAuth.Properties.CheckBoxOptions.SvgColorUnchecked = System.Drawing.Color.DimGray;
            this.CheckeditAuth.Properties.CheckBoxOptions.SvgImageSize = new System.Drawing.Size(25, 20);
            this.CheckeditAuth.Size = new System.Drawing.Size(508, 24);
            this.CheckeditAuth.TabIndex = 11;
            this.CheckeditAuth.CheckedChanged += new System.EventHandler(this.CheckeditAuth_CheckedChanged);
            // 
            // ButtonOpenDirectoryDialog
            // 
            this.ButtonOpenDirectoryDialog.ImageOptions.Image = global::SettingsProject.Properties.Resources.opendoc_16x16;
            this.ButtonOpenDirectoryDialog.Location = new System.Drawing.Point(491, 52);
            this.ButtonOpenDirectoryDialog.Name = "ButtonOpenDirectoryDialog";
            this.ButtonOpenDirectoryDialog.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ButtonOpenDirectoryDialog.Size = new System.Drawing.Size(20, 20);
            this.ButtonOpenDirectoryDialog.TabIndex = 10;
            this.ButtonOpenDirectoryDialog.ToolTip = "Выбор папки для хранения БД";
            this.ButtonOpenDirectoryDialog.Click += new System.EventHandler(this.ButtonOpenDirectoryDialog_Click);
            // 
            // DataPathEdit
            // 
            this.DataPathEdit.Location = new System.Drawing.Point(111, 52);
            this.DataPathEdit.Name = "DataPathEdit";
            this.DataPathEdit.Size = new System.Drawing.Size(374, 20);
            this.DataPathEdit.TabIndex = 9;
            this.DataPathEdit.EditValueChanged += new System.EventHandler(this.EditValueChangedEvent);
            // 
            // DataSourceComboEdit
            // 
            this.DataSourceComboEdit.Location = new System.Drawing.Point(101, 27);
            this.DataSourceComboEdit.Name = "DataSourceComboEdit";
            this.DataSourceComboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataSourceComboEdit.Properties.Items.AddRange(new object[] {
            "(LocalDB)\\MSSQLLocalDB;",
            ".\\SQLEXPRESS;"});
            this.DataSourceComboEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DataSourceComboEdit.Size = new System.Drawing.Size(412, 20);
            this.DataSourceComboEdit.TabIndex = 8;
            this.DataSourceComboEdit.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChangedEvent);
            // 
            // ConnectionNameEdit
            // 
            this.ConnectionNameEdit.Location = new System.Drawing.Point(122, 2);
            this.ConnectionNameEdit.Name = "ConnectionNameEdit";
            this.ConnectionNameEdit.Size = new System.Drawing.Size(391, 20);
            this.ConnectionNameEdit.TabIndex = 7;
            this.ConnectionNameEdit.EditValueChanged += new System.EventHandler(this.EditValueChangedEvent);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 149);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Провайдер данных";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(259, 127);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Пароль";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 127);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Логин";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Путь к базе данных";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Источник данных";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Название соединения";
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.BarAnimationElementThickness = 2;
            this.progressPanel.Caption = "";
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.Description = "";
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressPanel.Location = new System.Drawing.Point(2, 247);
            this.progressPanel.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.progressPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.ShowCaption = false;
            this.progressPanel.ShowDescription = false;
            this.progressPanel.Size = new System.Drawing.Size(518, 15);
            this.progressPanel.TabIndex = 0;
            this.progressPanel.Visible = false;
            this.progressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar;
            // 
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 302);
            this.Controls.Add(this.SettingsViewPanel);
            this.Controls.Add(this.SettingsManagmentPanel);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AppSettingsForm.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки приложения";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsManagmentPanel)).EndInit();
            this.SettingsManagmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewPanel)).EndInit();
            this.SettingsViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionPanel)).EndInit();
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckDatabaseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProviderComboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckeditAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPathEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceComboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel SettingsManagmentPanel;
        private DevExpress.XtraEditors.SimpleButton ButtonSaveSettings;
        private DevExpress.XtraEditors.PanelControl SettingsViewPanel;
        private DevExpress.XtraEditors.PanelControl ConnectionPanel;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonOpenDirectoryDialog;
        private DevExpress.XtraEditors.TextEdit DataPathEdit;
        private DevExpress.XtraEditors.ComboBoxEdit DataSourceComboEdit;
        private DevExpress.XtraEditors.TextEdit ConnectionNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit DataProviderComboEdit;
        private DevExpress.XtraEditors.TextEdit LoginEdit;
        private DevExpress.XtraEditors.CheckEdit CheckeditAuth;
        private DevExpress.XtraEditors.TextEdit PasswordEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonTestConnection;
        private DevExpress.XtraEditors.TextEdit DataNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox CheckDatabaseImage;
        private DevExpress.XtraEditors.SimpleButton ButtonUpdateDatabase;
    }
}