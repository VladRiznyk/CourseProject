namespace WindowsFormsApp
{
    partial class FilterForm
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
            this.ColumnSelect = new System.Windows.Forms.ComboBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.MinValue = new System.Windows.Forms.NumericUpDown();
            this.MaxValue = new System.Windows.Forms.NumericUpDown();
            this.TextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateMinField = new System.Windows.Forms.DateTimePicker();
            this.DateMaxField = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnSelect.FormattingEnabled = true;
            this.ColumnSelect.Items.AddRange(new object[] {
            "ID",
            "Вебсайт",
            "Назва",
            "Регіон",
            "Опис",
            "Дата публікації",
            "Зарплата",
            "Компанія",
            "Дата закінчення",
            "Тип вакансії",
            "Номер телефону"});
            this.ColumnSelect.Location = new System.Drawing.Point(12, 12);
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Size = new System.Drawing.Size(150, 21);
            this.ColumnSelect.TabIndex = 2;
            this.ColumnSelect.SelectedIndexChanged += new System.EventHandler(this.ColumnSelect_SelectedIndexChanged);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(193, 12);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(150, 23);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Фільтрувати";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MinValue
            // 
            this.MinValue.Location = new System.Drawing.Point(42, 41);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(100, 20);
            this.MinValue.TabIndex = 8;
            // 
            // MaxValue
            // 
            this.MaxValue.Location = new System.Drawing.Point(243, 41);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(100, 20);
            this.MaxValue.TabIndex = 9;
            // 
            // TextField
            // 
            this.TextField.Enabled = false;
            this.TextField.Location = new System.Drawing.Point(12, 96);
            this.TextField.Multiline = true;
            this.TextField.Name = "TextField";
            this.TextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextField.Size = new System.Drawing.Size(331, 198);
            this.TextField.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Мін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Макс";
            // 
            // DateMinField
            // 
            this.DateMinField.CustomFormat = "dd.MM.yyyy";
            this.DateMinField.Enabled = false;
            this.DateMinField.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMinField.Location = new System.Drawing.Point(12, 70);
            this.DateMinField.Name = "DateMinField";
            this.DateMinField.Size = new System.Drawing.Size(150, 20);
            this.DateMinField.TabIndex = 13;
            // 
            // DateMaxField
            // 
            this.DateMaxField.CustomFormat = "dd.MM.yyyy";
            this.DateMaxField.Enabled = false;
            this.DateMaxField.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateMaxField.Location = new System.Drawing.Point(193, 70);
            this.DateMaxField.Name = "DateMaxField";
            this.DateMaxField.Size = new System.Drawing.Size(150, 20);
            this.DateMaxField.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(168, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "—";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateMaxField);
            this.Controls.Add(this.DateMinField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ColumnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Фільтрація";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColumnSelect;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.NumericUpDown MinValue;
        private System.Windows.Forms.NumericUpDown MaxValue;
        private System.Windows.Forms.TextBox TextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateMinField;
        private System.Windows.Forms.DateTimePicker DateMaxField;
        private System.Windows.Forms.Label label3;
    }
}