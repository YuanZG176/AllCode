using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3Yuan
{
    public partial class Form1 : Form
    {


        private double firstNumber;
        private string operation;
        private Calculator calculator = new Calculator();
        private double memoryValue;
        public Form1()
        {
            InitializeComponent();
            memoryValue = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            int firstNumber = 0;
            string operation = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Text += " + ";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Text += " - ";
        }

        private void buttonMultipy_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Text += " * ";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Text += " / ";
        }

        
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string[] parts = txtDisplay.Text.Split(' ');
            if (parts.Length < 3) return;
            double secondNumber = double.Parse(parts[2]);
            if (operation == "/" && secondNumber == 0)
            {
                MessageBox.Show("错误：不能除以零！", "计算错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double result = 0;

            switch (operation.Trim())
            {
                case "+":
                    result = calculator.Add(firstNumber, secondNumber);
                    break;
                case "-":
                    result = calculator.Subtract(firstNumber, secondNumber);                
                    break;
                case "*":
                    result = calculator.Multiply(firstNumber, secondNumber);       
                    break;
                case "/":
                    result = calculator.Divide(firstNumber, secondNumber);            
                    break;
                case "±":
                    var(sum,difference)= calculator.AddAndSubstract(firstNumber, secondNumber);
                    txtDisplay.Text += string.Format(" = {0} // {1}",sum,difference);
                    firstNumber = sum; 
                    operation = ""; 
                    return;
            }

            txtDisplay.Text += " = " + result.ToString();
            firstNumber = result; 
            operation = "";           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void buttonAddAndSub_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = " ± ";
            txtDisplay.Text += " ± ";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            memoryValue += currentValue; 
            MessageBox.Show(string.Format("当前内存值: {0}", memoryValue), "内存更新", MessageBoxButtons.OK);
        }

        private void buttonSubMemery_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            memoryValue -= currentValue;
            MessageBox.Show(string.Format("当前内存值: {0}", memoryValue), "内存更新", MessageBoxButtons.OK);
        }

        private void MemeorRecall_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
        }

        private void MemeryClear(object sender, EventArgs e)
        {
            memoryValue = 0; 
            MessageBox.Show("内存已清除", "内存清除", MessageBoxButtons.OK);
        }
    }
}
