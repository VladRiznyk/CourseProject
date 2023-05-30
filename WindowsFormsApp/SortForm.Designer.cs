namespace WindowsFormsApp
{
    partial class SortForm
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
            this.OrderSelect = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SortList = new System.Windows.Forms.ListBox();
            this.SortButton = new System.Windows.Forms.Button();
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
            this.ColumnSelect.Location = new System.Drawing.Point(13, 13);
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.ColumnSelect.TabIndex = 0;
            // 
            // OrderSelect
            // 
            this.OrderSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderSelect.FormattingEnabled = true;
            this.OrderSelect.Items.AddRange(new object[] {
            "За зростанням",
            "За зменшенням"});
            this.OrderSelect.Location = new System.Drawing.Point(140, 13);
            this.OrderSelect.Name = "OrderSelect";
            this.OrderSelect.Size = new System.Drawing.Size(121, 21);
            this.OrderSelect.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(268, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(349, 13);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Видалити";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SortList
            // 
            this.SortList.FormattingEnabled = true;
            this.SortList.Location = new System.Drawing.Point(13, 41);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(411, 134);
            this.SortList.TabIndex = 4;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(349, 181);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 5;
            this.SortButton.Text = "Сортувати";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 215);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.OrderSelect);
            this.Controls.Add(this.ColumnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Сортування";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ColumnSelect;
        private System.Windows.Forms.ComboBox OrderSelect;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox SortList;
        private System.Windows.Forms.Button SortButton;
    }
}