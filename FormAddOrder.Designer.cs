namespace WinFormsApp1
{
    partial class FormAddOrder
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Sum = new TextBox();
            Amount = new TextBox();
            Product = new ComboBox();
            productBindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button1 = new Button();
            button2 = new Button();
            productBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Sum
            // 
            Sum.Location = new Point(151, 156);
            Sum.Name = "Sum";
            Sum.Size = new Size(121, 23);
            Sum.TabIndex = 0;
            // 
            // Amount
            // 
            Amount.Location = new Point(151, 103);
            Amount.Name = "Amount";
            Amount.Size = new Size(121, 23);
            Amount.TabIndex = 0;
            // 
            // Product
            // 
            Product.DataSource = productBindingSource1;
            Product.FormattingEnabled = true;
            Product.Location = new Point(151, 12);
            Product.Name = "Product";
            Product.Size = new Size(121, 23);
            Product.TabIndex = 1;
            // 
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(Models.Product);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 59);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 106);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 156);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Сумма";
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(151, 53);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2025, 5, 27, 0, 0, 0, 0);
            // 
            // FormAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Product);
            Controls.Add(Amount);
            Controls.Add(Sum);
            Name = "FormAddOrder";
            Text = "FormAddOrder";
            Load += FormAddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox Sum;
        private TextBox Amount;
        private ComboBox Product;
        private Label label2;
        private Label label3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private Button button2;
        public Label label1;
        private BindingSource productBindingSource1;
        private BindingSource productBindingSource;
        private DateTimePicker dateTimePicker1;
    }
}