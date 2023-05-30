using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class InputForm : Form
    {
        // ID для поточного запису
        public int NextID { get; set; }
        // Повертане значення для MainForm
        public Job ReturnValue { get; private set; }

        public InputForm()
        {
            InitializeComponent();

            FormTitle.Text = "Додавання вакансії";
            SubmitButton.Text = "Додати вакансію";
            ExpireField.Value = DateTime.Now;
        }

        public InputForm(string name, string link, string region, string company,
            ulong salary, DateTime date, string phone, string description) : this()
        {
            FormTitle.Text = "Редагування вакансії";
            SubmitButton.Text = "Оновити дані";

            NameField.Text = name;
            LinkField.Text = link;
            RegionField.Text = region;
            CompanyField.Text = company;
            SalaryField.Value = salary;
            ExpireField.Value = date;
            PhoneField.Text = phone;
            DescriptionField.Text = description;
        }

        /// <summary>
        /// Перевірка значень та додавання вакансії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Задання кольору написів за замовчуванням
            NameLabel.ForeColor = SystemColors.ControlText;
            LinkLabel.ForeColor = SystemColors.ControlText;
            RegionLabel.ForeColor = SystemColors.ControlText;
            CompanyLabel.ForeColor = SystemColors.ControlText;
            ExpireLabel.ForeColor = SystemColors.ControlText;
            PhoneLabel.ForeColor = SystemColors.ControlText;

            // Перевірка коректності назви вакансії
            if(!Job.ValidateString(NameField.Text))
            {
                isValid = false;
                NameLabel.ForeColor = Color.Red;
            }

            // Перевірка коректності посилання на вебсайт
            if(!Job.ValidateLink(LinkField.Text))
            {
                isValid = false;
                LinkLabel.ForeColor = Color.Red;
            }

            // Перевірка коректності регіону
            if(!Job.ValidateString(RegionField.Text))
            {
                isValid = false;
                RegionLabel.ForeColor = Color.Red;
            }

            // Перевірка коректності назви компанії
            if(!Job.ValidateString(CompanyField.Text))
            {
                isValid = false;
                CompanyLabel.ForeColor = Color.Red;
            }

            // Перевірка коректності дати закінчення
            if(!Job.ValidateDate(ExpireField.Value))
            {
                isValid = false;
                ExpireLabel.ForeColor = Color.Red;
            }

            // Розподіл номерів телефонів у масив
            string[] phones = PhoneField.Text.Split(',').Select(s => s.Trim()).ToArray();

            // Перевірка коректності номерів телефонів
            foreach(string phone in phones)
            {
                if(!Job.ValidatePhone(phone))
                {
                    isValid = false;
                    PhoneLabel.ForeColor = Color.Red;
                    break;
                }
            }

            // Перевірка коректності опису вакансії
            if(DescriptionField.Text == null)
            {
                DescriptionField.Text = string.Empty;
            }

            // Якщо всі поля коректні, створити нову вакансію як повертане значення
            if(isValid)
            {
                this.ReturnValue = new Job()
                {
                    ID = this.NextID,
                    Link = LinkField.Text,
                    Name = NameField.Text,
                    Region = RegionField.Text,
                    Description = DescriptionField.Text,
                    PublicationDate = DateTime.Now,
                    Salary = (ulong)SalaryField.Value,
                    CompanyName = CompanyField.Text,
                    ExpirationDate = ExpireField.Value,
                    Type = "Вакансія",
                    Phone = PhoneField.Text
                };

                // Закрити форму
                this.Close();

                // Зміна результату модального вікна на 'OK'
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Відміна додавання/редагування вакансії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Зміна результату модального вікна на 'Cancel'
            this.DialogResult = DialogResult.Cancel;
            // Закрити форму
            this.Close();
        }
    }
}