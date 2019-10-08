using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;


//TODO: Handle links and implement date button
namespace ChatGuBetter
{
    public partial class Form1 : Form{

        //String path = "D:\\AllianceDivision\\Big-search\\";
        string path = "C:\\Users\\Svardl\\Documents\\ChatguiResources\\";
        //JObject o1 = JObject.Parse(File.ReadAllText("D:\\AllianceDivision\\Big-search\\messages\\inbox\\AllianceDivision_5Hy8r-YQIw\\message_1.json"));
        JObject o1 = JObject.Parse(File.ReadAllText("C:\\Users\\Svardl\\Documents\\ChatguiResources\\messages\\inbox\\AllianceDivision_5Hy8r-YQIw\\message_1.json"));
        Dictionary<string, List<String>> mainDict;
        Dictionary<string, List<int>> NameId;

        double Sheight;
        Dictionary<String, Color> colorMap; 

        public Form1(){
            InitializeComponent();
            Sheight = SystemParameters.FullPrimaryScreenHeight;

        }

        private void Form1_Load(object sender, EventArgs e){
            AcceptButton = SearchBtn;
            NowReadingLab.Visible = false;
            CreateButtons();
            colorMap = SetupColors();
        }

        public Dictionary<String, Color> SetupColors() {
            Random rand = new Random();
            Dictionary<String, Color > nameColor = new Dictionary<string, Color>();
            foreach (string name in o1["participants"]) { 
                Color col = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                nameColor.Add(name, col);   
            }
            return nameColor;

        }
        public void CreateButtons() {
        var participant = o1["participants"];
        foreach (var person in participant) {
            ButtonPanel.Controls.Add(new RadioButton() { Text = person["name"].ToString(), AutoSize = true });
        }
        ButtonPanel.Controls.Add(new RadioButton() { Text = "None", AutoSize = true });
        }
        public void DoSearch(String term, string selected=null) {
            if (term  == "" && !SearchAll.Checked)
                return;

            ClearPanel(BigPanel);
            mainDict = new Dictionary<string, List<String>>();
            NameId = new Dictionary<string, List<int>>();
            Dictionary<string, List<string>> TimeStamp = new Dictionary<string, List<string>>();
            int index = 0;
            foreach (var msg in o1["messages"]){
                if (msg.ToString().Contains("content") || SearchAll.Checked || msg["share"]!=null) {
                    String content = msg.ToString().Contains("content") ? msg["content"].ToString() :  "!!Click to view media!!"  ;
                    if (msg["share"] != null) {
                        if(msg["share"]["link"]!=null)
                            content = msg["share"]["link"].ToString();
                    }
                    
                    String pattern = @"\b" + term.ToLower() + @"\b";

                    if (System.Text.RegularExpressions.Regex.IsMatch(content.ToLower(), pattern)){
                        String name = msg["sender_name"].ToString();
                        double timeMs= Convert.ToDouble(msg["timestamp_ms"].ToString());
                        string timeStr = TimespampConverter(timeMs).ToString();

                        if (!mainDict.ContainsKey(name)) {
                            mainDict.Add(name, new List<String>());
                            NameId.Add(name, new List<int>());
                            TimeStamp.Add(name, new List<string>());
                        }
                        mainDict[name].Add(content);
                        NameId[name].Add(index);
                        TimeStamp[name].Add(timeStr);
                    }
                }
                index++;
            }

            if (selected == null) {
                foreach (RadioButton btn in ButtonPanel.Controls){
                    if (btn.Checked){
                        selected = btn.Text;
                    }
                }
            }

            if (mainDict.Count == 0) {
                NowReadingLab.Text = "No one has said "+term;
                NowReadingLab.Visible = true;
                return;

            }

            if ((selected != null && selected != "None") && !mainDict.ContainsKey(selected) ) {
                NowReadingLab.Text = selected + " has never said " + term;
                NowReadingLab.Visible = true;
                return;
            }
           
            if (selected == null || selected == "None"){
                NowReadingLab.Visible = false;
                List<string> sorted = GetOrder(mainDict);

                foreach (string name in sorted) {
                    Label temp = new Label {
                        Text = name + " said " + term + " " + mainDict[name].Count + " times", AutoSize = true,
                        Font = new System.Drawing.Font(Font.Name, 10)
                };
                    
                    temp.Click += new EventHandler(Label_Click);
                    BigPanel.Controls.Add(temp);
                    BigPanel.Controls.Add(new Label());
                }
                
            }
            else {
                string firstname = selected.Substring(0, selected.IndexOf(' '));
                NowReadingLab.Text = "Now reading messages from " + firstname;
                NowReadingLab.Visible = true;

                for(int i =0; i<mainDict[selected].Count; i++) {
                    string msg = mainDict[selected][i];
                    Label2 temp = new Label2();
                    temp.Set(NameId[selected][i]);
                    temp.SetDate(TimeStamp[selected][i]);
                    temp.Text = msg;
                    temp.AutoSize = true;
                    temp.Font = new System.Drawing.Font(temp.Font.Name, 10);
                    temp.DoubleClick += new EventHandler(ContextMsg_Click);

                    BigPanel.Controls.Add(temp);
                    if (ShowDatesCheck.Checked) {
                        Label2 timeLab = new Label2();
                        timeLab.AutoSize = true;
                        timeLab.Text = TimeStamp[selected][i];
                        timeLab.ForeColor = System.Drawing.Color.Aquamarine;
                        BigPanel.Controls.Add(timeLab);
                    }
                    
                    BigPanel.Controls.Add(new Label());
                }
               
            }
        }

