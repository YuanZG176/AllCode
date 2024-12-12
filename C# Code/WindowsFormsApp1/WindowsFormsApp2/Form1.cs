using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(this.textBox1.Text);
            int second = Convert.ToInt32(this.textBox2.Text);
            int sum = first + second;
            MessageBox.Show(sum.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
