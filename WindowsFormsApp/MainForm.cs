using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        // Список вакансій
        private JobList jobList;
        // ID останній вакансії
        private int lastID;

        public MainForm()
        {
            InitializeComponent();

            // Ініціалізація списку вакансій
            jobList = new JobList();

            try
            {
                jobList.ReadFromBinary("jobs.dat");
            }
            catch
            {
                jobList.Jobs = new BindingList<Job>();
            }

            // Зв'язати список вакансій з елементом DataGridView
            DataTable.DataSource = jobList.Jobs;

            // Не відображати заголовки рядків у DataGridView
            DataTable.RowHeadersVisible = false;
            // Повне виділення рядку
            DataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Встановлення назв колонок
            DataTable.Columns[0].HeaderText = "ID";
            DataTable.Columns[1].HeaderText = "Вебсайт";
            DataTable.Columns[2].HeaderText = "Назва";
            DataTable.Columns[3].HeaderText = "Регіон";
            DataTable.Columns[4].HeaderText = "Опис";
            DataTable.Columns[5].HeaderText = "Дата публікації";
            DataTable.Columns[6].HeaderText = "Зарплата";
            DataTable.Columns[7].HeaderText = "Компанія";
            DataTable.Columns[8].HeaderText = "Дата закінчення";
            DataTable.Columns[9].HeaderText = "Тип вакансії";
            DataTable.Columns[10].HeaderText = "Номери телефону";

            // Встановлення ширин колонок
            DataTable.Columns[0].Width = 60;
            DataTable.Columns[1].Width = 200;
            DataTable.Columns[2].Width = 200;
            DataTable.Columns[3].Width = 160;
            DataTable.Columns[4].Width = 240;
            DataTable.Columns[5].Width = 110;
            DataTable.Columns[6].Width = 82;
            DataTable.Columns[7].Width = 160;
            DataTable.Columns[8].Width = 116;
            DataTable.Columns[9].Width = 100;
            DataTable.Columns[10].Width = 180;
        }

        /// <summary>
        /// Змінити форматування клітинок, що містять об'єкт типу DateTime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(DataTable.Columns[e.ColumnIndex].ValueType == typeof(DateTime) && e.Value != null)
            {
                e.Value = ((DateTime)e.Value).ToString("dd.MM.yyyy");
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// Додання нової вакансії до списку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Створення форми для введення даних
            InputForm inputForm = new InputForm();
            // Задання ID вакансії, що буде додано
            inputForm.NextID = lastID;

            // Показати форму і перевірити її статус
            // Якщо форму боло закрито або натиснуто на кнопку "Скасувати"
            if(inputForm.ShowDialog() == DialogResult.Cancel)
            {
                // Звільнити ресурси форми
                inputForm.Dispose();
                // Завершити роботу метода
                return;
            }

            // Додати нову вакансію до списку
            jobList.Jobs.Add(inputForm.ReturnValue);
            // Збільшити лічильник ID
            lastID++;
            // Звільнити ресурси форми
            inputForm.Dispose();
            // Зберегти список
            jobList.WriteToBinary("jobs.dat");
        }

        /// <summary>
        /// Редагування виділеної вакансії
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            // Не дозволити редагування, якщо виділено декілька рядків
            if(DataTable.SelectedRows.Count != 1)
            {
                // Вивести повідомлення про помилку
                MessageBox.Show("Тільки один рядок може бути виділено для зміни!",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Завершити роботу метода
                return;
            }

            // Отримання видиленої вакансії
            Job job = jobList.Jobs[DataTable.SelectedRows[0].Index];
            // Створення форми для введення даних
            InputForm inputForm = new InputForm(job.Name, job.Link, job.Region,
                job.CompanyName, job.Salary, job.ExpirationDate, job.Phone, job.Description);
            // Задання ID вакансії, що буде змінено
            inputForm.NextID = job.ID;

            // Показати форму і перевірити її статус
            // Якщо форму боло закрито або натиснуто на кнопку "Скасувати"
            if(inputForm.ShowDialog() == DialogResult.Cancel)
            {
                // Звільнити ресурси форми
                inputForm.Dispose();
                // Завершити роботу метода
                return;
            }

            // Оновити вакансію
            jobList.Jobs[DataTable.SelectedRows[0].Index] = inputForm.ReturnValue;
            // Збільшити лічильник ID
            lastID++;
            // Звільнити ресурси форми
            inputForm.Dispose();
            // Зберегти список
            jobList.WriteToBinary("jobs.dat");
        }

        /// <summary>
        /// Видалення виділених вакансій
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in DataTable.SelectedRows)
            {
                jobList.Jobs.RemoveAt(row.Index);
            }

            // Зберегти список
            jobList.WriteToBinary("jobs.dat");
        }

        /// <summary>
        /// Очищення списку вакансій
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            jobList.Jobs.Clear();
            lastID = 0;

            // Зберегти список
            jobList.WriteToBinary("jobs.dat");
        }

        /// <summary>
        /// Імпортувати список з XML файлу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportXMLButton_Click(object sender, EventArgs e)
        {
            // Вивести повідомлення про перезапис даних
            DialogResult result = MessageBox.Show("Дані будуть перезаписані. Продовжити?",
                "Перезапис даних", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Завершити роботу метода якщо користувач
            // не дав згоду на перезапис даних
            if(result == DialogResult.No)
            {
                return;
            }

            // Типи файлів для OpenFileDialog
            openFileDialog.Filter = "XML файл (*.xml)|*.xml|Усі файли (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Відкрити вікно для вибору файлу
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Зчитати дані з файлу
                    jobList.ReadFromXML(openFileDialog.FileName);
                    // Оновити DataGridView
                    DataTable.DataBindings.Clear();
                    DataTable.DataSource = jobList.Jobs;
                }
                catch
                {
                    // Вивести повідомлення про помилку
                    MessageBox.Show("Не вдалося імпортувати дані!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Зберегти список
            jobList.WriteToBinary("jobs.dat");
        }

        /// <summary>
        /// Експортувати список у XML файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportXMLButton_Click(object sender, EventArgs e)
        {
            // Якщо список не містить вакансій
            if(jobList.Jobs.Count == 0)
            {
                // Вивести повідомлення про помилку
                MessageBox.Show("Список порожній!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Завершити роботу метода
                return;
            }

            // Типи файлів для SaveFileDialog
            saveFileDialog.Filter = "XML файл (*.xml)|*.xml|Усі файли (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            // Відкрити вікно для вибору файлу
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Записати дані у файл
                    jobList.WriteToXML(saveFileDialog.FileName);
                }
                catch
                {
                    // Вивести повідомлення про помилку
                    MessageBox.Show("Не вдалося експортувати дані!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Експортувати список у PDF файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            // Якщо список не містить вакансій
            if(jobList.Jobs.Count == 0)
            {
                // Вивести повідомлення про помилку
                MessageBox.Show("Список порожній!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Завершити роботу метода
                return;
            }

            // Типи файлів для SaveFileDialog
            saveFileDialog.Filter = "PDF файл (*.pdf)|*.pdf|Усі файли (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;

            // Відкрити вікно для вибору файлу
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Записати дані у файл
                    jobList.WriteToPDF(saveFileDialog.FileName);
                }
                catch
                {
                    // Вивести повідомлення про помилку
                    MessageBox.Show("Не вдалося експортувати дані!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Сортувати список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            // Створення форми
            SortForm sortForm = new SortForm();

            // Показати форму і перевірити її статус
            // Якщо форму боло закрито або натиснуто на кнопку "Скасувати"
            if(sortForm.ShowDialog() == DialogResult.Cancel)
            {
                // Звільнити ресурси форми
                sortForm.Dispose();
                // Завершити роботу метода
                return;
            }

            // Відсортувати список
            List<Job> sortedJobs = this.jobList.Sort(sortForm.ReturnValue);

            // Оновити список
            for(int i = 0; i < jobList.Jobs.Count; i++)
            {
                jobList.Jobs[i] = sortedJobs[i];
            }

            // Звільнити ресурси форми
            sortForm.Dispose();
        }

        /// <summary>
        /// Пошук записів у списку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            // Створення форми
            FindForm findForm = new FindForm();

            // Показати форму і перевірити її статус
            // Якщо форму боло закрито або натиснуто на кнопку "Скасувати"
            if(findForm.ShowDialog() == DialogResult.Cancel)
            {
                // Звільнити ресурси форми
                findForm.Dispose();
                // Завершити роботу метода
                return;
            }

            // Виконати пошук
            List<Job> jobs = this.jobList.Find(findForm.ReturnValue);

            // Оновити список
            this.jobList.Jobs.Clear();

            if(jobs != null)
            {
                for(int i = 0; i < jobs.Count; i++)
                {
                    this.jobList.Jobs.Add(jobs[i]);
                }
            }

            // Звільнити ресурси форми
            findForm.Dispose();
        }

        /// <summary>
        /// Фільтрувати список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            // Створення форми
            FilterForm filterForm = new FilterForm();

            // Показати форму і перевірити її статус
            // Якщо форму боло закрито або натиснуто на кнопку "Скасувати"
            if(filterForm.ShowDialog() == DialogResult.Cancel)
            {
                // Звільнити ресурси форми
                filterForm.Dispose();
                // Завершити роботу метода
                return;
            }

            // Фільтрація списку
            List<Job> jobs = this.jobList.Filter(filterForm.ReturnValue);

            // Оновити список
            this.jobList.Jobs.Clear();

            if(jobs != null)
            {
                for(int i = 0; i < jobs.Count; i++)
                {
                    this.jobList.Jobs.Add(jobs[i]);
                }
            }

            // Звільнити ресурси форми
            filterForm.Dispose();
        }
    }
}