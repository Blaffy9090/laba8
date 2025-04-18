using WinFormsApp1.Models;

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

        }

        public void LoadData()
        {
            using (lab8YazikiContext db = new lab8YazikiContext())
            {
                orderGridView.DataSource = db.Orders.Select(d => new { Id = d.Id, Amount = d.Amount, Date = d.OrderDate, Product = d.Product.Name, Sum = d.Amount * d.Product.Price }).ToList();

                orderGridView!.Columns["Id"]!.Visible = false;
                orderGridView!.Columns["Id"]!.DisplayIndex = 0;

                orderGridView!.Columns["Amount"]!.DisplayIndex = 3;
                orderGridView!.Columns["Amount"]!.HeaderText = "Сумма";

                orderGridView!.Columns["Date"]!.DisplayIndex = 2;
                orderGridView!.Columns["Date"]!.HeaderText = "Дата";

                orderGridView!.Columns["Product"]!.DisplayIndex = 1;
                orderGridView!.Columns["Product"]!.HeaderText = "Товар";

                orderGridView.Refresh();
            }

            /*
			    public int Id { get; set; }

				public int? ProductId { get; set; }

				public int Amount { get; set; }

				public DateOnly OrderDate { get; set; }

				public double Sum { get; set; }

				public virtual Product Product { get; set; }
			 */
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
            try {
                orderGridView.CurrentCell = orderGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                orderGridView.Rows[e.RowIndex].Selected = true;
                orderGridView.Focus();
            }
            catch
            {

            }
        }
    }
}
