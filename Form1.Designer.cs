namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            orderGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            productToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem1 = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem1 = new ToolStripMenuItem();
            редактироватьToolStripMenuItem2 = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // orderGridView
            // 
            orderGridView.AllowUserToAddRows = false;
            orderGridView.AllowUserToDeleteRows = false;
            orderGridView.AllowUserToResizeColumns = false;
            orderGridView.AllowUserToResizeRows = false;
            orderGridView.AutoGenerateColumns = false;
            orderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            orderGridView.DataSource = orderBindingSource;
            orderGridView.Location = new Point(22, 72);
            orderGridView.MultiSelect = false;
            orderGridView.Name = "orderGridView";
            orderGridView.ReadOnly = true;
            orderGridView.ScrollBars = ScrollBars.Vertical;
            orderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderGridView.Size = new Size(748, 313);
            orderGridView.TabIndex = 0;
            orderGridView.CellMouseClick += orderGridView_CellMouseClick;
            orderGridView.CellMouseDown += orderGridView_CellMouseDown;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Models.Order);
            // 
            // button1
            // 
            button1.Location = new Point(22, 406);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(660, 406);
            button2.Name = "button2";
            button2.Size = new Size(110, 25);
            button2.TabIndex = 2;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, categoryToolStripMenuItem, удалитьToolStripMenuItem, редактироватьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 114);
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, редактироватьToolStripMenuItem1 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(180, 22);
            productToolStripMenuItem.Text = "Товар";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(154, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem1
            // 
            редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            редактироватьToolStripMenuItem1.Size = new Size(154, 22);
            редактироватьToolStripMenuItem1.Text = "Редактировать";
            редактироватьToolStripMenuItem1.Click += редактироватьToolStripMenuItem1_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem1, редактироватьToolStripMenuItem2 });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(180, 22);
            categoryToolStripMenuItem.Text = "Категории";
            // 
            // создатьToolStripMenuItem1
            // 
            создатьToolStripMenuItem1.Name = "создатьToolStripMenuItem1";
            создатьToolStripMenuItem1.Size = new Size(154, 22);
            создатьToolStripMenuItem1.Text = "Создать";
            создатьToolStripMenuItem1.Click += создатьToolStripMenuItem1_Click;
            // 
            // редактироватьToolStripMenuItem2
            // 
            редактироватьToolStripMenuItem2.Name = "редактироватьToolStripMenuItem2";
            редактироватьToolStripMenuItem2.Size = new Size(154, 22);
            редактироватьToolStripMenuItem2.Text = "Редактировать";
            редактироватьToolStripMenuItem2.Click += редактироватьToolStripMenuItem2_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(180, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(orderGridView);
            Name = "Form1";
            Text = "Заказы";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)orderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView orderGridView;
		private Button button1;
		private Button button2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem productToolStripMenuItem;
		private ToolStripMenuItem categoryToolStripMenuItem;
		private ToolStripMenuItem удалитьToolStripMenuItem;
		private ToolStripMenuItem редактироватьToolStripMenuItem;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem создатьToolStripMenuItem1;
        private ToolStripMenuItem редактироватьToolStripMenuItem2;
    }
}
