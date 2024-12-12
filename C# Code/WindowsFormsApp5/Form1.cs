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
    public partial class Form1 : Form
    {
        //datasource
        private List<Music> musics;

        public Form1()
        {
            InitializeComponent();
        }
        //custom method
        private void Initialize()
        {
            //Hip
            //Classic
            //Popular
            musics = new List<Music>();
            musics.Add(new Music("music1", "singer1", 2001, "Hip"));
            musics.Add(new Music("music2", "singer2", 2011, "Classic"));
            musics.Add(new Music("music3", "singer1", 2021, "Popular"));
            musics.Add(new Music("music4", "singer2", 2021, "Hip"));
            musics.Add(new Music("music5", "singer3", 2022, "Classic"));
            musics.Add(new Music("music6", "singer4", 2021, "Popular"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //invoke the initialize method
            Initialize();
            //set the default seleted item for combobox
            this.cmbStyle.SelectedIndex = 0;
            //bind the datagridview
            //this.dtgMusiclist.MultiSelect = false; 
            this.dtgMusiclist.DataSource = musics;

            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create a new music object
            //this:the current form
            //txbName:one textbox in the form
            //Text: property of the textbox
            string name = this.txbName.Text;
            string singer = this.txbSinger.Text;
            int year = Convert.ToInt32(this.txtYear.Text);
            //SelectedText
            //SelectedIndex
            //SelectedItem
            string style = this.cmbStyle.SelectedItem.ToString();

            //create a music object
            Music m = new Music(name, singer, year, style);

            //add the new music objec to the list
            musics.Add(m);

            //refresh datagridview
            this.dtgMusiclist.DataSource = null;
            this.dtgMusiclist.DataSource = musics;

            MessageBox.Show("Add successful!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            //get the selecteditem
            int count =  this.dtgMusiclist.SelectedRows.Count;
            if(count == 0)
            {
                MessageBox.Show("please select first!");
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure?", "Tip", 
                MessageBoxButtons.OKCancel);

            if (dr == DialogResult.Cancel)
                return;
            for(int i = 0; i < count; i++)
            {
                DataGridViewRow row =  this.dtgMusiclist.SelectedRows[i];
                string name = row.Cells[0].Value.ToString();
                //MessageBox.Show(name);
                foreach (Music m in musics)
                {
                    if (m.Name == name)
                    {
                        musics.Remove(m);
                        break;
                    }
                }
            }
            //refresh datagridview
            this.dtgMusiclist.DataSource = null;
            this.dtgMusiclist.DataSource = musics;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int count = this.dtgMusiclist.SelectedRows.Count;
            if (count == 0)
            {
                MessageBox.Show("please select first!");
                return;
            }
            //get the selected row
            DataGridViewRow row = this.dtgMusiclist.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            //foreach (Music m in musics)
            for(int i=0;i<musics.Count;i++)
            {
                if (musics[i].Name == name)
                {
                    //m is the current music object
                    
                    EditForm form = new EditForm();
                    //pass m to the update form
                    form.currentMusic = musics[i];
                    DialogResult dr =  form.ShowDialog();
                    if(dr == DialogResult.OK)
                    {
                        musics[i] = form.currentMusic;
                        //refresh datagridview
                        this.dtgMusiclist.DataSource = null;
                        this.dtgMusiclist.DataSource = musics;
                        MessageBox.Show("Edit Successful!");
                    }
                    break;
                }
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Login login = (Login)this.Parent;
            //login.Close();
            //this.Owner.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Music> searchList = new List<Music>();
            string key = this.tbxKey.Text;

            foreach (Music m in musics)
            {
                if (m.Name.Contains(key))
                {
                    searchList.Add(m);
                }
            }

            //refresh datagridview
            this.dtgMusiclist.DataSource = null;
            this.dtgMusiclist.DataSource = searchList;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //refresh datagridview
            this.dtgMusiclist.DataSource = null;
            this.dtgMusiclist.DataSource = musics;

            //clear the key
            this.tbxKey.Text = "";
        }
    }
}
