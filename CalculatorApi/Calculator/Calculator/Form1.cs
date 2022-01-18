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
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text=="0") || (isOperation))
            {
                textBox1.Clear();
            }
            isOperation = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if (!(textBox1.Text.Contains(".")))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(textBox1.Text);
            LabelCurrentOPeration.Text = result + " " + operation;
            isOperation = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
