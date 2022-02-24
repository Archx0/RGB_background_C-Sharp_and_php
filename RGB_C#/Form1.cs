using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rrggbb112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRgb_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(int.Parse(inputRR.Text), int.Parse(inputGG.Text), int.Parse(inputBB.Text));

            RgbNum.Text = $"RGB : ({inputRR.Text},{inputGG.Text},{inputBB.Text})";
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RgbNum_Click(object sender, EventArgs e)
        {

        }
    }
}
