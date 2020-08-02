namespace MainProject.Forms
{
    partial class RamemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RamemForm));
            this.ManagmentPanel = new DevExpress.Utils.Layout.StackPanel();
            this.managmentSexLabel = new DevExpress.XtraEditors.LabelControl();
            this.SelectedSexComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ButtonUserGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.MainPanel = new DevExpress.XtraEditors.XtraScrollableControl();
            this.BasicInfoPanel = new DevExpress.XtraEditors.PanelControl();
            this.FarhersNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FathersNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SecondNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.SecondNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FirstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.copyAllBasic = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonFathersName = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonSecondName = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonFirstName = new DevExpress.XtraEditors.SimpleButton();
            this.SwitchBasicInfoPanel = new DevExpress.XtraEditors.CheckButton();
            this.LoadIndicator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManagmentPanel)).BeginInit();
            this.ManagmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSexComboBox.Properties)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicInfoPanel)).BeginInit();
            this.BasicInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FathersNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagmentPanel
            // 
            this.ManagmentPanel.Controls.Add(this.managmentSexLabel);
            this.ManagmentPanel.Controls.Add(this.SelectedSexComboBox);
            this.ManagmentPanel.Controls.Add(this.ButtonUserGenerate);
            this.ManagmentPanel.Controls.Add(this.LoadIndicator);
            this.ManagmentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagmentPanel.Location = new System.Drawing.Point(0, 0);
            this.ManagmentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ManagmentPanel.Name = "ManagmentPanel";
            this.ManagmentPanel.Size = new System.Drawing.Size(979, 39);
            this.ManagmentPanel.TabIndex = 4;
            // 
            // managmentSexLabel
            // 
            this.managmentSexLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managmentSexLabel.Appearance.Options.UseFont = true;
            this.managmentSexLabel.Location = new System.Drawing.Point(4, 10);
            this.managmentSexLabel.Margin = new System.Windows.Forms.Padding(4);
            this.managmentSexLabel.Name = "managmentSexLabel";
            this.managmentSexLabel.Size = new System.Drawing.Size(101, 18);
            this.managmentSexLabel.TabIndex = 1;
            this.managmentSexLabel.Text = "Выберите пол:";
            // 
            // SelectedSexComboBox
            // 
            this.SelectedSexComboBox.EditValue = "Мужской";
            this.SelectedSexComboBox.Location = new System.Drawing.Point(113, 7);
            this.SelectedSexComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedSexComboBox.Name = "SelectedSexComboBox";
            this.SelectedSexComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedSexComboBox.Properties.Appearance.Options.UseFont = true;
            this.SelectedSexComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectedSexComboBox.Properties.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.SelectedSexComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.SelectedSexComboBox.Size = new System.Drawing.Size(97, 24);
            this.SelectedSexComboBox.TabIndex = 2;
            // 
            // ButtonUserGenerate
            // 
            this.ButtonUserGenerate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUserGenerate.Appearance.Options.UseFont = true;
            this.ButtonUserGenerate.Enabled = false;
            this.ButtonUserGenerate.Location = new System.Drawing.Point(218, 6);
            this.ButtonUserGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUserGenerate.Name = "ButtonUserGenerate";
            this.ButtonUserGenerate.Size = new System.Drawing.Size(206, 27);
            this.ButtonUserGenerate.TabIndex = 3;
            this.ButtonUserGenerate.Text = "Сгенерировать пользователя";
            this.ButtonUserGenerate.Click += new System.EventHandler(this.ButtonUserGenerate_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BasicInfoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 39);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(979, 479);
            this.MainPanel.TabIndex = 5;
            // 
            // BasicInfoPanel
            // 
            this.BasicInfoPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.BasicInfoPanel.Controls.Add(this.copyAllBasic);
            this.BasicInfoPanel.Controls.Add(this.copyButtonFathersName);
            this.BasicInfoPanel.Controls.Add(this.copyButtonSecondName);
            this.BasicInfoPanel.Controls.Add(this.copyButtonFirstName);
            this.BasicInfoPanel.Controls.Add(this.FarhersNameLabel);
            this.BasicInfoPanel.Controls.Add(this.FathersNameTextEdit);
            this.BasicInfoPanel.Controls.Add(this.SecondNameLabel);
            this.BasicInfoPanel.Controls.Add(this.SecondNameTextEdit);
            this.BasicInfoPanel.Controls.Add(this.FirstNameLabel);
            this.BasicInfoPanel.Controls.Add(this.SwitchBasicInfoPanel);
            this.BasicInfoPanel.Controls.Add(this.FirstNameTextEdit);
            this.BasicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BasicInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.BasicInfoPanel.Margin = new System.Windows.Forms.Padding(15, 5, 4, 5);
            this.BasicInfoPanel.Name = "BasicInfoPanel";
            this.BasicInfoPanel.Size = new System.Drawing.Size(979, 83);
            this.BasicInfoPanel.TabIndex = 0;
            // 
            // FarhersNameLabel
            // 
            this.FarhersNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarhersNameLabel.Appearance.Options.UseFont = true;
            this.FarhersNameLabel.Location = new System.Drawing.Point(616, 45);
            this.FarhersNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FarhersNameLabel.Name = "FarhersNameLabel";
            this.FarhersNameLabel.Size = new System.Drawing.Size(75, 19);
            this.FarhersNameLabel.TabIndex = 5;
            this.FarhersNameLabel.Text = "Отчество:";
            // 
            // FathersNameTextEdit
            // 
            this.FathersNameTextEdit.Location = new System.Drawing.Point(727, 42);
            this.FathersNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FathersNameTextEdit.Name = "FathersNameTextEdit";
            this.FathersNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathersNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FathersNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.FathersNameTextEdit.TabIndex = 6;
            this.FathersNameTextEdit.Tag = "FathersName";
            this.FathersNameTextEdit.TextChanged += new System.EventHandler(this.TextEdit_TextChanged);
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLabel.Appearance.Options.UseFont = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(295, 44);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(71, 19);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "Фамилия:";
            // 
            // SecondNameTextEdit
            // 
            this.SecondNameTextEdit.Location = new System.Drawing.Point(402, 42);
            this.SecondNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNameTextEdit.Name = "SecondNameTextEdit";
            this.SecondNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.SecondNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.SecondNameTextEdit.TabIndex = 4;
            this.SecondNameTextEdit.Tag = "SecondName";
            this.SecondNameTextEdit.TextChanged += new System.EventHandler(this.TextEdit_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Appearance.Options.UseFont = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(10, 44);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(35, 19);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.Location = new System.Drawing.Point(81, 42);
            this.FirstNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.FirstNameTextEdit.TabIndex = 2;
            this.FirstNameTextEdit.Tag = "FirstName";
            this.FirstNameTextEdit.TextChanged += new System.EventHandler(this.TextEdit_TextChanged);
            // 
            // copyAllBasic
            // 
            this.copyAllBasic.Enabled = false;
            this.copyAllBasic.ImageOptions.Image = global::MainProject.Properties.Resources.copyclipboard16x16;
            this.copyAllBasic.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyAllBasic.Location = new System.Drawing.Point(941, 38);
            this.copyAllBasic.Margin = new System.Windows.Forms.Padding(4);
            this.copyAllBasic.Name = "copyAllBasic";
            this.copyAllBasic.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyAllBasic.Size = new System.Drawing.Size(31, 33);
            this.copyAllBasic.TabIndex = 10;
            this.copyAllBasic.Tag = "Copy";
            this.copyAllBasic.ToolTip = "Скопировать Ф.И.О.";
            this.copyAllBasic.Click += new System.EventHandler(this.copyButtonClick);
            // 
            // copyButtonFathersName
            // 
            this.copyButtonFathersName.Enabled = false;
            this.copyButtonFathersName.ImageOptions.Image = global::MainProject.Properties.Resources.copyclipboard16x16;
            this.copyButtonFathersName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonFathersName.Location = new System.Drawing.Point(699, 45);
            this.copyButtonFathersName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonFathersName.Name = "copyButtonFathersName";
            this.copyButtonFathersName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonFathersName.Size = new System.Drawing.Size(20, 20);
            this.copyButtonFathersName.TabIndex = 9;
            this.copyButtonFathersName.Tag = "Copy, FathersName";
            this.copyButtonFathersName.ToolTip = "Скопировать отчество";
            this.copyButtonFathersName.Click += new System.EventHandler(this.copyButtonClick);
            // 
            // copyButtonSecondName
            // 
            this.copyButtonSecondName.Enabled = false;
            this.copyButtonSecondName.ImageOptions.Image = global::MainProject.Properties.Resources.copyclipboard16x16;
            this.copyButtonSecondName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonSecondName.Location = new System.Drawing.Point(374, 44);
            this.copyButtonSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonSecondName.Name = "copyButtonSecondName";
            this.copyButtonSecondName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonSecondName.Size = new System.Drawing.Size(20, 20);
            this.copyButtonSecondName.TabIndex = 8;
            this.copyButtonSecondName.Tag = "Copy, SecondName";
            this.copyButtonSecondName.ToolTip = "Скопировать фамилию";
            this.copyButtonSecondName.Click += new System.EventHandler(this.copyButtonClick);
            // 
            // copyButtonFirstName
            // 
            this.copyButtonFirstName.Enabled = false;
            this.copyButtonFirstName.ImageOptions.Image = global::MainProject.Properties.Resources.copyclipboard16x16;
            this.copyButtonFirstName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonFirstName.Location = new System.Drawing.Point(53, 44);
            this.copyButtonFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonFirstName.Name = "copyButtonFirstName";
            this.copyButtonFirstName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonFirstName.Size = new System.Drawing.Size(20, 20);
            this.copyButtonFirstName.TabIndex = 7;
            this.copyButtonFirstName.Tag = "Copy, FirstName";
            this.copyButtonFirstName.ToolTip = "Скопировать имя";
            this.copyButtonFirstName.Click += new System.EventHandler(this.copyButtonClick);
            // 
            // SwitchBasicInfoPanel
            // 
            this.SwitchBasicInfoPanel.Checked = true;
            this.SwitchBasicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchBasicInfoPanel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.SwitchBasicInfoPanel.ImageOptions.Image = global::MainProject.Properties.Resources.people_16x16;
            this.SwitchBasicInfoPanel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.SwitchBasicInfoPanel.ImageOptions.ImageToTextIndent = 10;
            this.SwitchBasicInfoPanel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SwitchBasicInfoPanel.Location = new System.Drawing.Point(2, 2);
            this.SwitchBasicInfoPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.SwitchBasicInfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SwitchBasicInfoPanel.Name = "SwitchBasicInfoPanel";
            this.SwitchBasicInfoPanel.Size = new System.Drawing.Size(975, 30);
            this.SwitchBasicInfoPanel.TabIndex = 0;
            this.SwitchBasicInfoPanel.Text = "Базовая информация";
            this.SwitchBasicInfoPanel.CheckedChanged += new System.EventHandler(this.switchBasicInfoPanel_CheckedChanged);
            // 
            // LoadIndicator
            // 
            this.LoadIndicator.Image = global::MainProject.Properties.Resources.loading;
            this.LoadIndicator.Location = new System.Drawing.Point(431, 6);
            this.LoadIndicator.Name = "LoadIndicator";
            this.LoadIndicator.Size = new System.Drawing.Size(26, 26);
            this.LoadIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadIndicator.TabIndex = 4;
            this.LoadIndicator.TabStop = false;
            // 
            // RamemForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 518);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ManagmentPanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RamemForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RamemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор личностей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RamemFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ManagmentPanel)).EndInit();
            this.ManagmentPanel.ResumeLayout(false);
            this.ManagmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSexComboBox.Properties)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BasicInfoPanel)).EndInit();
            this.BasicInfoPanel.ResumeLayout(false);
            this.BasicInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FathersNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel ManagmentPanel;
        private DevExpress.XtraEditors.XtraScrollableControl MainPanel;
        private DevExpress.XtraEditors.PanelControl BasicInfoPanel;
        private DevExpress.XtraEditors.SimpleButton copyAllBasic;
        private DevExpress.XtraEditors.SimpleButton copyButtonFathersName;
        private DevExpress.XtraEditors.SimpleButton copyButtonSecondName;
        private DevExpress.XtraEditors.SimpleButton copyButtonFirstName;
        private DevExpress.XtraEditors.LabelControl FarhersNameLabel;
        private DevExpress.XtraEditors.TextEdit FathersNameTextEdit;
        private DevExpress.XtraEditors.LabelControl SecondNameLabel;
        private DevExpress.XtraEditors.TextEdit SecondNameTextEdit;
        private DevExpress.XtraEditors.LabelControl FirstNameLabel;
        private DevExpress.XtraEditors.CheckButton SwitchBasicInfoPanel;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.LabelControl managmentSexLabel;
        private DevExpress.XtraEditors.ComboBoxEdit SelectedSexComboBox;
        private DevExpress.XtraEditors.SimpleButton ButtonUserGenerate;
        private System.Windows.Forms.PictureBox LoadIndicator;
    }
}