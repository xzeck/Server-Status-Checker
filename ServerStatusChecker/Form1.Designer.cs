namespace ServerStatusChecker
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
            this.WebsiteName = new System.Windows.Forms.TextBox();
            this.CheckStatusbutton = new System.Windows.Forms.Button();
            this.Loglbl = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.statuslabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WebsiteName
            // 
            this.WebsiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteName.Location = new System.Drawing.Point(47, 12);
            this.WebsiteName.Multiline = true;
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.Size = new System.Drawing.Size(425, 61);
            this.WebsiteName.TabIndex = 0;
            // 
            // CheckStatusbutton
            // 
            this.CheckStatusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckStatusbutton.Location = new System.Drawing.Point(168, 94);
            this.CheckStatusbutton.Name = "CheckStatusbutton";
            this.CheckStatusbutton.Size = new System.Drawing.Size(225, 97);
            this.CheckStatusbutton.TabIndex = 1;
            this.CheckStatusbutton.Text = "Check Status";
            this.CheckStatusbutton.UseVisualStyleBackColor = true;
            this.CheckStatusbutton.Click += new System.EventHandler(this.CheckStatusbutton_Click);
            // 
            // Loglbl
            // 
            this.Loglbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loglbl.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loglbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Loglbl.Location = new System.Drawing.Point(12, 203);
            this.Loglbl.Name = "Loglbl";
            this.Loglbl.Size = new System.Drawing.Size(528, 406);
            this.Loglbl.TabIndex = 2;
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.BackgroundImage = global::ServerStatusChecker.Properties.Resources.WebDown;
            this.StatusPictureBox.Location = new System.Drawing.Point(422, 141);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(63, 50);
            this.StatusPictureBox.TabIndex = 3;
            this.StatusPictureBox.TabStop = false;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(418, 94);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(78, 24);
            this.statuslabel.TabIndex = 4;
            this.statuslabel.Text = "Status :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 618);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.StatusPictureBox);
            this.Controls.Add(this.Loglbl);
            this.Controls.Add(this.CheckStatusbutton);
            this.Controls.Add(this.WebsiteName);
            this.Name = "Form1";
            this.Text = "Server Status Check";
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WebsiteName;
        private System.Windows.Forms.Button CheckStatusbutton;
        private System.Windows.Forms.Label Loglbl;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.Label statuslabel;
    }
}

