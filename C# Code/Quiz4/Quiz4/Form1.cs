using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;


namespace Quiz4
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                switch (this.listBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = "Name: Ross\nAge: 30\nOccupation: Developer";
                    pictureBox1.Image = Properties.Resources._4b08a99523fe5a08_1;
                    break;
                case 1:
                    label1.Text = "Name: Whitney\nAge: 28\nOccupation: Designer";
                    pictureBox1.Image = Properties.Resources._7e4d5b2929c5dea1_1;
                    break;
                case 2:
                    label1.Text = "Name: Heart\nAge: 25\nOccupation: Artist";
                    pictureBox1.Image = Properties.Resources._8432e1486bb5a85d_1; 
                    break;
                case 3:
                    label1.Text = "Name: Heart\nAge: 25\nOccupation: Artist";
                    pictureBox1.Image = Properties.Resources.ee3f0c74b1c07925_1;
                    break;
                case 4:
                    label1.Text = "Name: Heart\nAge: 25\nOccupation: Artist";
                    pictureBox1.Image = Properties.Resources.Java学习路线;
                    break;
                default:
                    label1.Text = "Select a person.";
                    pictureBox1.Image = null;
                    break;
            }
        }
    }
}
