using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form1 : Form
    {
     string op;
     double num1 ;
     double num2;
     double res;
        public Form1()
        {
            InitializeComponent();
        }
        private void button17_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void button10_Click(object sender, EventArgs e)
        {
         textBox1.Text = textBox1.Text + "3";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void button13_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text + "5";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text + "7";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void button6_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text + "9";
        }
        private void button18_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text + ".";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "+";  
           }
        private void button7_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "-";  
            }
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "*";  
    }
        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            op = "/";
            
          }
         private void button21_Click(object sender, EventArgs e)
        {
             num2 = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                res = (num1 + num2);
                textBox1.Text = Convert.ToString(num1 + "+" + num2 + "=" + res);
                num1 = res;
            }
            if (op == "-")
            {
                res = (num1 - num2);
                textBox1.Text = Convert.ToString(num1 + "-" + num2 + "=" + res);
                num1 = res;
            }
            if (op == "*")
            {
                res = (num1 * num2);
                textBox1.Text = Convert.ToString(num1+"*"+num2+"="+res);
                num1 = res;
            }
            if (op == "/")
            {
                if (num2 == 0)
                {
                    textBox1.Text = "ERROR";
                }
                else
                {
                    res = (num1 / num2);
                    textBox1.Text = Convert.ToString(num1 + "/" + num2 + "=" + res);
                    num1 = res;
                }
            }  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";  
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0"; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }  
    }
}
