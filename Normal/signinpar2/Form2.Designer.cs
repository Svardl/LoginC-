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
            this.reenterbox = new System.Windows.Forms.TextBox();
            this.reenterpassword = new System.Windows.Forms.Label();
            this.creareBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.CheckBox();
            this.takenLab = new System.Windows.Forms.Label();
            this.UserCharacterWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // newuserbox
            // 
            this.newuserbox.Location = new System.Drawing.Point(97, 117);
            this.newuserbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newuserbox.Name = "newuserbox";
            this.newuserbox.Size = new System.Drawing.Size(251, 22);
            this.newuserbox.TabIndex = 2;
            this.newuserbox.TextChanged += new System.EventHandler(this.newuserbox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(95, 211);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // newpasswordbox
            // 
            this.newpasswordbox.Location = new System.Drawing.Point(97, 242);
            this.newpasswordbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newpasswordbox.Name = "newpasswordbox";
            this.newpasswordbox.Size = new System.Drawing.Size(250, 22);
            this.newpasswordbox.TabIndex = 4;
            this.newpasswordbox.UseSystemPasswordChar = true;
            // 
            // reenterbox
            // 
            this.reenterbox.Location = new System.Drawing.Point(96, 306);
            this.reenterbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reenterbox.Name = "reenterbox";
            this.reenterbox.Size = new System.Drawing.Size(252, 22);
            this.reenterbox.TabIndex = 6;
            this.reenterbox.UseSystemPasswordChar = true;
            // 
            // reenterpassword
            // 
            this.reenterpassword.AutoSize = true;
            this.reenterpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterpassword.Location = new System.Drawing.Point(92, 279);
            this.reenterpassword.Name = "reenterpassword";
            this.reenterpassword.Size = new System.Drawing.Size(156, 20);
            this.reenterpassword.TabIndex = 5;
            this.reenterpassword.Text = " Re-enter password";
            // 
            // creareBtn
            // 
            this.creareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creareBtn.Location = new System.Drawing.Point(466, 179);
            this.creareBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creareBtn.Name = "creareBtn";
            this.creareBtn.Size = new System.Drawing.Size(133, 35);
            this.creareBtn.TabIndex = 7;
            this.creareBtn.Text = "Create";
            this.creareBtn.UseVisualStyleBackColor = true;
            this.creareBtn.Click += new System.EventHandler(this.creareBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.AutoSize = true;
            this.showBtn.Location = new System.Drawing.Point(395, 279);
            this.showBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(128, 21);
            this.showBtn.TabIndex = 8;
            this.showBtn.Text = "Show password";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.CheckedChanged += new System.EventHandler(this.showBtn_CheckedChanged);
            // 
            // takenLab
            // 
            this.takenLab.AutoSize = true;
            this.takenLab.ForeColor = System.Drawing.Color.Red;
            this.takenLab.Location = new System.Drawing.Point(353, 117);
            this.takenLab.Name = "takenLab";
            this.takenLab.Size = new System.Drawing.Size(126, 17);
            this.takenLab.TabIndex = 9;
            this.takenLab.Text = "Username is taken";
            // 
            // UserCharacterWarning
            // 
            this.UserCharacterWarning.AutoSize = true;
            this.UserCharacterWarning.ForeColor = System.Drawing.Color.Red;
            this.UserCharacterWarning.Location = new System.Drawing.Point(354, 117);
            this.UserCharacterWarning.Name = "UserCharacterWarning";
            this.UserCharacterWarning.Size = new System.Drawing.Size(295, 17);
            this.UserCharacterWarning.TabIndex = 10;
            this.UserCharacterWarning.Text = "Username has to be longer than 6 characters";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.UserCharacterWarning);
            this.Controls.Add(this.takenLab);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.creareBtn);
            this.Controls.Add(this.reenterbox);
            this.Controls.Add(this.reenterpassword);
            this.Controls.Add(this.newpasswordbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.newuserbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox reenterbox;
        private System.Windows.Forms.Label reenterpassword;
        private System.Windows.Forms.Button creareBtn;
        private System.Windows.Forms.CheckBox showBtn;
        private System.Windows.Forms.Label takenLab;
        private System.Windows.Forms.Label UserCharacterWarning;
    }
}