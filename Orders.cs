using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueNetCafe
{
    public partial class Orders : Form
    {
        public Orders(double val)
        {
            InitializeComponent();
            label3.Text = "$" + val.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!");
            //print receipt
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
