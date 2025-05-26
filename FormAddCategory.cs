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
    public partial class FormAddCategory : Form
    {
        int oper { get; set; }

        int categoryID { get; set; }

        public FormAddCategory(int oper, int categoryID)
        {
            InitializeComponent();
            this.oper = oper;
            this.categoryID = categoryID;
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                button1.Text = "Добавить";
                this.Text = "Добавить категорию";
                this.Name.Text = "";
            }
            else
            {
                using (var db = new lab8YazikiContext())
                {
                    var obj = db.Categories.FirstOrDefault(d => d.Id == categoryID);
                    if (obj != null)
                    {
                        button1.Text = "Редактировать";
                        this.Text = "Редактировать категрию";
                        this.Name.Text = obj.Name;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.oper == 1)
            {
                if (string.IsNullOrEmpty(this.Name.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var prod = new Category()
                        {
                            Name = this.Name.Text,
                        };
                        db.Categories.Add(prod);
                        db.SaveChanges();
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.Name.Text))
                {
                    MessageBox.Show("Ne vse polya zapolneni");
                }
                else
                {
                    using (lab8YazikiContext db = new lab8YazikiContext())
                    {
                        var obj = db.Categories.FirstOrDefault(d => d.Id == categoryID);

                        obj.Name = this.Name.Text;

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
