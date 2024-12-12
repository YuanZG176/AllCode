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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //initial code
            //read file to load employee data
            EmployeeManager.LoadEmployee("employee.txt");

            //bind datasource to datagridview
            this.dataGridView1.DataSource = EmployeeManager.employees;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string key = this.keyTextbox.Text;
            List<Employee> resultset = EmployeeManager.SearchEmployeeByName(key);

            //refresh UI
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = resultset;

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            //show all empoyees
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = EmployeeManager.employees;

            this.keyTextbox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = this.nameTextbox.Text;
            string id = this.idTextbox.Text;
            string gender = this.genderComboBox.Text;

            //create employee object
            Employee newEm = new Employee(name, gender, id);

            //add list
            EmployeeManager.employees.Add(newEm);
            MessageBox.Show("Add success!");
            //refresh datagridview
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = EmployeeManager.employees;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove selected employee
            DialogResult result = MessageBox.Show("Are you suree to remove the selected item?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                //get the selected item Id
                string id = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                EmployeeManager.remove(id);
                MessageBox.Show("remove success!");

                //refresh UI
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = EmployeeManager.employees;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //save data to txt file
            EmployeeManager.SaveEmployeeToFile("employee.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get selected item
            string name = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string gender = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string id = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           

            Employee em = new Employee(name, gender, id);

            //pass updated employee to the updateForm
            UpdateForm form = new UpdateForm(em);
            DialogResult result = form.ShowDialog();

            if(result == DialogResult.OK)
            {
                MessageBox.Show("update success!");
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = EmployeeManager.employees;
            }

        }
    }
}
