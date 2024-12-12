using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class EditForm : Form
    {
        public Music currentMusic;
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.txbName.Text = currentMusic.Name;
            this.txbSinger.Text = currentMusic.Singer;
            this.txtYear.Text = currentMusic.Year.ToString();
            this.cmbStyle.SelectedItem = currentMusic.Style;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update object
            currentMusic.Singer = this.txbSinger.Text;
            currentMusic.Year = Convert.ToInt32(this.txtYear.Text);
            currentMusic.Style = this.cmbStyle.SelectedItem.ToString();

            //close the current form and return Ok
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
