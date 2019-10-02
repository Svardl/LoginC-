namespace ChatGuBetter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BigPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NowReadingLab = new System.Windows.Forms.Label();
            this.EmojiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(267, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 31);
            this.textBox1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(611, 178);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(99, 45);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alliance Divison Search";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(10, 230);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(917, 80);
            this.ButtonPanel.TabIndex = 3;
            // 
            // BigPanel
            // 
            this.BigPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BigPanel.AutoScroll = true;
            this.BigPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BigPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BigPanel.Location = new System.Drawing.Point(10, 423);
            this.BigPanel.Margin = new System.Windows.Forms.Padding(3, 25, 3, 25);
            this.BigPanel.Name = "BigPanel";
            this.BigPanel.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.BigPanel.Size = new System.Drawing.Size(924, 550);
            this.BigPanel.TabIndex = 4;
            this.BigPanel.WrapContents = false;
            // 
            // NowReadingLab
            // 
            this.NowReadingLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NowReadingLab.AutoSize = true;
            this.NowReadingLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowReadingLab.Location = new System.Drawing.Point(127, 337);
            this.NowReadingLab.Name = "NowReadingLab";
            this.NowReadingLab.Size = new System.Drawing.Size(583, 40);
            this.NowReadingLab.TabIndex = 5;
            this.NowReadingLab.Text = "Now reading messages from Niclas";
            this.NowReadingLab.Click += new System.EventHandler(this.NowReadingLab_Click);
            // 
            // EmojiBtn
            // 
            this.EmojiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmojiBtn.ForeColor = System.Drawing.Color.Green;
            this.EmojiBtn.Location = new System.Drawing.Point(44, 45);
            this.EmojiBtn.Name = "EmojiBtn";
            this.EmojiBtn.Size = new System.Drawing.Size(112, 45);
            this.EmojiBtn.TabIndex = 6;
            this.EmojiBtn.Text = "Reactions";
            this.EmojiBtn.UseVisualStyleBackColor = true;
            this.EmojiBtn.Click += new System.EventHandler(this.EmojiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(930, 971);
            this.Controls.Add(this.EmojiBtn);
            this.Controls.Add(this.NowReadingLab);
            this.Controls.Add(this.BigPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel BigPanel;
        private System.Windows.Forms.Label NowReadingLab;
        private System.Windows.Forms.Button EmojiBtn;
    }
}

