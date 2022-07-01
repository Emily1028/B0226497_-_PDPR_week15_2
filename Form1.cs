using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week15_2
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

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double ele = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                cost.Text = $"所需電費：{(ele * 3.6).ToString()}";
            }
            else if (radioButton2.Checked)
            {
                if(ele<=110)
                {
                    cost.Text = $"所需電費：{(ele * 2.0).ToString()}";
                }
                else if (ele > 110 && ele <= 330)
                {
                    cost.Text = $"所需電費：{(ele * 2.3).ToString()}";
                }
                else if (ele > 330)
                {
                    cost.Text = $"所需電費：{(ele * 3.0).ToString()}";
                }
            }
        }

        private void cost_Click(object sender, EventArgs e)
        {

        }
    }
}
