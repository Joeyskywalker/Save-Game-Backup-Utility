using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveGameBackupUtility
{
    public partial class Form1 : Form
    {
        //All the timer code from here:
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/456811b7-8a18-4e3d-bd31-afe1537c6a88/c-adding-text-every-five-minutes?forum=csharpgeneral
        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer(); //This is to time the saves
        System.Windows.Forms.Timer _save_timer = new System.Windows.Forms.Timer(); //This is to stop the manual save button from being spammed

        public Form1()
        {
            InitializeComponent();

        }

        void _timer_Tick(object sender, EventArgs e)
        {
            makeBackup();
        }

        string sourceFolder;
        string empireName;
        string destinationFolder;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sourceFolder = @textBoxSource.Text;
            empireName = textBoxEmpireName.Text;
            destinationFolder = @textBoxDestination.Text;
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            textBoxSource.Enabled = false;
            textBoxEmpireName.Enabled = false;
            textBoxDestination.Enabled = false;
            labelRunning.Visible = true;
            buttonTestBackup.Enabled = true;

            _timer.Interval = 600000; // 600,000 ten minutes
            _timer.Tick += _timer_Tick;
            _timer.Start();

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            sourceFolder = "";
            empireName = "";
            destinationFolder = "";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            textBoxSource.Enabled = true;
            textBoxEmpireName.Enabled = true;
            textBoxDestination.Enabled = true;
            labelRunning.Visible = false;
            buttonTestBackup.Enabled = false;
            _timer.Stop();

        }

        private void makeBackup()
        {
            string time = DateTime.Now.ToString("yyyymmddhhmm");

            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders
            //System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");

            
                string fileName = destinationFolder + time;
                System.IO.File.Copy(sourceFolder, fileName, false);


            //This would allow any file name to be backedup, impliment later

            //if (System.IO.Directory.Exists(sourceFolder))
            //{

            //string[] files = System.IO.Directory.GetFiles(sourceFolder);
            //string fileName;
            //string destFile;

            //// Copy the files and overwrite destination files if they already exist.
            //foreach (string s in files)
            //{
            //    // Use static Path methods to extract only the file name from the path.
            //    fileName = System.IO.Path.GetFileName(s);
            //    destFile = System.IO.Path.Combine(destinationFolder + time, fileName);
            //    System.IO.File.Copy(s, destFile, true);
            //}
            //}
        }

        private void buttonTestBackup_Click(object sender, EventArgs e)
        {
            //backup then disable the button to stop spamming
            makeBackup();
            buttonTestBackup.Enabled = false;
            _save_timer.Interval = 60000; // 60,000 one minute
            _save_timer.Tick += _save_timer_Tick;
            _save_timer.Start();
        }

        void _save_timer_Tick(object sender, EventArgs e)
        {
            buttonTestBackup.Enabled = true;
            _save_timer.Stop();
        }

        //private void timerToSave()
        //{
        //    //https://stackoverflow.com/questions/13019433/calling-a-method-every-x-minutes

        //    var timer = new System.Threading.Timer(
        //    e => makeBackup(),
        //    null,
        //    TimeSpan.Zero,
        //    TimeSpan.FromMinutes(5));

        //}
    }
}
