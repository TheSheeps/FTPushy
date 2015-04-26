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
    public partial class mainFrm : Form
    {
        bool isRuning = false;
        string sourceStr = "";
        string destStr = "";

        private static System.Timers.Timer chkTimer = new System.Timers.Timer(10000); //TODO: Add to Setting form
        public mainFrm()
        {
            InitializeComponent();
            if (File.Exists(settingFrm.configPath))
            {
                chkTimer.Elapsed += onTimedEvent;
                chkTimer.Enabled = true;
            }
        }

        private void onTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isRuning)
                return;

            string[] lines = File.ReadAllLines(settingFrm.configPath);
            sourceStr = lines[1].ToLower(); //toLower() to make it standard for comparisions
            destStr = lines[0].ToLower();

            if (File.Exists(destStr + "\\clone.txt")) //TODO: Add to Setting form
            {
                changeStatus("Clone Folders...");
                File.Delete(destStr + "\\clone.txt"); //TODO: Add exception
                directoryCopy(sourceStr, destStr, false);
            }

            if (File.Exists(destStr + "\\go.txt")) //TODO: Add to Setting form
            {
                changeStatus("Moving...");
                File.Delete(destStr + "\\go.txt"); //TODO: Add exception
                directoryCopy(destStr, sourceStr, true);
            }
            changeStatus("Idle");
        }

        private void changeStatus(string status)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                this.statusLbl.Text = "Status: " + status;
            }));
        }

        private void directoryCopy(string src, string dst, bool move)
        {
            isRuning = true;

            DirectoryInfo dir = new DirectoryInfo(src);
            DirectoryInfo[] dirs = dir.GetDirectories();

            //TODO: if (!dir.Exists) Exception

            if (!Directory.Exists(dst))
                Directory.CreateDirectory(dst);

            if (move)
            {
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(dst, file.Name);

                    if (File.Exists(temppath)) 
                        File.Delete(temppath);

                    file.MoveTo(temppath);
                }
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(dst, subdir.Name);
                directoryCopy(subdir.FullName, temppath, move);
            }

            isRuning = false;
        }

        private void settingLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingFrm settingFrm = new settingFrm();
            settingFrm.ShowDialog();
        }
    }
}
