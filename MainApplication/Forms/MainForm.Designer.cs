namespace MainApplication.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ManagmentPanel = new DevExpress.Utils.Layout.StackPanel();
            this.managmentSexLabel = new DevExpress.XtraEditors.LabelControl();
            this.SelectedSexComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ButtonUserGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.LoadIndicator = new System.Windows.Forms.PictureBox();
            this.MainPanel = new DevExpress.XtraEditors.XtraScrollableControl();
            this.BasicInfoPanel = new DevExpress.XtraEditors.PanelControl();
            this.copyAllBasic = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonFathersName = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonSecondName = new DevExpress.XtraEditors.SimpleButton();
            this.copyButtonFirstName = new DevExpress.XtraEditors.SimpleButton();
            this.FarhersNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.FathersNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SecondNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.SecondNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FirstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.SwitchBasicInfoPanel = new DevExpress.XtraEditors.CheckButton();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagmentPanel)).BeginInit();
            this.ManagmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSexComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadIndicator)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicInfoPanel)).BeginInit();
            this.BasicInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FathersNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
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
            this.ManagmentPanel.Size = new System.Drawing.Size(1107, 39);
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
            this.SelectedSexComboBox.Size = new System.Drawing.Size(84, 24);
            this.SelectedSexComboBox.TabIndex = 2;
            // 
            // ButtonUserGenerate
            // 
            this.ButtonUserGenerate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUserGenerate.Appearance.Options.UseFont = true;
            this.ButtonUserGenerate.Enabled = false;
            this.ButtonUserGenerate.Location = new System.Drawing.Point(205, 6);
            this.ButtonUserGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUserGenerate.Name = "ButtonUserGenerate";
            this.ButtonUserGenerate.Size = new System.Drawing.Size(206, 27);
            this.ButtonUserGenerate.TabIndex = 3;
            this.ButtonUserGenerate.Text = "Сгенерировать пользователя";
            this.ButtonUserGenerate.Click += new System.EventHandler(this.ButtonUserGenerate_Click);
            // 
            // LoadIndicator
            // 
            this.LoadIndicator.Image = ((System.Drawing.Image)(resources.GetObject("LoadIndicator.Image")));
            this.LoadIndicator.Location = new System.Drawing.Point(418, 4);
            this.LoadIndicator.Name = "LoadIndicator";
            this.LoadIndicator.Size = new System.Drawing.Size(30, 30);
            this.LoadIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadIndicator.TabIndex = 4;
            this.LoadIndicator.TabStop = false;
            this.LoadIndicator.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BasicInfoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 39);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1107, 479);
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
            this.BasicInfoPanel.Size = new System.Drawing.Size(1107, 83);
            this.BasicInfoPanel.TabIndex = 0;
            // 
            // copyAllBasic
            // 
            this.copyAllBasic.ImageOptions.Image = global::MainApplication.Properties.Resources.merge_32x32;
            this.copyAllBasic.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyAllBasic.Location = new System.Drawing.Point(1044, 40);
            this.copyAllBasic.Margin = new System.Windows.Forms.Padding(4);
            this.copyAllBasic.Name = "copyAllBasic";
            this.copyAllBasic.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyAllBasic.Size = new System.Drawing.Size(60, 33);
            this.copyAllBasic.TabIndex = 10;
            this.copyAllBasic.Tag = "Copy";
            this.copyAllBasic.ToolTip = "Скопировать Ф.И.О.";
            // 
            // copyButtonFathersName
            // 
            this.copyButtonFathersName.ImageOptions.Image = global::MainApplication.Properties.Resources.merge_32x32;
            this.copyButtonFathersName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonFathersName.Location = new System.Drawing.Point(784, 40);
            this.copyButtonFathersName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonFathersName.Name = "copyButtonFathersName";
            this.copyButtonFathersName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonFathersName.Size = new System.Drawing.Size(39, 33);
            this.copyButtonFathersName.TabIndex = 9;
            this.copyButtonFathersName.Tag = "Copy";
            this.copyButtonFathersName.ToolTip = "Скопировать отчество";
            // 
            // copyButtonSecondName
            // 
            this.copyButtonSecondName.ImageOptions.Image = global::MainApplication.Properties.Resources.merge_32x32;
            this.copyButtonSecondName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonSecondName.Location = new System.Drawing.Point(420, 40);
            this.copyButtonSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonSecondName.Name = "copyButtonSecondName";
            this.copyButtonSecondName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonSecondName.Size = new System.Drawing.Size(39, 33);
            this.copyButtonSecondName.TabIndex = 8;
            this.copyButtonSecondName.Tag = "Copy";
            this.copyButtonSecondName.ToolTip = "Скопировать фамилию";
            // 
            // copyButtonFirstName
            // 
            this.copyButtonFirstName.ImageOptions.Image = global::MainApplication.Properties.Resources.merge_32x32;
            this.copyButtonFirstName.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyButtonFirstName.Location = new System.Drawing.Point(63, 40);
            this.copyButtonFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.copyButtonFirstName.Name = "copyButtonFirstName";
            this.copyButtonFirstName.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.copyButtonFirstName.Size = new System.Drawing.Size(39, 33);
            this.copyButtonFirstName.TabIndex = 7;
            this.copyButtonFirstName.Tag = "Copy";
            this.copyButtonFirstName.ToolTip = "Скопировать имя";
            // 
            // FarhersNameLabel
            // 
            this.FarhersNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarhersNameLabel.Appearance.Options.UseFont = true;
            this.FarhersNameLabel.Location = new System.Drawing.Point(680, 44);
            this.FarhersNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FarhersNameLabel.Name = "FarhersNameLabel";
            this.FarhersNameLabel.Size = new System.Drawing.Size(75, 19);
            this.FarhersNameLabel.TabIndex = 5;
            this.FarhersNameLabel.Text = "Отчество:";
            // 
            // FathersNameTextEdit
            // 
            this.FathersNameTextEdit.Location = new System.Drawing.Point(831, 42);
            this.FathersNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FathersNameTextEdit.Name = "FathersNameTextEdit";
            this.FathersNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathersNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FathersNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.FathersNameTextEdit.TabIndex = 6;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameLabel.Appearance.Options.UseFont = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(321, 44);
            this.SecondNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(71, 19);
            this.SecondNameLabel.TabIndex = 3;
            this.SecondNameLabel.Text = "Фамилия:";
            // 
            // SecondNameTextEdit
            // 
            this.SecondNameTextEdit.Location = new System.Drawing.Point(467, 42);
            this.SecondNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondNameTextEdit.Name = "SecondNameTextEdit";
            this.SecondNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.SecondNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.SecondNameTextEdit.TabIndex = 4;
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
            // SwitchBasicInfoPanel
            // 
            this.SwitchBasicInfoPanel.Checked = true;
            this.SwitchBasicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchBasicInfoPanel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.SwitchBasicInfoPanel.ImageOptions.Image = global::MainApplication.Properties.Resources.people_16x16;
            this.SwitchBasicInfoPanel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.SwitchBasicInfoPanel.ImageOptions.ImageToTextIndent = 10;
            this.SwitchBasicInfoPanel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SwitchBasicInfoPanel.Location = new System.Drawing.Point(2, 2);
            this.SwitchBasicInfoPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.SwitchBasicInfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SwitchBasicInfoPanel.Name = "SwitchBasicInfoPanel";
            this.SwitchBasicInfoPanel.Size = new System.Drawing.Size(1103, 30);
            this.SwitchBasicInfoPanel.TabIndex = 0;
            this.SwitchBasicInfoPanel.Text = "Базовая информация";
            this.SwitchBasicInfoPanel.CheckedChanged += new System.EventHandler(this.switchBasicInfoPanel_CheckedChanged);
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.Location = new System.Drawing.Point(109, 42);
            this.FirstNameTextEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(206, 26);
            this.FirstNameTextEdit.TabIndex = 2;
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 518);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ManagmentPanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор личностей";
            ((System.ComponentModel.ISupportInitialize)(this.ManagmentPanel)).EndInit();
            this.ManagmentPanel.ResumeLayout(false);
            this.ManagmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedSexComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadIndicator)).EndInit();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BasicInfoPanel)).EndInit();
            this.BasicInfoPanel.ResumeLayout(false);
            this.BasicInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FathersNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
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