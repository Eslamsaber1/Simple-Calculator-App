using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char tt=' ';
        double z,x,y;
        private void button2_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "";
            tt='+';
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "";
            tt = '-';
              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "";
            tt = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            textBox1.Text = "";
            tt = '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
                textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text += "9";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            y = double.Parse(textBox1.Text);
           
            switch (tt) { 
                case '+':
                    z = x + y;
                    break;
                case '-':
                    z = x - y;
                    break;
                case '*':
                    z = x * y;
                    break;
                case'/':
                    if (y == 0)
                    {
                        MessageBox.Show("erorr");
                    }
                    else
                    {
                        z = x / y;
                    }
                    break;
            }
            textBox1.Text = z.ToString();
        }
    }
}
