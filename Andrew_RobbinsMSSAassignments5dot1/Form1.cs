using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MSSAassignments5dot1form
{
    public partial class Form1 : Form
    {
        ICalculator calc = new ICalculator();
        public Form1()
        {
            InitializeComponent();
        }
        double valueOfResults = 0;
        string performOperation = "";
        bool isperformOperation = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
         //   string a1 = button_1.Text;
            //textBox1.Text = a1 + textBox1.Text;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            isperformOperation = false;
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
            {
                 textBox1.Text = textBox1.Text + btn.Text;
            }
              //  textBox1.Text = textBox1.Text + btn.Text;
        }

        private void Op_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (valueOfResults != 0)
            {
                performOperation = btn.Text;
               // textBox1.Text = "0";
                label1.Text = valueOfResults + " " + performOperation;
                isperformOperation = true;
            }
            else
            {
                performOperation = btn.Text;
                valueOfResults = double.Parse(textBox1.Text);
                textBox1.Text = "0";
                label1.Text = valueOfResults + " " + performOperation;
                isperformOperation = true;

            }
        }

        private void button_eq_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = (valueOfResults);
            switch (performOperation)
            {
                case "+":
                    textBox1.Text = calc.Add(a, b).ToString();
                    break;
                case "-":
                    textBox1.Text = calc.Subtract(b, a).ToString();
                    break;
                case "*":
                    textBox1.Text = calc.Multiply(a, b).ToString();
                    break;
                case "/":
                    textBox1.Text = calc.Divide(a, b).ToString();
                    break;
                default:
                    break;
            }
            valueOfResults = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            valueOfResults = 0;
        }
    }
    interface IcalcThis
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
    class ICalculator : IcalcThis
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;

        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return (a / b);
        }
    }
        
}
