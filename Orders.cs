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
        private double cost;

        public Orders(double val)
        {
            InitializeComponent();
            cost = val;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
