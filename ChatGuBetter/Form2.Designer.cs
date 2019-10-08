namespace ChatGuBetter
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowRadioEmoji = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.OutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.alertpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AndOrPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AndBtn = new System.Windows.Forms.RadioButton();
            this.OrBtn = new System.Windows.Forms.RadioButton();
            this.AndOrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reactions Search";
            // 
            // flowRadioEmoji
            // 
            this.flowRadioEmoji.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowRadioEmoji.Location = new System.Drawing.Point(58, 166);
            this.flowRadioEmoji.Name = "flowRadioEmoji";
            this.flowRadioEmoji.Size = new System.Drawing.Size(917, 112);
            this.flowRadioEmoji.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 366);
            this.comboBox1.MaxDropDownItems = 9;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(36, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutPanel
            // 
            this.OutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutPanel.AutoScroll = true;
            this.OutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPanel.Location = new System.Drawing.Point(12, 509);
            this.OutPanel.Name = "OutPanel";
            this.OutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.OutPanel.Size = new System.Drawing.Size(963, 462);
            this.OutPanel.TabIndex = 5;
            this.OutPanel.WrapContents = false;
            // 
            // alertpanel
            // 
            this.alertpanel.Location = new System.Drawing.Point(14, 418);
            this.alertpanel.Name = "alertpanel";
            this.alertpanel.Size = new System.Drawing.Size(960, 82);
            this.alertpanel.TabIndex = 6;
            // 
            // AndOrPanel
            // 
            this.AndOrPanel.Controls.Add(this.AndBtn);
            this.AndOrPanel.Controls.Add(this.OrBtn);
            this.AndOrPanel.Location = new System.Drawing.Point(714, 46);
            this.AndOrPanel.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.AndOrPanel.Name = "AndOrPanel";
            this.AndOrPanel.Size = new System.Drawing.Size(209, 77);
            this.AndOrPanel.TabIndex = 7;
            // 
            // AndBtn
            // 
            this.AndBtn.AutoSize = true;
            this.AndBtn.Checked = true;
            this.AndBtn.Location = new System.Drawing.Point(3, 3);
            this.AndBtn.Name = "AndBtn";
            this.AndBtn.Size = new System.Drawing.Size(63, 24);
            this.AndBtn.TabIndex = 0;
            this.AndBtn.TabStop = true;
            this.AndBtn.Text = "And";
            this.AndBtn.UseVisualStyleBackColor = true;
            // 
            // OrBtn
            // 
            this.OrBtn.AutoSize = true;
            this.OrBtn.Location = new System.Drawing.Point(72, 3);
            this.OrBtn.Name = "OrBtn";
            this.OrBtn.Size = new System.Drawing.Size(51, 24);
            this.OrBtn.TabIndex = 1;
            this.OrBtn.TabStop = true;
            this.OrBtn.Text = "Or";
            this.OrBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(987, 981);
            this.Controls.Add(this.AndOrPanel);
            this.Controls.Add(this.alertpanel);
            this.Controls.Add(this.OutPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowRadioEmoji);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.AndOrPanel.ResumeLayout(false);
            this.AndOrPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowRadioEmoji;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel OutPanel;
        private System.Windows.Forms.FlowLayoutPanel alertpanel;
        private System.Windows.Forms.FlowLayoutPanel AndOrPanel;
        private System.Windows.Forms.RadioButton AndBtn;
        private System.Windows.Forms.RadioButton OrBtn;
    }
}