using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursov_Proekt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deliveryDataSet.Dishes' table. You can move, or remove it, as needed.
            this.dishesTableAdapter1.Fill(this.deliveryDataSet.Dishes);
            // TODO: This line of code loads data into the 'proekt4DataSet.Dishes' table. You can move, or remove it, as needed.
            this.dishesTableAdapter.Fill(this.proekt4DataSet.Dishes);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
