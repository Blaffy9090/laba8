using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class FormAddOrder : Form
    {
        int oper { get; set; }

        int orderID { get; set; }

        public FormAddOrder(int o, int oI)
        {
            InitializeComponent();

            oper = o;
            orderID = oI;
        }

        private void LoadData()
        {
            using (lab8YazikiContext db = new lab8YazikiContext())
            {
                var obj = db.Orders.FirstOrDefault(d => d.Id == orderID);
                if (obj != null)
                {
                    var prod = db.Products.FirstOrDefault(t => t.Id == obj.ProductId);
                    if (prod != null)
                    {
                        this.Product.Text = prod.Name;
                    }

                    this.dateTimePicker1.Value = obj.OrderDate.ToDateTime(new TimeOnly(0));
                    this.Amount.Text = obj.Amount.ToString();
                    if (obj.Sum == 0)
                    {
                        this.Sum.Text = (prod.Price * obj.Amount).ToString();
                    }
                    else
                    {
                        this.Sum.Text = (obj.Sum).ToString();
                    }
                }
            }
        }
        private void LoadProducts()
        {
            using (lab8YazikiContext db = new lab8YazikiContext())
            {
                this.Product.DataSource = db.Products.Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    Price = d.Price,
                }).ToList();

                this.Product.ValueMember = "Id";
                this.Product.DisplayMember = "Name";
                this.Product.Text = "";
            }
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            LoadProducts();

            if (oper == 1)
            {
                button1.Text = "Добавить";
            }
            else
            {
                LoadData();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                if (string.IsNullOrEmpty(this.Product.Text)
                    || string.IsNullOrEmpty(this.dateTimePicker1.Text)
                    || string.IsNullOrEmpty(this.Amount.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var prod = new Order()
                        {
                            ProductId = (int)(this.Product.SelectedValue),
                            Amount = int.Parse(this.Amount.Text),
                            OrderDate = DateOnly.FromDateTime(this.dateTimePicker1.Value),
                            Sum = double.Parse(this.Sum.Text),
                        };
                        db.Orders.Add(prod);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.Product.Text)
                    || string.IsNullOrEmpty(this.dateTimePicker1.Text)
                    || string.IsNullOrEmpty(this.Amount.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var obj = db.Orders.FirstOrDefault(d => d.Id == orderID);

                        obj.ProductId = (int)(this.Product.SelectedValue);
                        obj.Amount = int.Parse(this.Amount.Text);
                        obj.OrderDate = DateOnly.FromDateTime(this.dateTimePicker1.Value);
                        obj.Sum = double.Parse(this.Sum.Text);

                        db.SaveChanges();
                    }
                }
            }

            Form1 prd = this.Owner as Form1;

            prd!.LoadData();
            prd!.Refresh();
            this.Close();
        }
    }
}
