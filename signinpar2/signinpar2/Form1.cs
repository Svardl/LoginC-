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

namespace signinpar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            string path = Directory.GetCurrentDirectory() + "\\Userpass.csv";
            string path1 = "C:\\Users\\Svardl\\Documents\\DiscordBot\\Userpass.csv";

            var reader = new StreamReader(path);

            List<string> user = new List<string>();
            List<string> pass = new List<string>();
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                var values = line.Split(',');

                user.Add(values[0]);
                pass.Add(values[1]);
            }

            for (int i = 0; i < user.Count; i++) {
                if (user[i].Equals(Userbox.Text)) {
                    if (pass[i].Equals(Passbox.Text)) {
                        MessageBox.Show("Logged in");
                        return;
                    }
                }
            }
            MessageBox.Show("Wrong password or username");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Passbox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
