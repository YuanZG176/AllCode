using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_Yuan
{
    public partial class UpdateForm : Form
    {
        private Course currentcourse;
        public UpdateForm(Course course)
        {
            InitializeComponent();
            this.currentcourse = course;
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            // 加载课程数据到界面控件
            this.CodetextBox.Text = this.currentcourse.Code;
            this.NametextBox.Text = this.currentcourse.Name;
            this.DescriptiontextBox.Text = this.currentcourse.Description;
            this.SemestertextBox.Text = this.currentcourse.Semester.ToString();
            this.PrerequisitestextBox.Text = this.currentcourse.Prerequisite;
        }
        private void UpdateForm_Load(object sender, EventArgs e)
        {
/*            this.CodetextBox.Text=this.currentcourse.Code;
            this.NametextBox.Text = this.currentcourse.Name;
            this.DescriptiontextBox.Text = this.currentcourse.Description;
            this.SemestertextBox.Text = (this.currentcourse.Semester.ToString());
            this.PrerequisitestextBox.Text = this.currentcourse.Prerequisite;*/


            string code = this.CodetextBox.Text;
            string name = this.NametextBox.Text;
            string description = this.DescriptiontextBox.Text;
            string semester = this.SemestertextBox.Text;
            string prerequisite = this.PrerequisitestextBox.Text;
            Course newCr = new Course(code,name, description, semester,prerequisite);

            CourseManager.Update(code, name, description, semester, prerequisite);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 更新 currentCourse 的属性
            this.currentcourse.Name = this.NametextBox.Text;
            this.currentcourse.Description = this.DescriptiontextBox.Text;
            this.currentcourse.Semester = int.Parse(this.SemestertextBox.Text);
            this.currentcourse.Prerequisite = this.PrerequisitestextBox.Text;

            // 设置 DialogResult 为 OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
