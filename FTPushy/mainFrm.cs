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
        bool doDebug = false;

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

            if (File.Exists(sourceStr + "\\clone.txt")) //TODO: Add to Setting form
            {
                changeStatus("Clone Folders...");
                File.Delete(sourceStr + "\\clone.txt"); //TODO: Add exception
                directoryCopy(destStr, sourceStr, false);
            }

            if (File.Exists(sourceStr + "\\go.txt")) //TODO: Add to Setting form
            {
                changeStatus("Moving...");
                File.Delete(sourceStr + "\\go.txt"); //TODO: Add exception
                directoryCopy(sourceStr, destStr, true);
            }
            changeStatus("Idle");
        }

        private void changeStatus(string status)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                this.statusLbl.Text = "Status: " + status;
                if (doDebug) this.listBoxLog.Items.Add(status);
            }));
        }

        private void directoryCopy(string src, string dst, bool move)
        {
            isRuning = true;

            DirectoryInfo dir = new DirectoryInfo(src);
            DirectoryInfo[] dirs = dir.GetDirectories();

            bool doAction = true;
            if (move)
            {
                if (dst.ToLower().StartsWith(sourceStr)) doAction = false; //do not clone "source" if it is a subfolder
                changeStatus("[a]:" + dst + " - " + sourceStr);
            }
            else //clone folders
            {
                if (src.ToLower().StartsWith(sourceStr)) doAction = false; //do not clone "source" if it is a subfolder
                changeStatus("[b]:" + src);
            }

            //TODO: if (!dir.Exists) Exception

            if (!Directory.Exists(dst) && doAction)
                Directory.CreateDirectory(dst);

            if (move && doAction)
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
