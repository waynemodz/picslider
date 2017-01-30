//MSharp Pic Slider
//www.msharp.co.za
//Developed by Pranashan Moodley aka Wayne Moodley


//Please note this project is under the Common Development and Distribution License (CDDL-1.0)

//This pic slider is a simple project to learn how file paths, directorys work,
//listing file types, displaying images.
//Unfortuantely I did not proper error handling in all the areas.

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

namespace ModzDev___Pic_Slider
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //These are public declared actions for the slideshow window, so they can access these buttons
        public  Button BLeft 
        {
            get { return bUp; } 
        }

        public  Button BRight 
        {
            get { return bDown; } 
        }

        //keep the selected file name public

        public String SelFil
        {
            get { return tbDir.Text + "\\" + listBox1.SelectedItem.ToString(); }
        }

        private void refreshdata()
        {
                listBox1.Enabled = true;
                listBox1.Items.Clear();
                DirectoryInfo dinfo = new DirectoryInfo(tbDir.Text);
                
                //list all following file types
                FileInfo[] BFiles = dinfo.GetFiles("*.bmp");
                foreach (FileInfo file in BFiles)
                {
                    listBox1.Items.Add(file.Name);
                }
                FileInfo[] Files = dinfo.GetFiles("*.jpg");
                foreach (FileInfo file in Files)
                {
                    listBox1.Items.Add(file.Name);
                }

                FileInfo[] JFiles = dinfo.GetFiles("*.jpeg");
                foreach (FileInfo file in JFiles)
                {
                    listBox1.Items.Add(file.Name);
                }

                FileInfo[] PFiles = dinfo.GetFiles("*.png");
                foreach (FileInfo file in PFiles)
                {
                    listBox1.Items.Add(file.Name);
                }


                FileInfo[] GFiles = dinfo.GetFiles("*.gif");
                foreach (FileInfo file in GFiles)
                {
                    listBox1.Items.Add(file.Name);
                }

                listBox1.SelectedIndex = 0;

        }

        //Enable controls to avoid application crashing
        private void EnableControls()
        {
            bRemove.Enabled=true;
            bUp.Enabled = true;
            bDown.Enabled = true;
            bRef.Enabled = true;
            bStart.Enabled = true;
            cbLoop.Enabled = true;
            cbPreview.Enabled = true;
            cbStretch.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbDir.Text;                 //Set dialog box to current path
            DialogResult result = this.folderBrowserDialog1.ShowDialog();   
            if (result == DialogResult.OK)
            {
                tbDir.Text = folderBrowserDialog1.SelectedPath;
                refreshdata();
                EnableControls();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)                  //check if theres any items to even display
                return; 
            if (listBox1.SelectedIndex == -1)               //check if the list has a selection
                listBox1.SelectedIndex = 0;
            {                                               //create a new slide box, and show pic.
                fmSliderWindow SlideBox = new fmSliderWindow(this);
                SlideBox.Show();
                string fn = tbDir.Text + "\\" + listBox1.SelectedItem.ToString();
                SlideBox.ShowPic(fn, cbStretch.Checked);
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            if (listBox1.SelectedIndex == 0 & cbLoop.Checked ==true)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            } 
                else
            if (listBox1.SelectedIndex != 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }

            ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == listBox1.Items.Count-1 & cbLoop.Checked == true)
            {
                listBox1.SelectedIndex = 0;
            } else

            if (listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }

            ShowPreview();
        }

        private void ShowPreview()
        {
            if (cbPreview.CheckState == CheckState.Checked)
                pbPreview.ImageLocation = SelFil;
            else
                pbPreview.ImageLocation = null;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            ShowPreview();

            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = new FileInfo(SelFil).Length;
            if (File.Exists(this.SelFil) == true)
            {
                int order = 0;
                while (len >= 1024 && order + 1 < sizes.Length)
                {
                    order++;
                    len = len / 1024;
                    string xresult = String.Format("{0:0.##} {1}", len, sizes[order]);
                    tsslSize.Text = xresult;
                }

            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                bRemove.PerformClick();
            ShowPreview();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            refreshdata();
        }

        private void tbDir_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refreshdata();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fmAbout f = new fmAbout();
            f.ShowDialog();
        }

    }
    
}
