using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlisted_Questionare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputContractButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("You have served one contract.");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("You have served two contracts.");
            }

            else if (checkBox3.Checked)
            {
                MessageBox.Show("You have served three contracts.");
            }

            else if (checkBox4.Checked)
            {
                MessageBox.Show("You have served four contracts.");
            }

            else if (checkBox5.Checked)
            {
                MessageBox.Show("You have served five contracts.");
            }

            else if (checkBox6.Checked)
            {
                MessageBox.Show("You have served six contracts.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Contact SSG Atkins (803) 456-0297 to see your options!");
            }

            else if (radioButton2.Checked)
            {
                MessageBox.Show("Contact Soldier For Life to set up your appointments.");
            }

            else if (radioButton3.Checked)
            {
                MessageBox.Show("Contact SSG Atkins (803) 456-0297 to see your options!");
            }
        }
    }
}
