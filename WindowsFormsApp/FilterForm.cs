using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FilterForm : Form
    {
        // Стовбець - діапазон значень
        public KeyValuePair<int, object> ReturnValue { get; set; }

        public FilterForm()
        {
            InitializeComponent();
            ColumnSelect.SelectedIndex = 0;
            MinValue.Minimum = 0;
            MinValue.Maximum = int.MaxValue;
            MaxValue.Minimum = 0;
            MaxValue.Maximum = int.MaxValue;
        }

        /// <summary>
        /// Переключити доступність полів для введення
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinValue.Enabled = false;
            MaxValue.Enabled = false;
            DateMinField.Enabled = false;
            DateMaxField.Enabled = false;
            TextField.Enabled = false;

            if(ColumnSelect.SelectedIndex == 0) // ID
            {
                MinValue.Enabled = true;
                MaxValue.Enabled = true;
                MinValue.Minimum = 0;
                MinValue.Maximum = int.MaxValue;
                MaxValue.Minimum = 0;
                MaxValue.Maximum = int.MaxValue;
            }
            else if(ColumnSelect.SelectedIndex == 6) // Зарплата
            {
                MinValue.Enabled = true;
                MaxValue.Enabled = true;
                MinValue.Minimum = 0;
                MinValue.Maximum = ulong.MaxValue;
                MaxValue.Minimum = 0;
                MaxValue.Maximum = ulong.MaxValue;
            }
            else if(ColumnSelect.SelectedIndex == 5 || // Дата публікації
                ColumnSelect.SelectedIndex == 8) // Дата закінчення
            {
                DateMinField.Enabled = true;
                DateMaxField.Enabled = true;
            }
            else // Рядки
            {
                TextField.Enabled = true;
            }
        }

        /// <summary>
        /// Фільтрувати список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            object value;

            if(ColumnSelect.SelectedIndex == 0) // ID
            {
                value = new int[2] { (int)MinValue.Value, (int)MaxValue.Value };
            }
            else if(ColumnSelect.SelectedIndex == 6) // Зарплата
            {
                value = new ulong[2] { (ulong)MinValue.Value, (ulong)MaxValue.Value };
            }
            else if(ColumnSelect.SelectedIndex == 5 || // Дата публікації
                ColumnSelect.SelectedIndex == 8) // Дата закінчення
            {
                value = new DateTime[2] { DateMinField.Value, DateMaxField.Value };
            }
            else // Рядки
            {
                value = TextField.Text;
            }

            this.ReturnValue = new KeyValuePair<int, object>(ColumnSelect.SelectedIndex, value);

            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}