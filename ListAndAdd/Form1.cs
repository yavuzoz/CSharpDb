using ListAndAdd.Models;
using ListAndAdd.SingletonPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProductAndCategories();
        }
        private void ListProductAndCategories()
        {
            NorthwindEntities db = DBTool.DbInstance;
            lstProducts.DataSource = db.Products.ToList();
            lstProducts.DisplayMember = "ProductName";

            cmbCatagories.DataSource = db.Categories.ToList();
            cmbCatagories.DisplayMember = "CategoryName";
            cmbCatagories.ValueMember = "CategoryID";
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = DBTool.DbInstance;
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            p.CategoryID = Convert.ToInt32(cmbCatagories.SelectedValue);
            db.Products.Add(p);
            db.SaveChanges();
            ListProductAndCategories();

        }

        private void lstProducts_Click(object sender, EventArgs e)
        {
            if(lstProducts.SelectedIndex > -1)
            {
                try
                {
                    Product p = lstProducts.SelectedItem as Product;
                    txtProductName.Text = p.ProductName;
                    txtUnitPrice.Text = p.UnitPrice.ToString();
                    cmbCatagories.SelectedValue = p.CategoryID;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    lstProducts.SelectedIndex = -1;
                }
               
            }
        }
    }
}
