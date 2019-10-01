using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            this.AcceptButton = loginBtn;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loginBtn_Click(object sender, EventArgs e){
           
            string path = Directory.GetCurrentDirectory() + "\\Userpass.csv";
            var reader = new StreamReader(path);

            List<string> user = new List<string>();
            List<string> pass = new List<string>();
            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                user.Add(values[0]);
                pass.Add(values[1]);
            }

            for (int i = 0; i < user.Count; i++) {
                if (user[i].Equals(Userbox.Text)) {

                    var sha256 = SHA256.Create(); 
                    var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Passbox.Text));
                    string hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                    
                    if (pass[i].Equals(hash)) {
                        this.Hide();
                        Form3 f3 = new Form3(user[i]);
                        f3.ShowDialog();
                        this.Close();
                        return;
                        }
                    }
            }
            MessageBox.Show("Wrong password or username");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e){
            Passbox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
