using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{

    public partial class FormAddProduct : Form
    {
        int oper { get; set; }

        int productID { get; set; }

        public FormAddProduct(int oper, int productID)
        {
            InitializeComponent();
            this.oper = oper;
            this.productID = productID;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                button1.Text = "Добавить";
                this.Text = "Добавить продукт";
                this.Name.Text = "";
                this.Description.Text = "";
                this.Price.Text = "";
                this.Category.Text = "";
            }
            else
            {
                using (var db = new lab8YazikiContext())
                {
                    var obj = db.Products.FirstOrDefault(d => d.Id == productID);
                    if (obj != null)
                    {
                        button1.Text = "Редактировать";
                        this.Text = "Редактировать продукт";
                        this.Name.Text = obj.Name;
                        this.Description.Text = obj.Description;
                        this.Price.Text = obj.Price.ToString();
                        this.Category.Text = obj.Category.ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                if (string.IsNullOrEmpty(this.Name.Text)
                    || string.IsNullOrEmpty(this.Price.Text)
                    || string.IsNullOrEmpty(this.Category.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var prod = new Product()
                        {
                            Name = this.Name.Text,
                            Description = this.Description.Text,
                            Price = double.Parse(this.Price.Text),
                            Category = new Category() { Name = this.Category.Text },
                        };
                        db.Products.Add(prod);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.Name.Text)
                    || string.IsNullOrEmpty(this.Price.Text)
                    || string.IsNullOrEmpty(this.Category.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var obj = db.Products.FirstOrDefault(d => d.Id == productID);

                        obj.Name = this.Name.Text;
                        obj.Description = this.Description.Text;
                        obj.Price = double.Parse(this.Price.Text);
                        obj.Category = new Category() { Name = this.Category.Text };

                        db.SaveChanges();
                    }
                }
            }

            Form1 prd = this.Owner as Form1;

            prd!.LoadData();
            prd!.Refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
