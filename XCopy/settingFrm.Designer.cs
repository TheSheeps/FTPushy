namespace XCopy
{
    partial class settingFrm
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
            this.fromLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromTxtBox = new System.Windows.Forms.TextBox();
            this.toTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(12, 29);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(57, 13);
            this.fromLbl.TabIndex = 0;
            this.fromLbl.Text = "Copy from:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(12, 93);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(46, 13);
            this.toLbl.TabIndex = 1;
            this.toLbl.Text = "Copy to:";
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.Location = new System.Drawing.Point(75, 26);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.Size = new System.Drawing.Size(235, 20);
            this.fromTxtBox.TabIndex = 2;
            // 
            // toTxtBox
            // 
            this.toTxtBox.Location = new System.Drawing.Point(75, 90);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(235, 20);
            this.toTxtBox.TabIndex = 3;
            // 
            // settingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 140);
            this.Controls.Add(this.toTxtBox);
            this.Controls.Add(this.fromTxtBox);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.fromLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "settingFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.settingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.TextBox fromTxtBox;
        private System.Windows.Forms.TextBox toTxtBox;
    }
}