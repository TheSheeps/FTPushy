namespace FTPushy
{
    partial class mainFrm
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
            this.settingLbl = new System.Windows.Forms.LinkLabel();
            this.statusLbl = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // settingLbl
            // 
            this.settingLbl.ActiveLinkColor = System.Drawing.Color.Black;
            this.settingLbl.AutoSize = true;
            this.settingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.settingLbl.LinkColor = System.Drawing.Color.Blue;
            this.settingLbl.Location = new System.Drawing.Point(12, 19);
            this.settingLbl.Name = "settingLbl";
            this.settingLbl.Size = new System.Drawing.Size(40, 13);
            this.settingLbl.TabIndex = 0;
            this.settingLbl.TabStop = true;
            this.settingLbl.Text = "Setting";
            this.settingLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingLbl_LinkClicked);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(12, 59);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(60, 13);
            this.statusLbl.TabIndex = 1;
            this.statusLbl.Text = "Status: Idle";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 75);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(553, 95);
            this.listBoxLog.TabIndex = 3;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 189);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.settingLbl);
            this.Name = "mainFrm";
            this.Text = "FTPushy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel settingLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}

