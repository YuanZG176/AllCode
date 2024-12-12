using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class Fraction : Form
    {
        public Fraction()
        {
            InitializeComponent();
        }

        public int Top { get; private set; }
        public int Bottom { get; private set; }

        public Fraction(int top = 0, int bottom = 1)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            Top = top;
            Bottom = bottom;
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Bottom + right.Top * left.Bottom, left.Bottom * right.Bottom);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Bottom - right.Top * left.Bottom, left.Bottom * right.Bottom);
        }

        // 重载乘法运算符
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Top, left.Bottom * right.Bottom);
        }

        // 重载除法运算符
        public static Fraction operator /(Fraction left, Fraction right)
        {
            if (right.Top == 0)
            {
                throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");
            }
            return new Fraction(left.Top * right.Bottom, left.Bottom * right.Top);
        }


        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fraction_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction f1 = new Fraction(Convert.ToInt32(first_Top.Text), Convert.ToInt32(first_Bottom.Text));
                Fraction f2 = new Fraction(Convert.ToInt32(second_Top.Text), Convert.ToInt32(second_Bottom.Text));
                Fraction result = null;


                if (addButton.Checked)
                {
                    result = f1 + f2;
                }
                else if (subtractButton.Checked)
                {
                    result = f1 - f2;
                }
                else if (multiplyButton.Checked)
                {
                    result = f1 * f2;
                }
                else if (divideButton.Checked)
                {
                    result = f1 / f2;
                }


                result_Top.Text = result.Top.ToString();
                result_Bottom.Text = result.Bottom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void first_Top_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
