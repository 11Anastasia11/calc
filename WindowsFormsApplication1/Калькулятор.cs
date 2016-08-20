using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double a=0, b=0, m=0;
        int count;
        public Form1()

        {
            InitializeComponent();
            Result.Text = a.ToString();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(Result.Text);
                    Term.Clear();
                    Result.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(Result.Text);
                    Term.Clear();
                    Result.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(Result.Text);
                    Term.Clear();
                    Result.Text = b.ToString();
                    break;
                case 4:
                   if (a == 0 && double.Parse(Result.Text) == 0)
                    {
                        Result.Text = "Результат не определен";
                        break;
                    }
                    else
                       if (double.Parse(Result.Text) == 0)
                    {
                        Result.Text = "Деление на ноль невозможно";
                        break;
                    }
                    b = a / double.Parse(Result.Text);
                    Term.Clear();
                    Result.Text = b.ToString();
                    break;
                /*case 5:
                    double c;
                    c = Math.Sqrt(Convert.ToDouble(a));
                    textBox1.Text = c.ToString();
                    break;*/
                case 6:
                    b = a / 100 * double.Parse(Term.Text);
                    Term.Text = b.ToString();
                    break;
                /*case 7:
                    b =  1 / a; 
                    textBox1.Text = b.ToString();
                    break;*/

                default:
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Term.Text = "";
            Result.Text = "0";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            Result.Text = m.ToString();

        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            m = double.Parse(Result.Text);
            if (m != 0 )
                Memory.Text = "M";
            else
                Memory.Text = "";
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            m += double.Parse(Result.Text);
            if (m != 0)
                Memory.Text = "M";
            else
                Memory.Text = "";
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            m -= double.Parse(Result.Text);
            if (m != 0)
                Memory.Text = "M";
            else
                Memory.Text = "";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            a = double.Parse(Result.Text);
            if (a < 0)
            {
                Term.Text = "sqrt(" + a.ToString() + ")";
                Result.Text = "Недопустиый ввод";

            }
            else
            //a = double.Parse(label1.Text);
            {
                Result.Text = "";
                double c;
                c = Math.Sqrt(Convert.ToDouble(a));
                Result.Text = c.ToString();
                Term.Text = "sqrt(" + a.ToString() + ")";
                
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            bool sign = true;
            if (sign == true)
            {
                a = double.Parse(Result.Text);
                b = 0 - a;
                Result.Text = b.ToString();
                sign = false;
            }
            else if (sign == false)
            {
                Result.Text = Result.Text.Replace("-", "");
                sign = true;
            }
        }

        private void buttonProc_Click(object sender, EventArgs e)
        {
            calculate();
            double c = 0;
            c = b / 100;
            Term.Text = a.ToString() + " * " + c.ToString();
            Result.Text = c.ToString();
            

            /*a = double.Parse(label1.Text);
            label1.Text = "";
            count = 3;
            textBox1.Text = a.ToString() + "%";
            sign = true;*/
        }

        private void buttonPropr_Click(object sender, EventArgs e)
        {
            a = double.Parse(Result.Text);
            Result.Text = "";
            if (a == 0)
            {
                
                Result.Text = "Деление на ноль невозможно";
                Term.Text = "reciproc(" + a.ToString() + ")";

            }

            else
            {
                Term.Text = "reciproc(" + a.ToString() + ")";
                b = 1 / a;
                Result.Text = b.ToString();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            calculate();
            //label1.Text = "";
        }

        private void buttoncm_Click(object sender, EventArgs e)
        {
            Result.Text += ",";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = double.Parse(Result.Text);
            Result.Text = "";
            count = 1;
            Term.Text = a.ToString() + "+";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            a = double.Parse(Result.Text);
            Result.Text = "";
            count = 3;
            Term.Text = a.ToString() + "*";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int lenght = Result.Text.Length - 1;
            string text = Result.Text;
            Result.Text = "";
            for (int i = 0; i < lenght; i++)
            {
                Result.Text = Result.Text + text[i];
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = double.Parse(Term.Text);
            Term.Clear();
            count = 2;
            Result.Text = a.ToString() + "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Text = "";
            Result.Text += "1";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            a = double.Parse(Result.Text);
            Result.Text = "";
            count = 4;
            Term.Text = a.ToString() + "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Memory_Click(object sender, EventArgs e)
        {

        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            m = 0;
            Memory.Text = "";
        }

 
 
    }
}
