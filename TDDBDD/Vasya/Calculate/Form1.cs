using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Calculate
{
    public partial class fCalc : Form
    {
        
        public fCalc()
        {
            InitializeComponent();
        }
        
        public bool tm=false;
        bool NewOp = true;
        int op = -1;
        double a = 0, b = 0, c = 0;


        private void bSvoistva_Click(object sender, EventArgs e)
        {
            tm = !tm;
        }

        private void fCalc_LocationChanged(object sender, EventArgs e)
        {
            
        }

        private void fCalc_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (NewOp)
                {
                    tb_Calc.Text = "";
                    NewOp = false;
                }
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar == ',' && tb_Calc.Text.IndexOf(',') > -1) e.Handled = true;
                if (e.KeyChar == '0' && tb_Calc.Text == "0") e.Handled = true;
                if (tb_Calc.Text == "0" && e.KeyChar >= '1' && e.KeyChar <= '9') tb_Calc.Text = "";
            }
            else e.Handled = true;
        }

        private void bNum1_Click(object sender, EventArgs e)
        {
            if (NewOp == true || tb_Calc.Text == "0")
            {
                tb_Calc.Text = (sender as Button).Text;
                NewOp = false;
            }
            else tb_Calc.Text += (sender as Button).Text;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            op = -1;
            tb_Calc.Text =  "0";
            NewOp = true;
        }

        private void bPoint_Click(object sender, EventArgs e)
        {
            if(NewOp)
            {
                tb_Calc.Text = "0";
                NewOp = false;
            }
            if (tb_Calc.Text.IndexOf(",") == -1) tb_Calc.Text += ',';

        }

        private void bRavno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tb_Calc.Text);
            
            c = calculateNew(a, b, op);


                    tb_Calc.Text = Convert.ToString(c);
                    NewOp = true;
                    op = -1;
        }

        public double calculateNew(double num1, double num2, int oper)
        {
            double res = 0;
            char op = 'a';

            if (oper == 1) { op = '+'; }
            if (oper == 2) { op = '-'; }
            if (oper == 3) { op = '*'; }
            if (oper == 4) { op = '/'; }
            if (oper == 5) { op = 'p'; }
            if (oper == 6) { op = 's'; }

            switch (op)
            {
                case '+': return res = new CalcCore().PlusMethod(num1, num2);   
                case '-': return res = new CalcCore().MinusMethod(num1, num2);
                case '*': return res = new CalcCore().MultiplyMethod(num1, num2);
                case '/': return res = new CalcCore().DivideMethod(num1, num2);
                case 'p': return res = new CalcCore().PowMethod(num1, num2);
                case 's': return res = new CalcCore().SqrtMethod(num1);
            }
            return res = 0;
        }

        

        private void bPlus_Click(object sender, EventArgs e)
        {

            if (tb_Calc.Text == "")
            {
                tb_Calc.Text = "0";
            }   
            else
            {
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 1;
                
            }
            
        }
        





        private void bMinus_Click(object sender, EventArgs e)
        {
            if (!(tb_Calc.Text.IndexOf("-")>-1&& tb_Calc.Text.Length - 1 == tb_Calc.Text.IndexOf("-")))
            {
                if (tb_Calc.Text == "" || tb_Calc.Text == "0")
                {
                    tb_Calc.Text = "-";
                    NewOp = false;
                    op = -1;
                }
                else
                {
                    

                    if (op > 0)
                        bRavno_Click(sender, e);
                    a = Convert.ToDouble(tb_Calc.Text);
                    NewOp = true;
                    op = 2;
                }

            }
            
        }

        private void bUmn_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {
                
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 3;
            }
        }

        private void bDelenie_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {
                
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 4;
            }
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Sin(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Cos(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bTg_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Tan(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bCtg_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text =(1/Math.Tan(Convert.ToDouble(tb_Calc.Text))).ToString();
            NewOp = true;
            op = -1;
        }

        private void bAbs_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Abs(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bLn_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Log(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bExp_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Exp(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = Math.Sqrt(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bX_in2_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = ((Convert.ToDouble(tb_Calc.Text))*Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void b1_x_Click(object sender, EventArgs e)
        {


            if (Convert.ToDouble(tb_Calc.Text) == 0) MessageBox.Show("Деление на ноль невозможно.", "Ошибка!");
            else
            {
                if (tb_Calc.Text == "") tb_Calc.Text = "0";
                tb_Calc.Text = (1 / (Convert.ToDouble(tb_Calc.Text))).ToString();
                NewOp = true;
                op = -1;
            }
         
        }

        private void bx_y_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 5;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(tb_Calc.Text); 
            double t;

            double squareRoot = number / 2;

            do
            {

                t = squareRoot;

                squareRoot = (t + (number / t)) / 2;

            } while ((t - squareRoot) != 0);
            tb_Calc.Text = squareRoot.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // BKSP кнопка ЗДЕСЬ!!!!!!!!
        {
            if (tb_Calc.Text.Length >= 2)
            {
                tb_Calc.Text = tb_Calc.Text.Substring(0, tb_Calc.Text.Length - 1);
            }
            else
            {
                tb_Calc.Text = "0";
            }

        }

        private void bFact_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            int a = 1;
            try
            {
                Convert.ToInt32(tb_Calc.Text);
                
            }
            catch
            {
                
                MessageBox.Show("Введите, пожалуйста целое число.","Ошибка!");
                a = 0;
                
            }
            
            if (a == 0)
            {

            }
            else
            {
                for (int i = 2; i <= Convert.ToInt32(tb_Calc.Text); i++)
                {

                    a = a * i;
                }
                tb_Calc.Text = a.ToString();
                NewOp = true;
                op = -1;
            }
        }

        private void Anim_Tick(object sender, EventArgs e)
        {

            if (this.Width  <350 && tm == true)
            {
                while (!(this.Width == 465))
                {
                    this.Width += 1;
                    if (this.Width == 464)
                    {
                        bSvoistva.Text = "<";
                        tm = false;

                    }


                }

            }
          

                if (this.Width >400&&tm==true)
                {
                while (!(this.Width == 310))
                {

                    this.Width -= 1;

                    if (this.Width == 311)
                    {
                        bSvoistva.Text = ">";
                        tm = false;

                    }


                }
                
            }
            
        }
    }



}
