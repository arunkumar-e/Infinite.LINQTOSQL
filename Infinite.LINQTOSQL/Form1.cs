using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinite.LINQTOSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindClassDataContext context = new NorthwindClassDataContext();

            var products = context.Products.OrderBy(c => c.ProductName).Select(c => c);

            Grid1.DataSource = products.ToList();
        }
    }
}
