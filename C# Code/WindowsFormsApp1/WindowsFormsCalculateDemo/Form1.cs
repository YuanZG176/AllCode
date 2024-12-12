using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(this.textBox1.Text);
                int second = Convert.ToInt32(this.textBox2.Text);
                int sum = first + second;
                this.textBox3.Text = "The sum is " + sum;

                MessageBox.Show(sum.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show("Please enter a valid Number.");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
