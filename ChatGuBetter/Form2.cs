using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ChatGuBetter {
    public partial class Form2 : Form {

        JObject o1;
        PictureForm pf;
        //string path = "C:\\Users\\Svardl\\Documents\\ChatguiResources\\";
        string path;
        string[] emojiNames = new string[] { "Shocked emoji", "Grinning Squinting Face", "Heart eyes emoji", "Crying Face", "Eyes", "Angry Face", "Thumbs Up", "Thumbs Down" };
        bool clicked;
        public Form2(JObject o1, string path) {
            this.o1 = o1;
            this.path = path;
            InitializeComponent();
            foreach (string name in emojiNames) {
                CheckBox cb = new CheckBox();
                cb.Text = name;
                cb.AutoSize = true;
                flowRadioEmoji.Controls.Add(cb);
            }
            CheckBox allCb = new CheckBox() { Text = "Select all", AutoSize = true };
            flowRadioEmoji.Controls.Add(allCb);
            allCb.CheckedChanged += (object sender, EventArgs e) => {
                foreach (CheckBox cb in flowRadioEmoji.Controls) {
                    if(cb!=allCb)
                        cb.Checked = allCb.Checked;
                }
            };
            SetDropdown();
        }

        public void SetDropdown() {
            comboBox1.Items.Add("All");
            var participant = o1["participants"];
            foreach (var person in participant) {
                comboBox1.Items.Add(person["name"].ToString());
            }
            comboBox1.SelectedItem = "All";
        }

        private void button2_Click(object sender, EventArgs e) {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form1.ClearPanel(OutPanel);
            ReactSearch();
        }
        public void ReactSearch() {

            List<string> selectedEm = new List<string>();

            foreach (CheckBox cb in flowRadioEmoji.Controls) {
                if (cb.Checked)
                    selectedEm.Add(cb.Text);
            }
            if (selectedEm.Count == 0)
                return;

            string selectedName = "NoName";
            if (!comboBox1.SelectedItem.Equals("All"))
                selectedName = comboBox1.SelectedItem.ToString();

            int[] emojiCount = new int[selectedEm.Count];
            List<int[]> msgList = new List<int[]>();
            List<JToken> MsgObList = new List<JToken>();
            int count = 0;
            foreach (var messageObj in o1["messages"]) {
                messageObj["Id"] = count;
                count++;
                if (messageObj["reactions"] != null && ((messageObj["sender_name"].ToString() == selectedName) || selectedName.Equals("NoName"))) {
                    foreach (var emojiObj in messageObj["reactions"]) {
                        string emoji = emojiObj["reaction"].ToString();
                        string convEmoji = EmojiConversion(emoji);
                        if (selectedEm.Contains(convEmoji)) {
                            emojiCount[selectedEm.IndexOf(convEmoji)]++;
                        }
                    }
                    if (AndBtn.Checked) {
                        if (!emojiCount.Contains(0)) {
                            int[] copy = (int[])emojiCount.Clone();
                            msgList.Add(copy);
                            MsgObList.Add(messageObj);
                        }
                    }
                    else if (OrBtn.Checked) {
                        int[] copy = (int[])emojiCount.Clone();
                        msgList.Add(copy);
                        MsgObList.Add(messageObj);
                    }
                    Array.Clear(emojiCount, 0, emojiCount.Count());
                }
            }

            int length = msgList.Count > 30 ? 30 : msgList.Count;
            int maximum = -1;
            int index = -1;
            for (int j = 0; j < length; j++) {
                for (int i = j; i < msgList.Count; i++) {
                    int value = msgList[i].Sum();
                    if (value > maximum) {
                        maximum = value;
                        index = i;
                    }
                }
                DisplayMessage(MsgObList[index], selectedName.Equals("NoName"));
                // DisplayReactions(selectedEm, msgList[index]);
                DisplayReactions2(MsgObList[index]);
                var temp = msgList[index];
                msgList[index] = msgList[j];
                msgList[j] = temp;

                var temp2 = MsgObList[index];
                MsgObList[index] = MsgObList[j];
                MsgObList[j] = temp2;

                maximum = -1;
            }
        }

        public void DisplayReactions2(JToken msgObj) {
            if (msgObj["reactions"] == null) { 
                 OutPanel.Controls.Add((new Label()));
                 return;
        }

            Label lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font(lab.Font.Name, 8);
            Dictionary<string, int> amount = new Dictionary<string, int>();

            foreach (JToken reaction in msgObj["reactions"]) {
                String emoji = EmojiConversion(reaction["reaction"].ToString());
                if (!amount.ContainsKey(emoji)) {
                    amount.Add(emoji, 1);
                }
                else {
                    amount[emoji]++;
                }  
            }
            foreach (String key in amount.Keys) {
                lab.Text += key + ": " + amount[key] + "         ";
            }
            OutPanel.Controls.Add(lab);
            OutPanel.Controls.Add((new Label()));

        } 
        
            public void DisplayReactions(List<string> selectedEm, int[] emojiCount) {
            Label lab = new Label();
            lab.AutoSize = true;
            lab.Font = new System.Drawing.Font(lab.Font.Name,8);

            for (int i = 0; i < selectedEm.Count; i++) {

                lab.Text += selectedEm[i] + ": " + emojiCount[i] + "         ";
            }
            OutPanel.Controls.Add(lab);
            OutPanel.Controls.Add((new Label()));
        
        }
        public void DisplayMessage(JToken msgObj, Boolean doAuthor, Boolean color=false){

            if (doAuthor) {
                Label name = new Label() { AutoSize = true, Text=msgObj["sender_name"].ToString()+": ", Font = new Font(Font, FontStyle.Bold)};
                OutPanel.Controls.Add(name);
            }

            if (msgObj["content"] != null) {
                Label content = new Label();
                content.Text = msgObj["content"].ToString();
                content.AutoSize = true;
                OutPanel.Controls.Add(content);
                if (color) {
                    content.ForeColor = System.Drawing.Color.Red;
                    OutPanel.ScrollControlIntoView(content);
                }
                content.Click += new EventHandler(Label_Click);
                content.Tag = (int)msgObj["Id"];
            }
            else if (msgObj["photos"] != null || msgObj["gifs"] != null || msgObj["videos"] != null) {

                var imageOrGif = msgObj["photos"] != null ? msgObj["photos"] : msgObj["gifs"];
                if (msgObj["videos"]!=null) {
                    imageOrGif = msgObj["videos"];
                }

                foreach (var photo in imageOrGif) {
                    string uri = msgObj["videos"]!=null ? path+ photo["thumbnail"]["uri"] :path + photo["uri"].ToString();
                    System.Drawing.Image img = System.Drawing.Image.FromFile(uri);
                    PictureBox photos = new PictureBox() {
                        Image = img,
                        Width = img.Width / 3,
                        Height = img.Height / 3,
                        SizeMode = PictureBoxSizeMode.Zoom,
                    };
                    OutPanel.Controls.Add(photos);
                    if (color) {
                        OutPanel.ScrollControlIntoView(photos);
                    }
                    if (msgObj["videos"] != null) {
                        photos.MouseClick += VideoClick;
                        photos.MouseDoubleClick += VideoClick;
                    }
                    else {
                        photos.MouseClick += MouseClick;
                        photos.MouseDoubleClick += MouseClick;
                    }
                    photos.Tag = (int)msgObj["Id"];
                }
            }
        }
        private void Label_Click(object sender, EventArgs e) {
            Form1.ClearPanel(OutPanel);
            dynamic msg = null;
            if (sender is Label)
                msg = (Label)sender;
            else if (sender is PictureBox) {
                msg = (PictureBox)sender; 
            }

            int index =(int) msg.Tag;
            for (int i = index + 15; i >= index - 15; i--) {
                DisplayMessage(o1["messages"][i], true, i==index);
                DisplayReactions2(o1["messages"][i]);
            }
        }

        private async void MouseClick(object sender, MouseEventArgs e) {
            if (e.Clicks == 2) {

                clicked = false;
                Picture_Click(sender, e);
               
            }
            else if (e.Clicks == 1) {

                if (clicked) return;
                clicked = true;
                await Task.Delay(SystemInformation.DoubleClickTime);
                if (!clicked) return;
                clicked = false;
                Label_Click(sender, e);
            }
        }

        private string GetUri(PictureBox lab) {

            JToken msgObj = o1["messages"][(int)lab.Tag];
            string videoPath = path+ msgObj["videos"][0]["uri"].ToString();
            return videoPath;
        }
        private async void VideoClick(object sender, MouseEventArgs e) {
            if (e.Clicks == 2) {

                clicked = false;
                PictureBox lab = (PictureBox)sender;
                string video = GetUri(lab);
                VideoForm vf = new VideoForm(video, lab.Height*3, lab.Width*3);
                vf.Show();
            }
            else if (e.Clicks == 1) {

                if (clicked) return;
                clicked = true;
                await Task.Delay(SystemInformation.DoubleClickTime);
                if (!clicked) return;
                clicked = false;
                Label_Click(sender, e);              
            }
        }
        private void Picture_Click(object sender, EventArgs e) {
           
            double Sheight = SystemParameters.FullPrimaryScreenHeight;
            PictureBox pb = (PictureBox)sender;
            System.Drawing.Image img = pb.Image;
            pf = new PictureForm(img);
            pf.Height = Sheight < img.Height ? (int)Sheight + 15 : img.Height;
            pf.Width = img.Width + 20;

            pf.Show();  
        }
        public string EmojiConversion(string emoji)
        {
            switch (emoji)
            {
                case "\u00f0\u009f\u0098\u008d":
                    return "Heart eyes emoji";

                case "\u00f0\u009f\u0098\u00ae":
                    return "Shocked emoji";

                case "\u00f0\u009f\u0098\u0086":
                    return "Grinning Squinting Face";

                case "\u00f0\u009f\u0098\u00a2":
                    return "Crying Face";

                case "\u00f0\u009f\u0091\u0080":
                    return "Eyes";

                case "\u00f0\u009f\u0098\u00a0":
                    return "Angry Face";

                case "\u00f0\u009f\u0091\u008d":
                    return "Thumbs Up";

                case "\u00f0\u009f\u0091\u008e":
                    return "Thumbs Down";

                default:
                    return "Missing";

            }
        }
    }
}
