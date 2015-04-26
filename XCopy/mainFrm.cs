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

            if (File.Exists(lines[1] + "\\clone.txt")) //TODO: Add to Setting form
            {
                changeStatus("Clone Folders...");
                File.Delete(lines[1] + "\\clone.txt"); //TODO: Add exception
                directoryCopy(lines[0], lines[1], false);
            }

            if (File.Exists(lines[1] + "\\go.txt")) //TODO: Add to Setting form
            {
                changeStatus("Moving...");
                File.Delete(lines[1] + "\\go.txt"); //TODO: Add exception
                directoryCopy(lines[1], lines[0], true);
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
