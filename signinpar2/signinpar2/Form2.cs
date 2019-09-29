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
    public partial class Form2 : Form
    {
        List<string> user;
        string path = Directory.GetCurrentDirectory() + "\\Userpass.csv";
        public Form2()
        {
            //MessageBox.Show(path);
            var reader = new StreamReader(path);

            user = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                user.Add(values[0]);
            }
            reader.Close();
            InitializeComponent();
            takenLab.Visible = false;
        }

        private void creareBtn_Click(object sender, EventArgs e){
         

            if (user.Contains(newuserbox.Text)) {
                MessageBox.Show("That name is taken");
                return;
            
            }

            string account = newuserbox.Text + "," + newpasswordbox.Text;
            File.AppendAllText(path, "\n"+account);
            MessageBox.Show("Account created!");
            this.Close();
            this.Dispose();

        }

        private void showBtn_CheckedChanged(object sender, EventArgs e){
            newpasswordbox.UseSystemPasswordChar = !showBtn.Checked;
        }

        private void newuserbox_TextChanged(object sender, EventArgs e)
        {
            if (user.Contains(newuserbox.Text))
            {
                takenLab.Visible = true;
            }
            else {
                takenLab.Visible = false;
            }
        }
    }
}
