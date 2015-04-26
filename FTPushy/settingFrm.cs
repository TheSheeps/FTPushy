/*
 * 
 * 
 * Copyright ©  2015 The Sheeps - Armin Hasanpour and Kousha Nakhaei - The idea credit goes for Kousha Nakhaei *
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FTPushy
{
    public partial class settingFrm : Form
    {
        public static string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\config.ini";
        public settingFrm()
        {
            InitializeComponent();
        }

        private void settingFrm_Load(object sender, EventArgs e)
        {
            if (File.Exists(configPath))
            {
                string[] lines = File.ReadAllLines(configPath);
                toTxtBox.Text = lines[0];
                fromTxtBox.Text = lines[1];
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            string[] lines = { toTxtBox.Text, fromTxtBox.Text }; //TODO: Remove "\" from the end
            File.WriteAllLines(configPath, lines);
            base.OnFormClosing(e);
        }
    }
}
