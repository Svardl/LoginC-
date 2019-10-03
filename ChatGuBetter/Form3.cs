using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace ChatGuBetter
{
    public partial class PictureForm : Form
    {
        public PictureForm(System.Drawing.Image img)
        {
            InitializeComponent();

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoScroll = true;
            PictureBox pb = new PictureBox();
            pb.Height = img.Height;
            pb.Width = img.Width;
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            int max = Screen.PrimaryScreen.WorkingArea.Height-25;
            panel.Height = max < img.Height? max-20 : img.Height+10 ;
            panel.Width = img.Width+33;
            panel.Controls.Add(pb);
            this.AutoSize = true;

            this.Controls.Add(panel);
        }
    }
}
