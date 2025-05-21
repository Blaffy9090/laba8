namespace WinFormsApp1
{
    partial class FormAdd
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
            if (disposing && (components != null))
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
            Name = new TextBox();
            Description = new TextBox();
            Price = new TextBox();
            Category = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.Location = new Point(151, 12);
            Name.Name = "Name";
            Name.Size = new Size(121, 23);
            Name.TabIndex = 0;
            // 
            // Description
            // 
            Description.Location = new Point(151, 56);
            Description.Name = "Description";
            Description.Size = new Size(121, 23);
            Description.TabIndex = 0;
            // 
            // Price
            // 
            Price.Location = new Point(151, 103);
            Price.Name = "Price";
            Price.Size = new Size(121, 23);
            Price.TabIndex = 0;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Location = new Point(151, 153);
            Category.Name = "Category";
            Category.Size = new Size(121, 23);
            Category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 59);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 106);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 156);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 2;
            label4.Text = "Категория";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button1
            // 
            button1.Location = new Point(167, 234);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 3;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 234);
            button2.Name = "button2";
            button2.Size = new Size(90, 23);
            button2.TabIndex = 3;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Category);
            Controls.Add(Price);
            Controls.Add(Description);
            Controls.Add(Name);
            Text = "FormAdd";
            Load += FormAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name;
        private TextBox Description;
        private TextBox Price;
        private ComboBox Category;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private Button button2;
    }
}