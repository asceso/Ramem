using DatabaseCreating;
using DatabaseCreating.Entities;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MainApplication.Forms
{
    public partial class MainForm : XtraForm
    {
        #region Fields // Поля
        DataContext db;
        List<FirstName> firstNamesFromDb = new List<FirstName>(); 
        List<SecondName> secondNamesFromDb = new List<SecondName>();
        int RulesCount = 6;
        #endregion
        #region Loading Form and data // Загрузка формы и данных из БД
        public MainForm()
        {
            InitializeComponent();
            LoadIndicator.Show();
            db = new DataContext();
            Thread getData = new Thread(GetDataFromDb);
            getData.Start();
        }
        private void GetDataFromDb()
        {
            firstNamesFromDb.AddRange(db.FirstNames);
            secondNamesFromDb.AddRange(db.SecondNames);
            ButtonUserGenerate.Invoke(new Action(() => { ButtonUserGenerate.Enabled = true; }));
            LoadIndicator.Invoke(new Action(() => { LoadIndicator.Hide(); }));
        }
        #endregion
        #region GenerationMethods // Методы для генерации
        /// <summary>
        /// Метод генерирует женскую фамилию
        /// </summary>
        /// <param name="surnames">Список мужских фамилий</param>
        /// <returns></returns>
        string CreateFemaleSecondName(SecondName[] surnames)
        {
            Random random = new Random();
            string tempSecondName = string.Empty;
            if (surnames.Length != 0)
            {
                tempSecondName = surnames[random.Next(0, surnames.Length)].SecondNameValue;
                if (tempSecondName.EndsWith("ов") || tempSecondName.EndsWith("ев") || tempSecondName.EndsWith("ин"))
                    tempSecondName = tempSecondName.Insert(tempSecondName.Length, "а");
                else if (tempSecondName.EndsWith("ий"))
                    tempSecondName = tempSecondName.Replace("ий", "ая");
                else if (tempSecondName.EndsWith("ый"))
                    tempSecondName = tempSecondName.Replace("ый", "ая");
                else if (tempSecondName.EndsWith("ой"))
                    tempSecondName = tempSecondName.Replace("ой", "ая");
            }
            return tempSecondName;
        }
        /// <summary>
        /// Метод создает отчество
        /// </summary>
        /// <param name="list">Список имен</param>
        /// <param name="IsMale">Мужское или Женское отчество</param>
        /// <returns></returns>
        string CreateFathersName(FirstName[] list,bool IsMale)
        {
            string result = string.Empty;
            Random random = new Random();
            if (list.Length != 0)
            {
                bool RuleIsPerformed = false;
                while (!RuleIsPerformed)
                {
                    result = list[random.Next(0, list.Length)].FirstNameValue;
                    //result = "Агафон";
                    for (int i = 0; i < RulesCount; i++)
                    {
                        result = CheckRulesForFathersName(i, result, IsMale, ref RuleIsPerformed);
                        if (RuleIsPerformed) break;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Проверка правил создания отчества
        /// </summary>
        /// <param name="RuleNum">Номер правила</param>
        /// <param name="Result">Строка для проверки</param>
        /// <param name="IsMale">Мужское или Женское отчество</param>
        /// <returns>Возвращает строку для проверки после проверки правилом</returns>
        string CheckRulesForFathersName(int RuleNum,string Result,bool IsMale,ref bool Perfomed)
        {
            char[] CharChecking;
            string[] ExceptionWords;
            string[] EndingStrings;
            switch (RuleNum)
            {
                case 0:
                    {
                        CharChecking = new char[] { 'б', 'в', 'г', 'д', 'з', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х' };
                        foreach (char sym in CharChecking)
                        {
                            if (Result.EndsWith(sym.ToString()))
                            {
                                Result = (IsMale == true) ? Result += "ович" : Result += "овна";
                                Perfomed = true;
                                break;
                            }
                        }
                    }
                    break;
                case 1:
                    {
                        CharChecking = new char[] { 'ж', 'ш', 'ч', 'щ', 'ц' };
                        foreach (char sym in CharChecking)
                        {
                            if (Result.EndsWith(sym.ToString()))
                            {
                                Result = (IsMale == true) ? Result += "евич" : Result += "евна";
                                Perfomed = true;
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        CharChecking = new char[] { 'а', 'у', 'ы' };
                        ExceptionWords = new string[] { "Аникита", "Никита", "Мина", "Савва", "Сила", "Фока" };
                        foreach (char sym in CharChecking)
                        {
                            if (Result.EndsWith(sym.ToString()))
                            {
                                foreach (var word in ExceptionWords)
                                {
                                    if (Result != word)
                                    {
                                        Result = (IsMale == true) ? Result.Replace(sym.ToString(), "ович") : Result.Replace(sym.ToString(), "овна");
                                        Perfomed = true;
                                        break;
                                    }
                                    else
                                    {
                                        Result = (IsMale == true) ? Result.Replace(sym.ToString(), "ич") : Result.Replace(sym.ToString(), "ична");
                                        Perfomed = true;
                                        break;
                                    }
                                }

                            }
                        }
                    }
                    break;
                case 3:
                    {
                        if (Result.EndsWith("о"))
                        {
                            Result = (IsMale == true) ? Result.Replace("о", "ович") : Result.Replace("о", "овна");
                            Perfomed = true;
                            break;
                        }
                    }
                    break;
                case 4:
                    {
                        EndingStrings = new string[] { "ай", "яй", "ей", "эй", "ий", "ый", "ой", "уй", "юй", };
                        foreach (string ending in EndingStrings)
                        {
                            if (Result.EndsWith(ending))
                            {
                                Result = (IsMale == true) ? Result.Replace("й", "евич") : Result.Replace("й", "евна");
                                Perfomed = true;
                                break;
                            }
                        }
                    }
                    break;
                case 5:
                    {
                        EndingStrings = new string[] { "ай", "яй", "ей", "эй", "ий", "ый", "ой", "уй", "юй", };
                        foreach (string ending in EndingStrings)
                        {
                            if (Result.EndsWith(ending))
                            {
                                Result = (IsMale == true) ? Result.Replace("й", "евич") : Result.Replace("й", "евна");
                                Perfomed = true;
                                break;
                            }
                        }
                    }
                    break;
            }
            return Result;
        }
        #endregion
        #region Buttons // Кнопки
        //Кнопка сгенерировать пользователя
        private void ButtonUserGenerate_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            //Get collection where sex is selected
            switch (SelectedSexComboBox.SelectedItem.ToString())
            {
                case "Мужской":
                    {
                        FirstName[] fName = firstNamesFromDb.FindAll((s) => s.IsMale == true).ToArray();
                        if(fName.Length!=0)
                            FirstNameTextEdit.Text = fName[random.Next(0, fName.Length)].FirstNameValue;
                        SecondName[] sName = secondNamesFromDb.ToArray();
                        if (sName.Length != 0)
                            SecondNameTextEdit.Text = sName[random.Next(0, sName.Length)].SecondNameValue;
                        FathersNameTextEdit.Text = CreateFathersName(fName,true);
                    }
                    break;
                case "Женский":
                    {
                        FirstName[] fName = firstNamesFromDb.FindAll((s) => s.IsMale == false).ToArray();
                        if (fName.Length != 0)
                            FirstNameTextEdit.Text = fName[random.Next(0, fName.Length)].FirstNameValue;
                        SecondName[] sName = secondNamesFromDb.ToArray();
                        SecondNameTextEdit.Text = CreateFemaleSecondName(sName);
                        fName = firstNamesFromDb.FindAll((s) => s.IsMale == true).ToArray();
                        FathersNameTextEdit.Text = CreateFathersName(fName, false);
                    }
                    break;
            }
        }        
        //Кнопка копировать
        private void copyButtonClick(object sender, System.EventArgs e)
        {
            if ((sender is SimpleButton simpleButton) && simpleButton.Tag.ToString().Contains("Copy"))
            {
                switch (simpleButton.Name)
                {
                    case "copyButtonFirstName":
                            Clipboard.SetText(FirstNameTextEdit.Text);
                        break;
                    case "copyButtonSecondName":
                            Clipboard.SetText(SecondNameTextEdit.Text);
                        break;
                    case "copyButtonFathersName":
                        Clipboard.SetText(FathersNameTextEdit.Text);
                        break;
                    case "copyAllBasic":
                        Clipboard.SetText($"{FirstNameTextEdit.Text} {SecondNameTextEdit.Text} {FathersNameTextEdit.Text}");
                        break;
                }
                this.ActiveControl = null;
            }
        }
        //Кнопка переключения панели базовое инфо
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
        #endregion
        #region Events // События
        //Смена текста в базовом инфо
        private void TextEdit_TextChanged(object sender, EventArgs e)
        {
            //Кнопка ФИО
            if (!string.IsNullOrWhiteSpace(FirstNameTextEdit.Text) &&
                !string.IsNullOrWhiteSpace(SecondNameTextEdit.Text) &&
                !string.IsNullOrWhiteSpace(FathersNameTextEdit.Text))
                copyAllBasic.Enabled = true;
            else
                copyAllBasic.Enabled = false;
            //Кнопки Ф.. И.. О..
            if (sender is TextEdit edit)
            {
                var buttons = BasicInfoPanel.Controls.OfType<SimpleButton>();
                foreach (SimpleButton button in buttons)
                {
                    if (button.Tag == null) continue;
                    if (!button.Tag.ToString().Contains(edit.Tag.ToString())) continue;
                    button.Enabled = string.IsNullOrWhiteSpace(edit.Text) ? false : true;
                }
            }
        }
        #endregion
    }
}