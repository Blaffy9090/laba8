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
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            productToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // orderGridView
            // 
            orderGridView.AllowUserToAddRows = false;
            orderGridView.AllowUserToDeleteRows = false;
            orderGridView.AllowUserToResizeColumns = false;
            orderGridView.AllowUserToResizeRows = false;
            orderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, categoryToolStripMenuItem, удалитьToolStripMenuItem, редактироватьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(155, 92);
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(154, 22);
            productToolStripMenuItem.Text = "Товар";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(154, 22);
            categoryToolStripMenuItem.Text = "Категории";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(154, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(154, 22);
            редактироватьToolStripMenuItem.Text = "Редактировать";
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
	}
}
