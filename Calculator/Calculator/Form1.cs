using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        string input;
        string op1 = "";
        string op2 = "";
        char operation;
        double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }


        private void update()
        {
            this.TextBox.Text = input; 
        }

        private void zero_Click(object sender, EventArgs e)
        {
            input += "0";
            update();
        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
            update();
        }

        private void two_Click(object sender, EventArgs e)
        {
            input += "2";
            update();
        }

        private void three_Click(object sender, EventArgs e)
        {
            input += "3";
            update();

        }

        private void four_Click(object sender, EventArgs e)
        {
            input += "4";
            update();
        }

        private void five_Click(object sender, EventArgs e)
        {
            input += "5";
            update();
        }

        private void six_Click(object sender, EventArgs e)
        {
            input += "6";
            update();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input += "7";
            update();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input += "8";
            update();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input += "9";
            update();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ",";
            update();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            operation = '+';
            op1 = input;
            input = "";
            update();
           
        }

        private void min_Click(object sender, EventArgs e)
        {
            operation = '-';
            op1 = input;
            input = "";
            update();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operation = '*';
            op1 = input;
            input = "";
            update();
        }

        private void div_Click(object sender, EventArgs e)
        {
            operation = '/';
            op1 = input;
            input = "";
            update();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            op2 = input;

            double left, right;
            double.TryParse(op1, out left);
            double.TryParse(op2, out right);

            switch (operation)
            {
                case '+':
                    result = left + right;
                    input = result.ToString();
                    update();
                    break;
                case '-':
                    result = left - right;
                    input = result.ToString();
                    update();
                    break;
                case '*':
                    result = left * right;
                    input = result.ToString();
                    update();
                    break;
                case '/':
                    if (right == 0)
                    {
                        TextBox.Text = "Cannot divide by zero!!";
                    }
                    result = left / right;
                    input = result.ToString();
                    update();
                    break;
                default:
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input = "";
            op1 = "";
            op2 = "";
            update();
            
        }
    }
}