        public void ContextMsg_Click(object sender, EventArgs e) {
            NowReadingLab.Text = "Now reading context messages";
            Label2 LabMsg = (Label2)sender;
            String term = LabMsg.Text;
            ClearPanel(BigPanel);
            List<String[]> msgList = new List<String[]>();
            int index = LabMsg.GetId();

            Label scrollTarget = null;
            for (int i = index + 15; i >= index - 15; i--){
                var msgObj = o1["messages"][i];
                string name = msgObj["sender_name"].ToString();
                Label timeLab = new Label();

                double time = Convert.ToDouble(msgObj["timestamp_ms"].ToString());
                timeLab.AutoSize = true;
                timeLab.Text = TimespampConverter(time).ToString();
                timeLab.ForeColor = System.Drawing.Color.Aquamarine;

                if (msgObj.ToString().Contains("content"))
                {
                    string msg = msgObj["content"].ToString();
                    Label tempName = new Label() { Text = name + ":", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    Label2 tempMsg = new Label2 { Text = msg, AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    tempMsg.Set(i);

                    string Date = TimespampConverter(Convert.ToDouble(msgObj["timestamp_ms"].ToString())).ToString();
                    tempMsg.SetDate(Date);
                    tempMsg.DoubleClick += new EventHandler(ContextMsg_Click);
                    if (i == index){
                        tempName.ForeColor = System.Drawing.Color.Red;
                        tempMsg.ForeColor = System.Drawing.Color.Red;
                        scrollTarget = tempMsg;

                    }
                    BigPanel.Controls.Add(tempName);
                    BigPanel.Controls.Add(tempMsg);
                    if (ShowDatesCheck.Checked) 
                        BigPanel.Controls.Add(timeLab);

                    BigPanel.Controls.Add(new Label());
                }
                else if (msgObj.ToString().Contains("photos") || msgObj.ToString().Contains("gifs")){
                    Label tempName = new Label() { Text = name + ":", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    string url = msgObj.ToString().Contains("photos") ? path + msgObj["photos"][0]["uri"].ToString() : path + msgObj["gifs"][0]["uri"].ToString();
                    System.Drawing.Image img = System.Drawing.Image.FromFile(url);
                    PictureBox pb = new PictureBox() {
                        Image=img, Width= img.Width/3, Height = img.Height/3,
                        SizeMode = PictureBoxSizeMode.Zoom, Tag = timeLab.Text
                    };
                    pb.DoubleClick += new EventHandler(Picture_Click);
                    BigPanel.Controls.Add(tempName);
                    BigPanel.Controls.Add(pb);
                    if (ShowDatesCheck.Checked)
                        BigPanel.Controls.Add(timeLab);
                    BigPanel.Controls.Add(new Label());
                }
                else if(msgObj.ToString().Contains("videos")){
 
                    Label tempName = new Label() { Text = name + ":", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    string uri= path + msgObj["videos"][0]["uri"].ToString();
                    Label2 textDisp = new Label2() { Text = "Click here to play media" + ":", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    textDisp.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textDisp.SetUrl(uri);
                    textDisp.DoubleClick += new EventHandler(Picture_Click);
                    BigPanel.Controls.Add(tempName);
                    BigPanel.Controls.Add(textDisp);
                    if (ShowDatesCheck.Checked)
                        BigPanel.Controls.Add(timeLab);
                    BigPanel.Controls.Add(new Label());
                }
            }
            BigPanel.ScrollControlIntoView(scrollTarget);
        }

        private void SearchBtn_Click(object sender, EventArgs e){
            DoSearch(textBox1.Text);
        }
        public static void ClearPanel(FlowLayoutPanel panel) {
            List<Control> listControls = panel.Controls.Cast<Control>().ToList();
            foreach (Control control in listControls){
                panel.Controls.Remove(control);
                control.Dispose();
            }
        }
        public void Label_Click(object sender, EventArgs e) {

            Label label = (Label)sender;
           (string name, string term) = ParseLabel(label.Text);
            DoSearch(term, name);
        }
        public (string name, string term) ParseLabel(string label) {

            int saidIndex = label.IndexOf(" said ");
            string name = label.Substring(0, saidIndex);

            return (name, term:textBox1.Text);
        }
        public int GetIndexOfNth(string str, int n, char c) {
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == c)
                    count++;
                if (count == n)
                    return i; 
            }
            return -1;
        }
        private void NowReadingLab_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Click(object sender, EventArgs e){
            if (sender is Label2){
                Label2 lab = (Label2)sender;
                string video = lab.GetUrl();
                VideoForm vf = new VideoForm(video);
                vf.Show();
            }
            else{
               // int max = Screen.PrimaryScreen.WorkingArea.Height - 25;
                PictureBox pb = (PictureBox)sender;
                System.Drawing.Image img = pb.Image;
                PictureForm pf = new PictureForm(img);
                pf.Height = Sheight < img.Height ? (int)Sheight+15 : img.Height;
                pf.Width = img.Width+20;
                pf.Show();

            }
        }

        private void EmojiBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(o1);
            this.Hide();
            f2.ShowDialog();
            this.Dispose();
            this.Close();
        }

        private void SearchAll_CheckedChanged(object sender, EventArgs e){
            textBox1.Clear();
            textBox1.Enabled = !SearchAll.Checked;
        }
        public List<string> GetOrder(Dictionary<string, List<String>> dict){

            int max = -1;
            string currName = "";
            int count = 0;
            List<string> sorted = new List<string>();

            for (int i = 0; i < dict.Count; i++){
                foreach (String name in dict.Keys){
                    if (dict[name].Count > max && !sorted.Contains(name)){
                        max = dict[name].Count;
                        currName = name;
                    }
                    count++;
                }
                max = -1;
                count = 0;
                sorted.Add(currName);
            }
            return sorted;
        }
        public DateTime TimespampConverter(double timestamp ) {

            timestamp /= 1000;
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(timestamp * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);

            
        }

        private void ShowDatesCheck_CheckedChanged(object sender, EventArgs e) {
            if (ShowDatesCheck.Checked) {
                for (int i = 0; i < BigPanel.Controls.Count; i++) {
                    if (BigPanel.Controls[i] is Label2 || BigPanel.Controls[i] is PictureBox ) {
                        string date = null;
                        if (BigPanel.Controls[i] is Label2 message)
                            date = message.GetDate();
                        else {
                            PictureBox pb = (PictureBox)BigPanel.Controls[i];
                            date = pb.Tag.ToString();

                        }
                        Label dateLab = new Label();
                        dateLab.ForeColor = System.Drawing.Color.Aquamarine;
                        dateLab.Text = date;
                        dateLab.AutoSize = true;
                        BigPanel.Controls.Add(dateLab);
                        BigPanel.Controls.SetChildIndex(dateLab, i + 1);

                    }
                    
                }
            }
            else {
                for (int i = 0; i < BigPanel.Controls.Count; i++) {
                    if (BigPanel.Controls[i].ForeColor == System.Drawing.Color.Aquamarine) {
                        BigPanel.Controls.Remove(BigPanel.Controls[i]);
                    }

                }
            }
        }

        private void DisplayImageBtn_Click(object sender, EventArgs e) {
            ImageDisplay ImD = new ImageDisplay(o1);
            this.Hide();
            ImD.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }


    public class Label2 : Label {
        int num;
        string url;
        string Date;
        public int GetId() {
            return num;
        }
        public void Set(int num) {
            this.num = num;
        }

        public void SetUrl(string url) {
            this.url = url;
        }
        public string GetUrl() {
            return url;
        }

        public void SetDate(string Date){
            this.Date = Date;
        }
        public string GetDate(){
            return Date;
        }

    }
}
