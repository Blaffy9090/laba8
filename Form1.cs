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
				orderGridView.DataSource = db.Orders.Select(d=>new { Id = d.Id, Amount = d.Amount, Date = d.OrderDate });
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

	}
}
