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
    public partial class GameForm : Form {
        JObject o1;
        string path;
        volatile bool clicked = false;
        ComboBox cb;




        public GameForm(JObject o1, string path) {
            this.o1 = o1;
            this.path = path;
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            int playerCount = Convert.ToInt32(comboBox1.SelectedItem);

            for (int i = 0; i < playerCount; i++) {

                TextBox temp = new TextBox();
                temp.Font = new System.Drawing.Font(temp.Font.Name, 12);
                temp.Size = new Size(500, 20);
                temp.Text = "Enter player " + (i+1) + " name";
                MainPanel.Controls.Add(temp);
            }

            Button goBtn = new Button() { Text= "Go", Size= new Size(75,75)};
            goBtn.Click += new EventHandler(GoBtnClick);
            MainPanel.Controls.Add(goBtn);
        }
        public void GoBtnClick(Object obj, EventArgs e) {

            Dictionary<String, int> PlayerScore = new Dictionary<string, int>();

            for (int i =0; i< MainPanel.Controls.Count-1; i++) {
                string name = MainPanel.Controls[i].Text;
                PlayerScore.Add(name, 0);


                Label score = new Label() { Text = name + ": 0", AutoSize = true, Font = new System.Drawing.Font(Font.Name, 12) };
                ScorePanel.Controls.Add(score);
                ScorePanel.Controls.Add(new Label());
            }
            Form1.ClearPanel(MainPanel);

            PlayGame(PlayerScore);
        
        }
        public async void PlayGame(Dictionary<string, int> PlayerScore) {
            Random rand = new Random();

            CreateComboBoxed();

            Button guessBtn = new Button() {Text="Guess", AutoSize = true};
            guessBtn.Size = new Size(120, 50);
            guessBtn.Click += new EventHandler(GoGuess);
           
            LeftSidePanel.Controls.Add(guessBtn);

            while (!PlayerScore.ContainsValue(10)) {
                int index = 0;
                foreach (string name in PlayerScore.Keys.ToList()) {

                    ScorePanel.Controls[index * 2].ForeColor = Color.Red;

                    Label nameLab = new Label() { Text = name + "'s turn to guess", AutoSize = true, Font= new Font(Font.Name, 14)  };
                    MainPanel.Controls.Add(nameLab);
                    MainPanel.Controls.Add(new Label());

                    String[] authorMsg = GetRandAuthroMsg(rand);

                    Label temp = new Label() { Text="Who said: ", AutoSize=true, Font= new System.Drawing.Font(Font.Name, 11)};
                    Label temp2 = new Label() { Text = authorMsg[1], AutoSize = true, Font = new System.Drawing.Font(Font.Name, 13) };
                    MainPanel.Controls.Add(temp);
                    MainPanel.Controls.Add(temp2);

                    while (!clicked) {
                        await Task.Delay(2000);
                    }
                    clicked = false;

                    if (cb.SelectedItem.ToString().Equals(authorMsg[0])) {
                        UpdateScorePanel(index);
                        MessageBox.Show("Correct!");
                        PlayerScore[name]++;

                    }
                    else {
                        MessageBox.Show("Incorrect! " + authorMsg[0] + " said it");
                    }
                    Form1.ClearPanel(MainPanel);
                    ScorePanel.Controls[index * 2].ForeColor = Color.Black;

                    index++;
                }
            }
        }

        public void UpdateScorePanel(int index) {

            index *= 2;

            string scoreText = ScorePanel.Controls[index].Text;
            string score = scoreText[scoreText.Length-1].ToString();
            scoreText = scoreText.Replace(score, (Convert.ToInt32(score)+1).ToString());
            ScorePanel.Controls[index].Text = scoreText;
        }
        public void CreateComboBoxed() {
            cb = new ComboBox();
            cb.DropDownWidth = 250;
            cb.Width = 200;

            foreach (JToken participants in o1["participants"]) {
                string name = participants["name"].ToString();
                cb.Items.Add(name);
                cb.Font = new Font(cb.Font.Name, 12);
                LeftSidePanel.Controls.Add(cb);
            }
        }
        public void GoGuess(Object obs, EventArgs e) {

            if(cb.SelectedItem !=null)
                clicked = true;
            
        }
        public String[] GetRandAuthroMsg(Random rand) {

            int index;
            do {
                index = rand.Next(0, o1["messages"].Count());
            }
            while (o1["messages"][index]["content"] == null || o1["messages"][index]["share"]!=null || !o1["messages"][index]["content"].ToString().Contains(" ") || o1["messages"][index]["content"].ToString().Count() < 30 );
            
            String[] result = new String[2];
            result[0] = o1["messages"][index]["sender_name"].ToString();

            string test = o1["messages"][index].ToString();
            result[1] = o1["messages"][index]["content"].ToString();

            return result;
        }
    }
}
