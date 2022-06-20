using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302201137
    //Debi Ratnasari Novianti
{
    public partial class Form1 : Form
    {
        decimal bilanganA;
        decimal bilanganB;

        int oprtr;
        Boolean oprtr_hsl = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label_output_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            bilanganA = Convert.ToDecimal(label_output.Text);
            label_output.Text = " ";
            oprtr = 1;
            oprtr_hsl = true;
        }

        private void btn_samadengan_Click(object sender, EventArgs e)
        {
            if (oprtr_hsl == true)
                bilanganB = Convert.ToDecimal(label_output.Text);
            {
                switch (oprtr)
                {
                    case 1:
                        label_output.Text = Convert.ToString(bilanganA + bilanganB);
                        break;
                }
            }
            oprtr_hsl = false;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (label_output.Text != "0")
            {
                label_output.Text += "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "1";
            }
            else
            {
                label_output.Text += "1";
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "2";
            }
            else
            {
                label_output.Text += "2";
            }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "3";
            }
            else
            {
                label_output.Text += "3";
            }

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "4";
            }
            else
            {
                label_output.Text += "4";
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "5";
            }
            else
            {
                label_output.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "6";
            }
            else
            {
                label_output.Text += "6";
            }

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "7";
            }
            else
            {
                label_output.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "8";
            }
            else
            {
                label_output.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (label_output.Text == "0")
            {
                label_output.Text = "9";
            }
            else
            {
                label_output.Text += "9";
            }

        }
    }
}