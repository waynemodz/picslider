using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ModzDev___Pic_Slider;

namespace ModzDev___Pic_Slider
{
    public partial class fmSliderWindow : Form
    {
        Main MF;
        public fmSliderWindow(Main XParent)
        {
            InitializeComponent();
            MF = XParent;
        }

        public void ShowPic(string Filename, Boolean AutoSize)
        {
            if (File.Exists(Filename) == true)
            {
                pic.ImageLocation = Filename;
                if (AutoSize == false)
                {
                    pic.SizeMode = PictureBoxSizeMode.CenterImage;
                } else
                {
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                } 
            }
            
        }

        private void pic_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            pic.Width = this.Width;
            pic.Height = this.Height;
            pic.Left = 0;
            pic.Top = 0;
            this.Focus();
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MF.BLeft.PerformClick();
                pic.ImageLocation = MF.SelFil;
            }

            if (e.KeyCode == Keys.Right)
            {
                MF.BRight.PerformClick();
                pic.ImageLocation = MF.SelFil;               
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.Space | e.KeyCode ==Keys.Down) 
            {
                if (pic.SizeMode == PictureBoxSizeMode.CenterImage)
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                else
                    pic.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            if (e.KeyCode ==Keys.Up)
            {
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }


}
