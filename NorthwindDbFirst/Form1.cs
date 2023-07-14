using NorthwindDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        NorthwindEntities db = new NorthwindEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void List()
        {
            lstEmployee.DataSource = db.Employees.ToList();
            lstEmployee.DisplayMember = "FirstName";
            lstEmployee.SelectedIndex = -1;
        }
    }
}
