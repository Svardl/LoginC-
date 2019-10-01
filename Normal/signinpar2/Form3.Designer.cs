namespace signinpar2
{
    partial class Form3
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
            this.SendBox = new System.Windows.Forms.RichTextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(24, 491);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(689, 30);
            this.SendBox.TabIndex = 0;
            this.SendBox.Text = "";
            this.SendBox.TextChanged += new System.EventHandler(this.SendBox_TextChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.Location = new System.Drawing.Point(752, 491);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 30);
            this.SendBtn.TabIndex = 1;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.AutoScroll = true;
            this.DisplayPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DisplayPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisplayPanel.Location = new System.Drawing.Point(24, 22);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DisplayPanel.Size = new System.Drawing.Size(788, 451);
            this.DisplayPanel.TabIndex = 2;
            this.DisplayPanel.WrapContents = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 555);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SendBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SendBox;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.FlowLayoutPanel DisplayPanel;
    }
}