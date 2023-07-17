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
    }
}
