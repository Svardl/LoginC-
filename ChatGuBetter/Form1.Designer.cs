﻿namespace ChatGuBetter
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
            this.SearchAll = new System.Windows.Forms.CheckBox();
            this.ShowDatesCheck = new System.Windows.Forms.CheckBox();
            this.DisplayImageBtn = new System.Windows.Forms.Button();
            this.GameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 27);
            this.textBox1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(543, 142);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(88, 36);
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
            this.label1.Location = new System.Drawing.Point(230, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Search";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(9, 184);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(815, 83);
            this.ButtonPanel.TabIndex = 3;
            // 
            // BigPanel
            // 
            this.BigPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BigPanel.AutoScroll = true;
            this.BigPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BigPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BigPanel.Location = new System.Drawing.Point(3, 327);
            this.BigPanel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.BigPanel.Name = "BigPanel";
            this.BigPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BigPanel.Size = new System.Drawing.Size(821, 457);
            this.BigPanel.TabIndex = 4;
            this.BigPanel.WrapContents = false;
            // 
            // NowReadingLab
            // 
            this.NowReadingLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NowReadingLab.AutoSize = true;
            this.NowReadingLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowReadingLab.Location = new System.Drawing.Point(113, 270);
            this.NowReadingLab.Name = "NowReadingLab";
            this.NowReadingLab.Size = new System.Drawing.Size(481, 36);
            this.NowReadingLab.TabIndex = 5;
            this.NowReadingLab.Text = "Now reading messages from Niclas";
            this.NowReadingLab.Click += new System.EventHandler(this.NowReadingLab_Click);
            // 
            // EmojiBtn
            // 
            this.EmojiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmojiBtn.ForeColor = System.Drawing.Color.Green;
            this.EmojiBtn.Location = new System.Drawing.Point(24, 26);
            this.EmojiBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmojiBtn.Name = "EmojiBtn";
            this.EmojiBtn.Size = new System.Drawing.Size(136, 41);
            this.EmojiBtn.TabIndex = 6;
            this.EmojiBtn.Text = "Reactions";
            this.EmojiBtn.UseVisualStyleBackColor = true;
            this.EmojiBtn.Click += new System.EventHandler(this.EmojiBtn_Click);
            // 
            // SearchAll
            // 
            this.SearchAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchAll.AutoSize = true;
            this.SearchAll.Location = new System.Drawing.Point(700, 67);
            this.SearchAll.Name = "SearchAll";
            this.SearchAll.Size = new System.Drawing.Size(94, 21);
            this.SearchAll.TabIndex = 7;
            this.SearchAll.Text = "Search All";
            this.SearchAll.UseVisualStyleBackColor = true;
            this.SearchAll.CheckedChanged += new System.EventHandler(this.SearchAll_CheckedChanged);
            // 
            // ShowDatesCheck
            // 
            this.ShowDatesCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowDatesCheck.AutoSize = true;
            this.ShowDatesCheck.Location = new System.Drawing.Point(679, 285);
            this.ShowDatesCheck.Name = "ShowDatesCheck";
            this.ShowDatesCheck.Size = new System.Drawing.Size(105, 21);
            this.ShowDatesCheck.TabIndex = 8;
            this.ShowDatesCheck.Text = "Show Dates";
            this.ShowDatesCheck.UseVisualStyleBackColor = true;
            this.ShowDatesCheck.CheckedChanged += new System.EventHandler(this.ShowDatesCheck_CheckedChanged);
            // 
            // DisplayImageBtn
            // 
            this.DisplayImageBtn.Location = new System.Drawing.Point(22, 82);
            this.DisplayImageBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayImageBtn.Name = "DisplayImageBtn";
            this.DisplayImageBtn.Size = new System.Drawing.Size(137, 35);
            this.DisplayImageBtn.TabIndex = 9;
            this.DisplayImageBtn.Text = "Display Image";
            this.DisplayImageBtn.UseVisualStyleBackColor = true;
            this.DisplayImageBtn.Click += new System.EventHandler(this.DisplayImageBtn_Click);
            // 
            // GameBtn
            // 
            this.GameBtn.Location = new System.Drawing.Point(22, 138);
            this.GameBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameBtn.Name = "GameBtn";
            this.GameBtn.Size = new System.Drawing.Size(136, 37);
            this.GameBtn.TabIndex = 10;
            this.GameBtn.Text = "Play Game";
            this.GameBtn.UseVisualStyleBackColor = true;
            this.GameBtn.Click += new System.EventHandler(this.GameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(827, 790);
            this.Controls.Add(this.GameBtn);
            this.Controls.Add(this.DisplayImageBtn);
            this.Controls.Add(this.ShowDatesCheck);
            this.Controls.Add(this.SearchAll);
            this.Controls.Add(this.EmojiBtn);
            this.Controls.Add(this.NowReadingLab);
            this.Controls.Add(this.BigPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.CheckBox SearchAll;
        private System.Windows.Forms.CheckBox ShowDatesCheck;
        private System.Windows.Forms.Button DisplayImageBtn;
        private System.Windows.Forms.Button GameBtn;
    }
}

