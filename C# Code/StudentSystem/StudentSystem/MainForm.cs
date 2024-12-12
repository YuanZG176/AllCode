using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class MainForm : Form
    {

        //private List<Student> students = new List<Student>();
        private BindingList<Student> students = new BindingList<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initial();
        }

        private void initial()
        {
            Student s1 = new Student(100,"tom");
            Student s2 = new Student(101,"jack");
            Student s3 = new Student(102,"cal");
            Student s4 = new Student(103,"rol");
            students.Add(s1);
            students.Add(s2);   
            students.Add(s3);   
            students.Add(s4);

            this.dataGridView1.DataSource = students;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string key = this.KeyTextBox.Text;
            List<Student> res = new List<Student>();
            foreach (Student s in students)
            {
                if (s.Name.Contains(key))
                {
                    res.Add(s);
                }
            }

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = res;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
/*            AddForm f = new AddForm();
            DialogResult r = f.ShowDialog();
            if (r == DialogResult.OK) { 
                students.Add(f.newStudent);
            }
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = students;*/



            using (AddForm f = new AddForm())
            {
                DialogResult r = f.ShowDialog();
                if (r == DialogResult.OK)
                {
                    students.Add(f.newStudent);
                }
            }

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = students;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                DialogResult result = MessageBox.Show("你确定删除吗?", "提示", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    List<Student> studentsToDelete = new List<Student>();
                    foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                    {
                        int num = Convert.ToInt32(row.Cells[0].Value.ToString());
                        studentsToDelete.Add(students.First(s => s.Num == num));
                    }

                    // 在收集之后删除学生
                    foreach (var student in studentsToDelete)
                    {
                        students.Remove(student);
                    }

                    // 刷新 DataGridView
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = students;
                }
            }
            else
            {
                MessageBox.Show("请选择行数");
            }



            /*            int count = this.dataGridView1.SelectedRows.Count;
                        if (count > 0) {
                            DialogResult result = MessageBox.Show("你确定删除吗?", "提示",MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK) {
                                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows) {
                                    int num = Convert.ToInt32(row.Cells[0].Value.ToString());
                                    foreach (Student s in students) {
                                        if (s.Num == num) {
                                            students.Remove(s);
                                            break;
                                        }
                                    }
                                } this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = students;
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择行数");
                        }*/
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
