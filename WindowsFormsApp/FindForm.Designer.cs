namespace WindowsFormsApp
{
    partial class FindForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
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
            this.ColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.ColumnSelect.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(213, 38);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(139, 12);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(149, 20);
            this.ValueBox.TabIndex = 7;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 72);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ColumnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Пошук";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColumnSelect;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ValueBox;
    }
}