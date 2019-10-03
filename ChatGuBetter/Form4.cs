using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGuBetter
{
    public partial class VideoForm : Form
    {
        public VideoForm(string video){
            InitializeComponent();
            axWindowsMediaPlayer1.stretchToFit = true;

            axWindowsMediaPlayer1.URL = video;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            this.Height = axWindowsMediaPlayer1.Height+45;
            this.Width = axWindowsMediaPlayer1.Width;
        }
    }
}
