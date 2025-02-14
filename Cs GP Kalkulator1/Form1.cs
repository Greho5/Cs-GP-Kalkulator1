using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_GP_Kalkulator1
{
    public partial class Form1: Form
    {
        double Result = 0;
        string number1 = "", number2="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //this is 0 button
        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "2";
        }
       
        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //tmp save
            richTextBox2.Text += "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //tmp save
            richTextBox2.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //tmp save
            richTextBox2.Text += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //tmp save
            richTextBox2.Text += "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //print result
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
