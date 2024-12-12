using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveRadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (this.radioButton2.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }
            else if (this.radioButton3.Checked == true)
            {
                this.BackColor = Color.Pink;
            }
            else if (this.radioButton4.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            else if (this.radioButton5.Checked == true)
            {
                this.BackColor = Color.Gray;
            }
            else 
            {
                this.BackColor = Color.Orange;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
