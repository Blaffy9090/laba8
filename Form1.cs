using WinFormsApp1.Models;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddOrder frm = new FormAddOrder(1, 0);

            frm.Owner = this;
            frm.Show();
        }

        public void LoadData()
        {
            using (lab8YazikiContext db = new lab8YazikiContext())
            {
                this.orderGridView.DataSource = db.Orders.Select(d => new
                {
                    Id = d.Id,
                    Amount = d.Amount,
                    OrderDate = d.OrderDate,
                    Product = db.Products.FirstOrDefault(t => t.Id == d.ProductId).Name ?? "",                     
                    ProductId = d.ProductId,
                    Sum = d.Amount * d.Product.Price
                }).ToList();

                this.orderGridView!.Columns[0]!.Visible = false;
                this.orderGridView!.Columns[0]!.DisplayIndex = 0;

                this.orderGridView!.Columns[5]!.DisplayIndex = 1;
                this.orderGridView!.Columns[5]!.HeaderText = "Продукт";

                this.orderGridView!.Columns[1]!.DisplayIndex = 2;
                this.orderGridView!.Columns[1]!.HeaderText = "ProductId";

                this.orderGridView!.Columns[3]!.DisplayIndex = 3;
                this.orderGridView!.Columns[3]!.HeaderText = "Дата";

                this.orderGridView!.Columns[2]!.DisplayIndex = 4;
                this.orderGridView!.Columns[2]!.HeaderText = "Количество";

                this.orderGridView.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void orderGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1?.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void orderGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                    this.orderGridView.CurrentCell = this.orderGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                this.orderGridView.Rows[e.RowIndex].Selected = true;
                this.orderGridView.Focus();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct(1, 0);

            frm.Owner = this;
            frm.Show();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct(2, Convert.ToInt32(this.orderGridView.SelectedRows[0].Cells[2].Value));

            frm.Owner = this;
            frm.Show();
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddCategory frm = new FormAddCategory(1, 0);

            frm.Owner = this;
            frm.Show();
        }

        private void редактироватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.orderGridView.SelectedRows[0].Cells[2].Value);

            using (lab8YazikiContext db = new lab8YazikiContext())
            {
                Product prod = db.Products.First(d => d.Id == id);

                if (prod != null)
                {
                    FormAddCategory frm = new FormAddCategory(2, (int)prod.CategoryId);

                    frm.Owner = this;
                    frm.Show();
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.orderGridView.SelectedRows[0].Cells[0].Value);

            FormAddOrder frm = new FormAddOrder(2, id);

            frm.Owner = this;
            frm.Show();
        }
    }

}
