using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment4_Yuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "courses.txt"; 
            CourseManager.LoadCourses(filename);        
            dataGridView1.DataSource = CourseManager.courses;
            comboBox1.Items.Add(DisplayOption.Code);
            comboBox1.Items.Add(DisplayOption.Name);
            comboBox1.Items.Add(DisplayOption.Prerequisite);
            comboBox1.Items.Add(DisplayOption.Semester);
            comboBox1.Items.Add(DisplayOption.All);
            dataGridView1.DataSource = CourseManager.courses;
        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择搜索条件！", "搜索错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedOption = (DisplayOption)comboBox1.SelectedItem;
            var searchText = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("请输入搜索关键字！", "搜索错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var searchResults = CourseManager.Search(selectedOption, searchText);
            if (searchResults == null || searchResults.Count == 0)
            {
                MessageBox.Show("没有找到匹配的课程！", "搜索结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = searchResults;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的课程。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("确定要删除选中的课程吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var course = row.DataBoundItem as Course;
                    if (course != null)
                    {
                        CourseManager.courses.Remove(course);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = CourseManager.courses;
                MessageBox.Show("选中的课程已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SaveCoursesToFile()
        {
            var filePath = "courses.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var course in CourseManager.courses)
                    {
                        writer.WriteLine($"{course.Code},{course.Name},{course.Description},{course.Semester},{course.Prerequisite}");
                    }
                }
                MessageBox.Show("课程数据已成功保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存课程数据时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCoursesToFile();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveCoursesToFile();
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = CourseManager.courses;
            this.txtSearch.Text = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string code = this.CodetextBox.Text;
            string name = this.NametextBox.Text;
            string description = this.DescriptiontextBox.Text;
            string semester = this.SemestertextBox.Text;
            string prerequisites = this.PrerequisitestextBox.Text;
            Course newCr = new Course(code, name, description, semester, prerequisites);
            CourseManager.courses.Add(newCr);
            MessageBox.Show("Add success!");
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = CourseManager.courses;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string code = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string description = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string name = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string prerequisites = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string semester = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Course cr = new Course(code, name, description, semester, prerequisites);
                if (cr != null)
                {
                    //pass updated employee to the updateForm
                    UpdateForm form = new UpdateForm(cr);
                    form.ShowDialog();
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("update success!");
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = CourseManager.courses;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.");
            }
        }
    }
}
