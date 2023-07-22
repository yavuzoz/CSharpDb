using Linquery.Models;
using Linquery.SingletonPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linquery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //LINQ(languege integrated query)

        #region Question 1
        // list all the data in the products table.
        #endregion

        NorthwindEntities db = DBTool.DbInstance;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = db.Products.ToList();
        }
        // query preice between 20 to 30
        private void btnWhere_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource=db.Products.Where(product => product.UnitPrice > 20 && product.UnitPrice<30).Select(p => new
            {
                    ProductID=p.ProductID,
                    ProductName=p.ProductName,
                    ProductPrice =p.UnitPrice
            }).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource=db.Products.Where(p=> p.UnitPrice <20).OrderByDescending(p=> p.UnitPrice).Select(p=> new
            {
                p.ProductName,
                p.UnitPrice
            }).ToList();
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnCategoryName_Click(object sender, EventArgs e)
		{
            dgvProducts.DataSource = db.Products.Select(p => new
            {
                p.ProductName,
                p.Category.CategoryName,
                p.UnitPrice
            }).ToList();
		}

		private void btnTake_Click(object sender, EventArgs e)
		{
			dgvProducts.DataSource = db.Products.OrderByDescending(p=>p.UnitPrice).Take(3).ToList();
		}

		private void btnSkip_Click(object sender, EventArgs e)
		{
            dgvProducts.DataSource = db.Products.OrderBy(p => p.UnitPrice).Skip(1).Take(6).ToList();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
            Product p = db.Products.Find(5);
            MessageBox.Show(p.ProductName.ToString());
		}
	}
}
