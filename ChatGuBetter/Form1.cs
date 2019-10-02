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
using System.Windows.Forms;

namespace ChatGuBetter
{
    public partial class Form1 : Form{

        String path = "D:\\AllianceDivision\\message_1.json";
       // JObject o1 = JObject.Parse(File.ReadAllText("D:\\AllianceDivision\\message_1.json"));
        JObject o1 = JObject.Parse(File.ReadAllText("C:\\Users\\Svardl\\Documents\\DiscordBot\\ADChatjavaGUI\\message_1.json"));
        Dictionary<string, List<String>> mainDict;
        Dictionary<string, List<int>> NameId;

        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            AcceptButton = SearchBtn;
            NowReadingLab.Visible = false;
            CreateButtons();
        }
        public void CreateButtons() {
            var participant = o1["participants"];
            foreach (var person in participant) {
                ButtonPanel.Controls.Add(new RadioButton() { Text = person["name"].ToString(), AutoSize = true });
            }
            ButtonPanel.Controls.Add(new RadioButton() { Text = "None", AutoSize = true });
        }
        public void DoSearch(String term, string selected=null) {
            if (term == "")
                return;

            ClearPanel(BigPanel);
            mainDict = new Dictionary<string, List<String>>();
            NameId = new Dictionary<string, List<int>>();
            int index = 0;
            foreach (var msg in o1["messages"]){
                if (msg.ToString().Contains("content")) {
                    String content = msg["content"].ToString();
                    String pattern = @"\b" + term.ToLower() + @"\b";

                    if (System.Text.RegularExpressions.Regex.IsMatch(content.ToLower(), pattern)){
                        String name = msg["sender_name"].ToString();

                        if (!mainDict.ContainsKey(name)) {
                            mainDict.Add(name, new List<String>());
                            NameId.Add(name, new List<int>());
                        }
                        mainDict[name].Add(content);
                        NameId[name].Add(index);
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
                foreach(string name in mainDict.Keys) {
                    Label temp = new Label();
                    temp.Text = name + " said " + term +" "+ mainDict[name].Count + " times";
                    temp.AutoSize = true;
                    temp.Font = new System.Drawing.Font(temp.Font.Name, 10);
                    temp.DoubleClick += new EventHandler(Label_Click);
                    BigPanel.Controls.Add(temp);
                    BigPanel.Controls.Add(new Label());
                }
            }
            else {
                string firstname = selected.Substring(0, selected.IndexOf(' '));
                NowReadingLab.Text = "Now reading messages from " + firstname;
                NowReadingLab.Visible = true;
                //foreach (string msg in mainDict[selected]) {
                for(int i =0; i<mainDict[selected].Count; i++) {
                    string msg = mainDict[selected][i];
                    Label2 temp = new Label2();
                    temp.Set(NameId[selected][i]);
                    temp.Text = msg;
                    temp.AutoSize = true;
                    temp.Font = new System.Drawing.Font(temp.Font.Name, 10);
                    temp.DoubleClick += new EventHandler(ContextMsg_Click);
                    BigPanel.Controls.Add(temp);
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
                if (msgObj.ToString().Contains("content")){

                    string msg = msgObj["content"].ToString();
                    string name = msgObj["sender_name"].ToString();

                    Label tempName = new Label() { Text = name+":", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10) };
                    Label2 tempMsg = new Label2{Text = msg, AutoSize = true, Font = new System.Drawing.Font(Font.Name, 10)};
                    tempMsg.Set(i);
                    tempMsg.DoubleClick += new EventHandler(ContextMsg_Click);
                    if (i == index){
                        tempName.ForeColor = System.Drawing.Color.Red;
                        tempMsg.ForeColor = System.Drawing.Color.Red;
                        scrollTarget = tempMsg;
                        
                    }
                    BigPanel.Controls.Add(tempName);
                    BigPanel.Controls.Add(tempMsg);
                    BigPanel.Controls.Add(new Label());
                }
            }
            BigPanel.ScrollControlIntoView(scrollTarget);
        }

        private void SearchBtn_Click(object sender, EventArgs e){
            DoSearch(textBox1.Text);
        }
        public void ClearPanel(FlowLayoutPanel panel) {
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

        private void EmojiBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }

    public class Label2 : Label {
        int num;
        public int GetId() {
            return num;
        }
        public void Set(int num) {
            this.num = num;
        }

    }
}
