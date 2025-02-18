using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cs_GP_Kalkulator1.CountClassGPK;

namespace Cs_GP_Kalkulator1
{
    public partial class Form1: Form
    {
        double Result = 0;
        string number1 = "", number2="",numbertmp= "",strresult="";
        Boolean numb1bool = false, numb2bool = false;
        CountClassGPK countClassGPinstance = new CountClassGPK();
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
            //add tmp save
            number1 = richTextBox2.Text;
            richTextBox2.Text += $"{Environment.NewLine}+{Environment.NewLine}";
            numbertmp = richTextBox2.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //tmp save
            number1 = richTextBox2.Text;
            richTextBox2.Text += $"{Environment.NewLine}-{Environment.NewLine}";
            numbertmp = richTextBox2.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //tmp save
            number1 = richTextBox2.Text;
            richTextBox2.Text += $"{Environment.NewLine}*{Environment.NewLine}";
            numbertmp = richTextBox2.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //tmp save
            number1 = richTextBox2.Text;
            richTextBox2.Text += $"{Environment.NewLine}/{Environment.NewLine}";
            numbertmp = richTextBox2.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //print result
            //number2 = string.Expect(richTextBox2.Text,numbertmp);


            //countClassGPinstance.countFunction(richTextBox2.Text);

            // to delete inicial try to get result without use of class
            /* List<string> set1 = richTextBox2.Text.Split(' ').Distinct().ToList();
            List<string> set2 = numbertmp.Split(' ').Distinct().ToList();

            var diff = set2.Count() > set1.Count() ? set2.Except(set1).ToList() : set1.Except(set2).ToList();
            number2 = string.Join("", diff);
            Console.WriteLine(number1+" "+number2);*/

            //Result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            //richTextBox2.Text = Result.ToString();


            //count every thing in class fuction end return result string
            strresult = countClassGPinstance.countFunction(richTextBox2.Text);
            richTextBox2.Text = "";
            richTextBox2.Text = strresult;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
