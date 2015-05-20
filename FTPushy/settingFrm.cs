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
using Microsoft.Win32;

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
                fromTxtBox.Text = lines[1];
                toTxtBox.Text = lines[0];

                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                checkBoxRunStartup.Checked = !(reg.GetValue("FTPushy") == null);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            /* It may be a good idea to format this settings in a more proper way. Orders are confusing, reversed in compare to logic! */
            string[] lines = { toTxtBox.Text, fromTxtBox.Text }; //TODO: Remove "\" from the end
            File.WriteAllLines(configPath, lines);
            base.OnFormClosing(e);
        }

        private void toTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSourceChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0) fromTxtBox.Text = fbd.SelectedPath;
        }

        private void buttonDestChooser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath.Length > 0) toTxtBox.Text = fbd.SelectedPath;
        }

        private void checkBoxRunStartup_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (checkBoxRunStartup.Checked)
                reg.SetValue("FTPushy", Application.ExecutablePath.ToString());
            else
                reg.DeleteValue("FTPushy", false);            

        }
    }
}
