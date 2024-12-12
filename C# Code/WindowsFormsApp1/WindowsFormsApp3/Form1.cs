using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private const double BASE_PRICE = 12.00;
        private const double TOPPING_PRICE = 1.25;
        private double price = BASE_PRICE;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.price += 5;
            }
            else
            {
                this.price -= 5;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
            {
                this.price += 10;
            }
            else
            {
                this.price -= 10;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked == true)
            {
                this.price += 1;
            }
            else
            {
                this.price -= 1;
            }
            this.label4.Text = "The total price is " + price.ToString("C");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
           
            /*if (this.checkBox1.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            if (this.checkBox2.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }

             if (this.checkBox3.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            if (this.checkBox4.Checked == true)
            {
                this.price += TOPPING_PRICE;
            }
            else
            {
                this.price -= TOPPING_PRICE;
            }
            if (this.radioButton1.Checked == true)
            {
                this.price += 5;
            }
            else
            {
                this.price -= 5;
            }
            if (this.radioButton2.Checked == true)
            {
                this.price += 10;
            }
            else
            {
                this.price -= 10;
            }
            if (this.radioButton3.Checked == true)
            {
                this.price += 1;
            }
            else
            {
                this.price -= 1;
            }
            this.label4.Text = "The total price is " + price.ToString("C");*/
        }
    }
}
