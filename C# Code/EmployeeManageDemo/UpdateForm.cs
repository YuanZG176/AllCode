using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManageDemo
{
    public partial class UpdateForm : Form
    {
        private Employee currentEmployee;
        public UpdateForm(Employee em)
        {
            InitializeComponent();
            this.currentEmployee = em;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.currentEmployee.Name;
            this.textBox2.Text = this.currentEmployee.Id;
            this.comboBox1.SelectedItem = currentEmployee.Gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save update data
            string name = this.textBox1.Text;
            string id = this.textBox2.Text;
            string gender = this.comboBox1.Text;
            Employee newEm = new Employee(name, gender, id);
          
            //update
            EmployeeManager.Update(id, newEm);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
