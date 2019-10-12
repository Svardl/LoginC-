namespace ChatGuBetter {
    partial class ImageDisplay {
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
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.SentFromLabel = new ChatGuBetter.Label2();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DisplayBox.Location = new System.Drawing.Point(36, 75);
            this.DisplayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(670, 283);
            this.DisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            // 
            // SentFromLabel
            // 
            this.SentFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SentFromLabel.AutoSize = true;
            this.SentFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentFromLabel.Location = new System.Drawing.Point(187, 7);
            this.SentFromLabel.Name = "SentFromLabel";
            this.SentFromLabel.Size = new System.Drawing.Size(303, 42);
            this.SentFromLabel.TabIndex = 0;
            this.SentFromLabel.Text = "Sent from person";
            // 
            // ImageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.SentFromLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImageDisplay";
            this.Text = "ImageDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label2 SentFromLabel;
        private System.Windows.Forms.PictureBox DisplayBox;
    }
}