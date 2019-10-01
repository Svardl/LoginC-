namespace signinpar2
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.Userbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(17, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(17, 175);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Userbox
            // 
            this.Userbox.Location = new System.Drawing.Point(22, 118);
            this.Userbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(251, 22);
            this.Userbox.TabIndex = 0;
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(22, 213);
            this.Passbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(251, 22);
            this.Passbox.TabIndex = 2;
            this.Passbox.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(181, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create a new account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(22, 262);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(96, 30);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(303, 214);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(178, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(198, 32);
            label3.TabIndex = 7;
            label3.Text = "Botterson chat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 308);
            this.Controls.Add(label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(label2);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(label1);
            this.Controls.Add(this.Userbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

