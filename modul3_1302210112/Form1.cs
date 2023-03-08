using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302210112
{
    public partial class Form1 : Form
    {
        string c="";
        int d = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "1";
            this.c += "1";
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "2";
            this.c += "2";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "3";
            this.c += "3";
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "4";
            this.c += "4";
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "5";
            this.c += "5";
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "6";
            this.c += "6";
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "7";
            this.c += "7";
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "8";
            this.c += "8";
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "9";
            this.c += "9";
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "0";
            this.c += "0";
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text += "+";
            d=int.Parse(c);
            c = "";
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            int b = d + int.Parse(c);
            textBox1.Text=b.ToString();
        }
    }
}
