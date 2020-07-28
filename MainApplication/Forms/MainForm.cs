using DatabaseLibrary;
using DatabaseLibrary.Entities;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

namespace MainApplication.Forms
{
    public partial class MainForm : XtraForm
    {
        DataContext db;
        public MainForm()
        {
            db = new DataContext();
            InitializeComponent();
        }
        private void copyButtonClick(object sender, System.EventArgs e)
        {
            if ((sender is SimpleButton simpleButton) && simpleButton.Tag.Equals("Copy"))
            {
                this.ActiveControl = null;
            }
        }
        private void switchBasicInfoPanel_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (SwitchBasicInfoPanel.Checked)
            {
                case true:
                    BasicInfoPanel.Size = new Size(
                        BasicInfoPanel.Size.Width,
                        BasicInfoPanel.Size.Height + 40);
                    break;
                case false:
                    BasicInfoPanel.Size = new Size(
                        BasicInfoPanel.Size.Width,
                        BasicInfoPanel.Size.Height - 40);
                    break;
            }
            this.ActiveControl = null;
        }

        private void ButtonUserGenerate_Click(object sender, System.EventArgs e)
        {
            //Get collection where sex is selected
            switch (SelectedSexComboBox.SelectedItem.ToString())
            {
                case "Мужской":
                    {

                    }
                    break;
                case "Женский":
                    {

                    }
                    break;
            }
        }
    }
}