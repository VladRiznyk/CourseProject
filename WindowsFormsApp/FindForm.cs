using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FindForm : Form
    {
        // Стовбець - значення
        public KeyValuePair<int, string> ReturnValue { get; private set; }

        public FindForm()
        {
            InitializeComponent();
            ColumnSelect.SelectedIndex = 0;
        }

        /// <summary>
        /// Пошук
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            String value = "";
            bool result = true;

            if(ColumnSelect.SelectedIndex == 0) // ID
            {
                int intval;
                result = int.TryParse(ValueBox.Text, out intval);

                if(result)
                {
                    value = intval.ToString();
                }
            }
            else if(ColumnSelect.SelectedIndex == 6) // Зарплата
            {
                ulong ulongval;
                result = ulong.TryParse(ValueBox.Text, out ulongval);

                if(result)
                {
                    value = ulongval.ToString();
                }
            }
            else if(ColumnSelect.SelectedIndex == 5 || ColumnSelect.SelectedIndex == 8) // Дати
            {
                DateTime dt;
                result = DateTime.TryParse(ValueBox.Text, out dt);

                if(result)
                {
                    value = dt.ToString();
                }
            }
            else // Рядки
            {
                value = ValueBox.Text;
            }

            if(result)
            {
                this.ReturnValue = new KeyValuePair<int, string>(ColumnSelect.SelectedIndex, value);
            }
            else
            {
                MessageBox.Show("Некоректне значення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}