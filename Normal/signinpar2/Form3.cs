using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace signinpar2
{
    public partial class Form3 : Form
    {
        string user;
        public Form3(string user)
        {
            this.user = user;
            InitializeComponent();
            this.AcceptButton = SendBtn;

            InitializeComponent();
           
        }

       
        private void SendBtn_Click(object sender, EventArgs e)
        {
            string message = this.SendBox.Text;
            SendBox.AppendText("work");
            SendBox.Clear();

            Label labmsg = new Label();
            labmsg.AutoSize = true;
            labmsg.Text = user + ": " + message;
            MessageBox.Show(labmsg.Text);
            DisplayPanel.Controls.Add(labmsg);
            DisplayPanel.ScrollControlIntoView(labmsg);

        }

        private void SendBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
