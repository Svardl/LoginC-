using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatGuBetter {
    public partial class ImageDisplay : Form {
        string path;
        int height = Screen.PrimaryScreen.WorkingArea.Height;
        volatile int count = 0;
        volatile bool canPass = true;
        volatile bool manual = false;

        public ImageDisplay(JObject o1,string path) {
            InitializeComponent();
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            this.path = path;

            this.KeyDown += new KeyEventHandler(KeyDownfunc);

            SentFromLabel.Visible = false;
            StartImageDisplay(o1);
        }
        async public void StartImageDisplay(JObject o1) {

            List<string[]> imStore = new List<string[]>();
            foreach (JToken msgObj in o1["messages"]) {
                if (msgObj["photos"] != null || msgObj["gifs"] != null) {
                    string name = msgObj["sender_name"].ToString();

                    var ImageOrGif = msgObj["photos"]!=null ? msgObj["photos"] : msgObj["gifs"];
                    foreach (JToken photo in ImageOrGif) {
                        imStore.Add(new string[] {name, photo["uri"].ToString() });
                    }
                }
            }

            imStore = imStore.OrderBy(x => Guid.NewGuid()).ToList();

            SentFromLabel.Visible = true;
            while (count < imStore.Count) {

                SentFromLabel.Text = imStore[count][0];
                string imPath = path + imStore[count][1];
                System.Drawing.Image img = System.Drawing.Image.FromFile(imPath);

                double currHeight = img.Height;
                double currWidth = img.Width;

                while (currHeight > height-30) {
                    currHeight /= 1.2;
                    currWidth /= 1.2;
                }
                
                DisplayBox.Width = (int)currWidth;
                DisplayBox.Height = (int)currHeight;
                DisplayBox.Image = img;
             

                await Task.Delay(4000);

                incrementCount(false);
                if (count < 0)
                    count = imStore.Count;
                else if (count > imStore.Count)
                    count = 0;

            }
        }

        public void manualmode() { 
        
        }
        public void KeyDownfunc(Object o, KeyEventArgs e) {


            if (e.KeyCode == Keys.Space) {

                if (canPass)
                    MessageBox.Show("Paused");
                else
                    MessageBox.Show("Unpaused");
                canPass = !canPass;
            }
            else if (e.KeyCode == Keys.Left) {
                count--;
                canPass = false;
            }
            else if (e.KeyCode == Keys.Right) {
                count++;
                canPass = false;

            }
        }
        public void incrementCount(bool valid) {


            if (valid || canPass) {
                count++;
            }
            else {
                canPass = true;
            }

        }
    }
}
