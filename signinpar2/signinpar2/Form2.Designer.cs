namespace signinpar2
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
            this.label2 = new System.Windows.Forms.Label();
            this.newuserbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newpasswordbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reenterpassword = new System.Windows.Forms.Label();
            this.creareBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.CheckBox();
            this.takenLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // newuserbox
            // 
            this.newuserbox.Location = new System.Drawing.Point(109, 146);
            this.newuserbox.Name = "newuserbox";
            this.newuserbox.Size = new System.Drawing.Size(282, 26);
            this.newuserbox.TabIndex = 2;
            this.newuserbox.TextChanged += new System.EventHandler(this.newuserbox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(106, 239);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 29);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // newpasswordbox
            // 
            this.newpasswordbox.Location = new System.Drawing.Point(110, 289);
            this.newpasswordbox.Name = "newpasswordbox";
            this.newpasswordbox.Size = new System.Drawing.Size(281, 26);
            this.newpasswordbox.TabIndex = 4;
            this.newpasswordbox.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 6;
            // 
            // reenterpassword
            // 
            this.reenterpassword.AutoSize = true;
            this.reenterpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterpassword.Location = new System.Drawing.Point(104, 332);
            this.reenterpassword.Name = "reenterpassword";
            this.reenterpassword.Size = new System.Drawing.Size(224, 29);
            this.reenterpassword.TabIndex = 5;
            this.reenterpassword.Text = " Re-enter password";
            // 
            // creareBtn
            // 
            this.creareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareBtn.Location = new System.Drawing.Point(524, 224);
            this.creareBtn.Name = "creareBtn";
            this.creareBtn.Size = new System.Drawing.Size(150, 44);
            this.creareBtn.TabIndex = 7;
            this.creareBtn.Text = "Create";
            this.creareBtn.UseVisualStyleBackColor = true;
            this.creareBtn.Click += new System.EventHandler(this.creareBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.AutoSize = true;
            this.showBtn.Location = new System.Drawing.Point(436, 290);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(147, 24);
            this.showBtn.TabIndex = 8;
            this.showBtn.Text = "Show password";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.CheckedChanged += new System.EventHandler(this.showBtn_CheckedChanged);
            // 
            // takenLab
            // 
            this.takenLab.AutoSize = true;
            this.takenLab.ForeColor = System.Drawing.Color.Red;
            this.takenLab.Location = new System.Drawing.Point(397, 146);
            this.takenLab.Name = "takenLab";
            this.takenLab.Size = new System.Drawing.Size(142, 20);
            this.takenLab.TabIndex = 9;
            this.takenLab.Text = "Username is taken";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.takenLab);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.creareBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reenterpassword);
            this.Controls.Add(this.newpasswordbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.newuserbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newuserbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox newpasswordbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label reenterpassword;
        private System.Windows.Forms.Button creareBtn;
        private System.Windows.Forms.CheckBox showBtn;
        private System.Windows.Forms.Label takenLab;
    }
}