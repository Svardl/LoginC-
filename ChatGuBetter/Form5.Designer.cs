namespace ChatGuBetter {
    partial class GameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScorePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftSidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerCountLabel = new ChatGuBetter.Label2();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(230, 124);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.AllowDrop = true;
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainPanel.Location = new System.Drawing.Point(193, 219);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(476, 353);
            this.MainPanel.TabIndex = 2;
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScorePanel.AutoSize = true;
            this.ScorePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScorePanel.Location = new System.Drawing.Point(694, 219);
            this.ScorePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(229, 294);
            this.ScorePanel.TabIndex = 3;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftSidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftSidePanel.Location = new System.Drawing.Point(-23, 219);
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(202, 265);
            this.LeftSidePanel.TabIndex = 4;
            // 
            // PlayerCountLabel
            // 
            this.PlayerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerCountLabel.AutoSize = true;
            this.PlayerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCountLabel.Location = new System.Drawing.Point(170, 52);
            this.PlayerCountLabel.Name = "PlayerCountLabel";
            this.PlayerCountLabel.Size = new System.Drawing.Size(316, 39);
            this.PlayerCountLabel.TabIndex = 0;
            this.PlayerCountLabel.Text = "How many players?";
            // 
            // RestartBtn
            // 
            this.RestartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn.Location = new System.Drawing.Point(716, 94);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(95, 38);
            this.RestartBtn.TabIndex = 5;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1085, 560);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PlayerCountLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label2 PlayerCountLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.FlowLayoutPanel ScorePanel;
        private System.Windows.Forms.FlowLayoutPanel LeftSidePanel;
        private System.Windows.Forms.Button RestartBtn;
    }
}