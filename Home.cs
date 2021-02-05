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
    public partial class Home : Form
    {
        public double cost;
        public double tea = 4.00;
        public double coffee = 5.00;
        public double cold = 3.00;
        public double water = 1.00;
        public double cake = 7.00;
        public double scones = 3.00;
        public double sandwich = 4.00;
        public double bagel = 3.00;
        public double doughnut = 3.00;
        public double wrap = 4.00;
        public double cookies = 3.50;
        public double croissant = 4.00;

        public Home()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            cost = 0.00;
            listBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*** Teas ***/
            if (radioButton1.Checked == true) { listBox1.Items.Add(radioButton1.Text + "    $" + tea); 
                cost +=tea;
            }
            if (radioButton2.Checked == true) { listBox1.Items.Add(radioButton2.Text + "    $" + tea);
                cost += tea;
            }
            if (radioButton3.Checked == true) { listBox1.Items.Add(radioButton3.Text + "    $" + tea);
                cost += tea;
            }
            if (radioButton4.Checked == true) { listBox1.Items.Add(radioButton4.Text + "    $" + tea);
                cost += tea;
            }

            /*** Coffee ***/
            if (radioButton5.Checked == true) { listBox1.Items.Add(radioButton5.Text + "    $" + coffee);
                cost += coffee;
            }
            if (radioButton6.Checked == true) { listBox1.Items.Add(radioButton6.Text + "    $" + coffee);
                cost += coffee;
            }
            if (radioButton7.Checked == true) { listBox1.Items.Add(radioButton7.Text + "    $" + coffee);
                cost += coffee;
            }
            if (radioButton8.Checked == true) { listBox1.Items.Add(radioButton8.Text + "    $" + coffee);
                cost += coffee;
            }
            if (radioButton9.Checked == true) { listBox1.Items.Add(radioButton9.Text + "    $" + coffee);
                cost += coffee;
            }

            /*** Cold ***/
            if (radioButton10.Checked == true) { listBox1.Items.Add(radioButton10.Text + "    $" + cold);
                cost += cold;
            }
            if (radioButton11.Checked == true) { listBox1.Items.Add(radioButton11.Text + "    $" + cold);
                cost += cold;
            }
            if (radioButton12.Checked == true) { listBox1.Items.Add(radioButton12.Text + "    $" + cold);
                cost += cold;
            }
            if (radioButton13.Checked == true) { listBox1.Items.Add(radioButton13.Text + "    $" + water);
                cost += water;
            }

            /*** Food ***/
            if (radioButton14.Checked == true) { listBox1.Items.Add(radioButton14.Text + "    $" + scones); cost += scones;
            }
            if (radioButton15.Checked == true) { listBox1.Items.Add(radioButton15.Text + "    $" + cake);
                cost += cake;
            }
            if (radioButton16.Checked == true) { listBox1.Items.Add(radioButton16.Text + "    $" + doughnut);
                cost += doughnut;
            }
            if (radioButton17.Checked == true) { listBox1.Items.Add(radioButton17.Text + "    $" + croissant);
                cost += croissant;
            }
            if (radioButton18.Checked == true) { listBox1.Items.Add(radioButton18.Text + "    $" + bagel);
                cost += bagel;
            }
            if (radioButton19.Checked == true) { listBox1.Items.Add(radioButton19.Text + "    $" + sandwich);
                cost += sandwich;
            }
            if (radioButton20.Checked == true) { listBox1.Items.Add(radioButton20.Text + "    $" + sandwich);
                cost += sandwich;
            }
            if (radioButton21.Checked == true) { listBox1.Items.Add(radioButton21.Text + "    $" + wrap);
                cost += wrap;
            }
            if (radioButton22.Checked == true) { listBox1.Items.Add(radioButton22.Text + "    $" + cookies);
                cost += cookies;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 0.00;

            if(listBox1.SelectedIndex > -1)
            {
                string temp = listBox1.SelectedItem.ToString();
                x = Convert.ToDouble(temp.Substring(temp.IndexOf("$") + 1));
                listBox1.Items.Remove(listBox1.SelectedItem);
                cost -= x;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cost > 0)
            {
                Form a1 = new Orders(cost);
                a1.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
