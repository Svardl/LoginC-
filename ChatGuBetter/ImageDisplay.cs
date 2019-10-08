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
        string path = "C:\\Users\\Svardl\\Documents\\ChatguiResources\\";
        int height = Screen.PrimaryScreen.WorkingArea.Height;

        public ImageDisplay(JObject o1) {
            InitializeComponent();
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            
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
            foreach (string[] nameImage in imStore) {

                SentFromLabel.Text = nameImage[0];
                string imPath = path + nameImage[1];
                System.Drawing.Image img = System.Drawing.Image.FromFile(imPath);

                if (img.Height > height) {

                    DisplayBox.Width = Convert.ToInt32(img.Width / 1.4);
                    DisplayBox.Height = Convert.ToInt32(img.Width / 1.4);
                }
                else {
                    DisplayBox.Width = img.Width;
                    DisplayBox.Height = img.Height;
                }
                DisplayBox.Image = img;
                await Task.Delay(4000);


            }
        }
    }
}
