namespace WindowsFormsApp
{
    partial class InputForm
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
            this.FormTitle = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.LinkField = new System.Windows.Forms.TextBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.RegionField = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CompanyField = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SalaryField = new System.Windows.Forms.NumericUpDown();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.ExpireField = new System.Windows.Forms.DateTimePicker();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryField)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(3, 0);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(202, 24);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Додавання вакансії";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 36);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Назва вакансії";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(3, 58);
            this.NameField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(397, 22);
            this.NameField.TabIndex = 2;
            // 
            // LinkField
            // 
            this.LinkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkField.Location = new System.Drawing.Point(3, 111);
            this.LinkField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.LinkField.Name = "LinkField";
            this.LinkField.Size = new System.Drawing.Size(397, 22);
            this.LinkField.TabIndex = 3;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(3, 89);
            this.LinkLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(155, 16);
            this.LinkLabel.TabIndex = 4;
            this.LinkLabel.Text = "Посилання на вебсайт";
            this.LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionLabel.Location = new System.Drawing.Point(3, 142);
            this.RegionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(49, 16);
            this.RegionLabel.TabIndex = 5;
            this.RegionLabel.Text = "Регіон";
            this.RegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegionField
            // 
            this.RegionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionField.Location = new System.Drawing.Point(3, 164);
            this.RegionField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.RegionField.Name = "RegionField";
            this.RegionField.Size = new System.Drawing.Size(397, 22);
            this.RegionField.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FormTitle);
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.NameField);
            this.flowLayoutPanel1.Controls.Add(this.LinkLabel);
            this.flowLayoutPanel1.Controls.Add(this.LinkField);
            this.flowLayoutPanel1.Controls.Add(this.RegionLabel);
            this.flowLayoutPanel1.Controls.Add(this.RegionField);
            this.flowLayoutPanel1.Controls.Add(this.CompanyLabel);
            this.flowLayoutPanel1.Controls.Add(this.CompanyField);
            this.flowLayoutPanel1.Controls.Add(this.SalaryLabel);
            this.flowLayoutPanel1.Controls.Add(this.SalaryField);
            this.flowLayoutPanel1.Controls.Add(this.ExpireLabel);
            this.flowLayoutPanel1.Controls.Add(this.ExpireField);
            this.flowLayoutPanel1.Controls.Add(this.PhoneLabel);
            this.flowLayoutPanel1.Controls.Add(this.PhoneField);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionLabel);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionField);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 641);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(3, 195);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(106, 16);
            this.CompanyLabel.TabIndex = 7;
            this.CompanyLabel.Text = "Назва компанії";
            this.CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyField
            // 
            this.CompanyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyField.Location = new System.Drawing.Point(3, 217);
            this.CompanyField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.CompanyField.Name = "CompanyField";
            this.CompanyField.Size = new System.Drawing.Size(397, 22);
            this.CompanyField.TabIndex = 8;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLabel.Location = new System.Drawing.Point(3, 248);
            this.SalaryLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(71, 16);
            this.SalaryLabel.TabIndex = 9;
            this.SalaryLabel.Text = "Зарплата";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalaryField
            // 
            this.SalaryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryField.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SalaryField.Location = new System.Drawing.Point(3, 270);
            this.SalaryField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.SalaryField.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.Size = new System.Drawing.Size(397, 22);
            this.SalaryField.TabIndex = 10;
            // 
            // ExpireLabel
            // 
            this.ExpireLabel.AutoSize = true;
            this.ExpireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireLabel.Location = new System.Drawing.Point(3, 301);
            this.ExpireLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ExpireLabel.Name = "ExpireLabel";
            this.ExpireLabel.Size = new System.Drawing.Size(115, 16);
            this.ExpireLabel.TabIndex = 11;
            this.ExpireLabel.Text = "Дата закінчення";
            this.ExpireLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExpireField
            // 
            this.ExpireField.CustomFormat = "";
            this.ExpireField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireField.Location = new System.Drawing.Point(3, 323);
            this.ExpireField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.ExpireField.Name = "ExpireField";
            this.ExpireField.Size = new System.Drawing.Size(397, 22);
            this.ExpireField.TabIndex = 12;
            this.ExpireField.Value = new System.DateTime(2023, 2, 13, 0, 0, 0, 0);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(3, 354);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(270, 16);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Номери телефону (Відокремлені комою)";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.Location = new System.Drawing.Point(3, 376);
            this.PhoneField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.PhoneField.Multiline = true;
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PhoneField.Size = new System.Drawing.Size(397, 54);
            this.PhoneField.TabIndex = 20;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 439);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(95, 16);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Опис вакансії";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescriptionField
            // 
            this.DescriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionField.Location = new System.Drawing.Point(3, 461);
            this.DescriptionField.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionField.Size = new System.Drawing.Size(397, 135);
            this.DescriptionField.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 608);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 30);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(3, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(192, 24);
            this.SubmitButton.TabIndex = 17;
            this.SubmitButton.Text = "Додати вакансію";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(201, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(193, 24);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 660);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryField)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox LinkField;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.TextBox RegionField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CompanyField;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.NumericUpDown SalaryField;
        private System.Windows.Forms.Label ExpireLabel;
        private System.Windows.Forms.DateTimePicker ExpireField;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionField;
        private System.Windows.Forms.Button SubmitButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}