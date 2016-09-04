using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
        double a=0, b=0, m=0;
        int count;
        public Form1()
        
            
        {
            InitializeComponent();

            Task.Factory.StartNew(Console);
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
                Result.Text = "Недопустимый ввод";

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
            a = double.Parse(Result.Text);
            Result.Text ="";
            count = 2;
            Term.Text = a.ToString() + "-";
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

 
        private void Test_Click(object sender, EventArgs e)
        {
            Result.Text = "23";
            buttonplus.PerformClick();
            string Test1 = "";
                    if (Term.Text == "23+")
                    {
                        Test1 = "Test1 = OK";
                    }
                    else
                    {
                        Test1 = "Test1 = NOT OK" + Term.Text + " " + Result.Text;
            } 
            buttonC.PerformClick();
            Result.Text = "24";
            buttonplus.PerformClick();
            Result.Text = "23";
            buttonResult.PerformClick();
            string Test2 = "";
                    if (Term.Text == "" && Result.Text == "47")
                    {
                        Test2 = "Test2 = OK";
                    }
                    else
                    {
                        Test2 = "Test2 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "0";
            buttonDiv.PerformClick();
            Result.Text = "0";
            buttonResult.PerformClick();
            string Test3 = "";
            if (Term.Text == "0/" && Result.Text == "Результат не определен")
            {
                Test3 = "Test3 = OK";
            }
            else
            {
                Test3 = "Test3 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "5";
            buttonDiv.PerformClick();
            Result.Text = "0";
            buttonResult.PerformClick();
            string Test4 = "";
            if (Term.Text == "5/" && Result.Text == "Деление на ноль невозможно")
            {
                Test4 = "Test4 = OK";
            }
            else
            {
                Test4 = "Test4 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "8";
            buttonPropr.PerformClick();
            string Test5 = "";
            if (Term.Text == "reciproc(8)" && Result.Text == "0,125")
            {
                Test5 = "Test5 = OK";
            }
            else
            {
                Test5 = "Test5 = NOT OK " + Term.Text +" "+ Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "0";
            buttonPropr.PerformClick();
            string Test6 = "";
            if (Term.Text == "reciproc(0)" && Result.Text == "Деление на ноль невозможно")
            {
                Test6 = "Test6 = OK";
            }
            else
            {
                Test6 = "Test6 = NOT OK " + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "25";
            buttonSqrt.PerformClick();
            string Test7 = "";
            if (Term.Text == "sqrt(25)" && Result.Text == "5")
            {
                Test7 = "Test7 = OK";
            }
            else
            {
                Test7 = "Test7 = NOT OK " + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "1";
            buttonPlusM.PerformClick();
            buttonSqrt.PerformClick();
            string Test8 = "";
            if (Term.Text == "sqrt(-1)" && Result.Text == "Недопустимый ввод")
            {
                Test8 = "Test8 = OK";
            }
            else
            {
                Test8 = "Test8 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "9";
            buttonPlusM.PerformClick();
            string Test9 = "";
            if (Term.Text == "" && Result.Text == "-9")
            {
                Test9 = "Test9 = OK";
            }
            else
            {
                Test9 = "Test9 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "0";
            buttonPlusM.PerformClick();
            string Test10 = "";
            if (Term.Text == "" && Result.Text == "0")
            {
                Test10 = "Test10 = OK";
            }
            else
            {
                Test10 = "Test10 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "200";
            buttonMult.PerformClick();
            Result.Text = "10";
            buttonProc.PerformClick();
            string Test11 = "";
            if (Term.Text == "200 * 20" && Result.Text == "20")
            {
                Test11 = "Test11 = OK";
            }
            else
            {
                Test11 = "Test11 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "5";
            buttonMinus.PerformClick();
            Result.Text = "0,01";
            buttonResult.PerformClick();
            string Test12 = "";
            if (Term.Text == "" && Result.Text == "4,99")
            {
                Test12 = "Test12 = OK";
            }
            else
            {
                Test12 = "Test12 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "111";
            buttonC.PerformClick();
            string Test13 = "";
            if (Term.Text == "" && Result.Text == "0")
            {
                Test13 = "Test13 = OK";
            }
            else
            {
                Test13 = "Test13 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "111";
            buttonplus.PerformClick();
            Result.Text = "111";
            buttonC.PerformClick();
            string Test14 = "";
            if (Term.Text == "" && Result.Text == "0")
            {
                Test14 = "Test14 = OK";
            }
            else
            {
                Test14 = "Test14 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "111";
            buttonCE.PerformClick();
            string Test15 = "";
            if (Term.Text == "" && Result.Text == "0")
            {
                Test15 = "Test15 = OK";
            }
            else
            {
                Test15 = "Test15 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "111";
            buttonplus.PerformClick();
            Result.Text = "111";
            buttonCE.PerformClick();
            string Test16 = "";
            if (Term.Text == "111+" && Result.Text == "0")
            {
                Test16 = "Test16 = OK";
            }
            else
            {
                Test16 = "Test16 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "768";
            buttonBack.PerformClick();
            string Test17 = "";
            if (Term.Text == "" && Result.Text == "76")
            {
                Test17 = "Test17 = OK";
            }
            else
            {
                Test17 = "Test17 = NOT OK" + Term.Text + " " + Result.Text;
            }
            buttonC.PerformClick();
            Result.Text = "768";
            buttonplus.PerformClick();
            Result.Text = "686";
            buttonBack.PerformClick();
            string Test18 = "";
            if (Term.Text == "768+" && Result.Text == "68")
            {
                Test18 = "Test18 = OK";
            }
            else
            {
                Test18 = "Test18 = NOT OK" + Term.Text + " " + Result.Text;
            }
            if (AllocConsole())
            {
                System.Console.WriteLine(Test1);
                System.Console.WriteLine(Test2);
                System.Console.WriteLine(Test3);
                System.Console.WriteLine(Test4);
                System.Console.WriteLine(Test5);
                System.Console.WriteLine(Test6);
                System.Console.WriteLine(Test7);
                System.Console.WriteLine(Test8);
                System.Console.WriteLine(Test9);
                System.Console.WriteLine(Test10);
                System.Console.WriteLine(Test11);
                System.Console.WriteLine(Test12);
                System.Console.WriteLine(Test13);
                System.Console.WriteLine(Test14);
                System.Console.WriteLine(Test15);
                System.Console.WriteLine(Test16);
                System.Console.WriteLine(Test17);
                System.Console.WriteLine(Test18);
                //System.Console.WriteLine(Test19);
                //System.Console.WriteLine(Test20);
                //System.Console.WriteLine(Test21);
                
            }



        }

        public void buttonMC_Click(object sender, EventArgs e)
        {
            m = 0;
            Memory.Text = "";
        }

        public void Console()
        {
            /*Result.Text = "23";
            buttonplus.PerformClick();
           /* if (AllocConsole())
            {
               
               // System.Console.WriteLine("Для выхода наберите exit.");
            }*/
        }
        
 
    }
}
