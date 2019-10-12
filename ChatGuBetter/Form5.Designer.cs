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
            this.PlayerCountLabel = new ChatGuBetter.Label2();
            this.LeftSidePanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.comboBox1.Location = new System.Drawing.Point(283, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 45);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.AllowDrop = true;
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainPanel.Location = new System.Drawing.Point(242, 274);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(536, 441);
            this.MainPanel.TabIndex = 2;
            // 
            // ScorePanel
            // 
            this.ScorePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScorePanel.AutoSize = true;
            this.ScorePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScorePanel.Location = new System.Drawing.Point(805, 274);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(258, 367);
            this.ScorePanel.TabIndex = 3;
            // 
            // PlayerCountLabel
            // 
            this.PlayerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerCountLabel.AutoSize = true;
            this.PlayerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCountLabel.Location = new System.Drawing.Point(216, 65);
            this.PlayerCountLabel.Name = "PlayerCountLabel";
            this.PlayerCountLabel.Size = new System.Drawing.Size(370, 46);
            this.PlayerCountLabel.TabIndex = 0;
            this.PlayerCountLabel.Text = "How many players?";
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftSidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LeftSidePanel.Location = new System.Drawing.Point(-1, 274);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Size = new System.Drawing.Size(227, 331);
            this.LeftSidePanel.TabIndex = 4;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1197, 700);
            this.Controls.Add(this.LeftSidePanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PlayerCountLabel);
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
    }
}