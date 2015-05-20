namespace FTPushy
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
            this.buttonSourceChoose = new System.Windows.Forms.Button();
            this.buttonDestChooser = new System.Windows.Forms.Button();
            this.checkBoxRunStartup = new System.Windows.Forms.CheckBox();
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
            this.toLbl.Location = new System.Drawing.Point(12, 74);
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
            this.toTxtBox.Location = new System.Drawing.Point(75, 71);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(235, 20);
            this.toTxtBox.TabIndex = 3;
            this.toTxtBox.TextChanged += new System.EventHandler(this.toTxtBox_TextChanged);
            // 
            // buttonSourceChoose
            // 
            this.buttonSourceChoose.Location = new System.Drawing.Point(316, 19);
            this.buttonSourceChoose.Name = "buttonSourceChoose";
            this.buttonSourceChoose.Size = new System.Drawing.Size(69, 32);
            this.buttonSourceChoose.TabIndex = 4;
            this.buttonSourceChoose.Text = "Choose";
            this.buttonSourceChoose.UseVisualStyleBackColor = true;
            this.buttonSourceChoose.Click += new System.EventHandler(this.buttonSourceChoose_Click);
            // 
            // buttonDestChooser
            // 
            this.buttonDestChooser.Location = new System.Drawing.Point(316, 64);
            this.buttonDestChooser.Name = "buttonDestChooser";
            this.buttonDestChooser.Size = new System.Drawing.Size(69, 32);
            this.buttonDestChooser.TabIndex = 5;
            this.buttonDestChooser.Text = "Choose";
            this.buttonDestChooser.UseVisualStyleBackColor = true;
            this.buttonDestChooser.Click += new System.EventHandler(this.buttonDestChooser_Click);
            // 
            // checkBoxRunStartup
            // 
            this.checkBoxRunStartup.AutoSize = true;
            this.checkBoxRunStartup.Location = new System.Drawing.Point(15, 101);
            this.checkBoxRunStartup.Name = "checkBoxRunStartup";
            this.checkBoxRunStartup.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRunStartup.TabIndex = 6;
            this.checkBoxRunStartup.Text = "Run at Windows startup";
            this.checkBoxRunStartup.UseVisualStyleBackColor = true;
            this.checkBoxRunStartup.CheckedChanged += new System.EventHandler(this.checkBoxRunStartup_CheckedChanged);
            // 
            // settingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 140);
            this.Controls.Add(this.checkBoxRunStartup);
            this.Controls.Add(this.buttonDestChooser);
            this.Controls.Add(this.buttonSourceChoose);
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
        private System.Windows.Forms.Button buttonSourceChoose;
        private System.Windows.Forms.Button buttonDestChooser;
        private System.Windows.Forms.CheckBox checkBoxRunStartup;
    }
}