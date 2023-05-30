using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class SortForm : Form
    {
        // Список сортувань
        public List<KeyValuePair<int, int>> ReturnValue { get; private set; }

        public SortForm()
        {
            InitializeComponent();
            ColumnSelect.SelectedIndex = 0;
            OrderSelect.SelectedIndex = 0;
            ReturnValue = new List<KeyValuePair<int, int>>();
        }

        /// <summary>
        /// Додати
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.ReturnValue.Add(new KeyValuePair<int, int>(ColumnSelect.SelectedIndex,
                OrderSelect.SelectedIndex));
            SortList.Items.Add(ColumnSelect.Items[ColumnSelect.SelectedIndex] + ", " +
                OrderSelect.Items[OrderSelect.SelectedIndex]);
        }

        /// <summary>
        /// Видалити
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(SortList.SelectedIndex != -1)
            {
                this.ReturnValue.RemoveAt(SortList.SelectedIndex);
                this.SortList.Items.RemoveAt(SortList.SelectedIndex);
            }
        }

        /// <summary>
        /// Відсортувати список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}