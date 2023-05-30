namespace WindowsFormsApp
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
            if(disposing && (components != null))
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ImportXMLButton = new System.Windows.Forms.Button();
            this.ExportXMLButton = new System.Windows.Forms.Button();
            this.ExportPDFButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Додати нову вакансію";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 41);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(172, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редагувати виділену вакансію";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 70);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Видалити виділену вакансію";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 99);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(172, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Очистити список вакансій";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ImportXMLButton
            // 
            this.ImportXMLButton.Location = new System.Drawing.Point(190, 12);
            this.ImportXMLButton.Name = "ImportXMLButton";
            this.ImportXMLButton.Size = new System.Drawing.Size(172, 23);
            this.ImportXMLButton.TabIndex = 4;
            this.ImportXMLButton.Text = "Імпорт списку з XML файлу";
            this.ImportXMLButton.UseVisualStyleBackColor = true;
            this.ImportXMLButton.Click += new System.EventHandler(this.ImportXMLButton_Click);
            // 
            // ExportXMLButton
            // 
            this.ExportXMLButton.Location = new System.Drawing.Point(190, 41);
            this.ExportXMLButton.Name = "ExportXMLButton";
            this.ExportXMLButton.Size = new System.Drawing.Size(172, 23);
            this.ExportXMLButton.TabIndex = 5;
            this.ExportXMLButton.Text = "Експорт списку у XML файл";
            this.ExportXMLButton.UseVisualStyleBackColor = true;
            this.ExportXMLButton.Click += new System.EventHandler(this.ExportXMLButton_Click);
            // 
            // ExportPDFButton
            // 
            this.ExportPDFButton.Location = new System.Drawing.Point(190, 70);
            this.ExportPDFButton.Name = "ExportPDFButton";
            this.ExportPDFButton.Size = new System.Drawing.Size(172, 23);
            this.ExportPDFButton.TabIndex = 7;
            this.ExportPDFButton.Text = "Експорт списку у PDF файл";
            this.ExportPDFButton.UseVisualStyleBackColor = true;
            this.ExportPDFButton.Click += new System.EventHandler(this.ExportPDFButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(368, 12);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(172, 23);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Сортувати список";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(368, 41);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(172, 23);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Знайти у списку";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(368, 70);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(172, 23);
            this.FilterButton.TabIndex = 10;
            this.FilterButton.Text = "Фільтрувати список";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(13, 129);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.Size = new System.Drawing.Size(527, 319);
            this.DataTable.TabIndex = 11;
            this.DataTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataTable_CellFormatting);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 460);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ExportPDFButton);
            this.Controls.Add(this.ImportXMLButton);
            this.Controls.Add(this.ExportXMLButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "Курсовий проєкт";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ImportXMLButton;
        private System.Windows.Forms.Button ExportXMLButton;
        private System.Windows.Forms.Button ExportPDFButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

