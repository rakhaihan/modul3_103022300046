using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300046
{
    public partial class Form1: Form
    {

        int angka1, angka2, hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "1";
            angka1 *= 10;
            angka1 += 1;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "2";
            angka1 *= 10;
            angka1 += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "3";
            angka1 *= 10;
            angka1 += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "4";
            angka1 *= 10;
            angka1 += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "5";
            angka1 *= 10;
            angka1 += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "6";
            angka1 *= 10;
            angka1 += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "7";
            angka1 *= 10;
            angka1 += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "8";
            angka1 *= 10;
            angka1 += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "9";
            angka1 *= 10;
            angka1 += 9;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "0";
            angka1 *= 10;
            angka1 += 0;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "+";
            angka2 = angka1;
            angka1 = 0;

        }

        private void buttonSD_Click(object sender, EventArgs e)
        {
          lblOutput.Text = lblOutput.Text + "=";
            hasil = angka1 + angka2;
            lblOutput.Text = hasil.ToString();
        }
    }
}
