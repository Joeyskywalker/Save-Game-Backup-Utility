namespace SaveGameBackupUtility
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
            this.labelSource = new System.Windows.Forms.Label();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxEmpireName = new System.Windows.Forms.TextBox();
            this.labelEmpireName = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelMP = new System.Windows.Forms.Label();
            this.labelRunning = new System.Windows.Forms.Label();
            this.buttonTestBackup = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(32, 44);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(76, 13);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source Folder:";
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(114, 41);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(630, 20);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.Text = "E:\\Users\\joey_\\Documents\\Paradox Interactive\\Stellaris\\save games\\spacecatholics_" +
    "-452913027\\ironman.sav";
            // 
            // textBoxEmpireName
            // 
            this.textBoxEmpireName.Location = new System.Drawing.Point(114, 78);
            this.textBoxEmpireName.Name = "textBoxEmpireName";
            this.textBoxEmpireName.Size = new System.Drawing.Size(472, 20);
            this.textBoxEmpireName.TabIndex = 3;
            this.textBoxEmpireName.Text = "spacecatholics";
            this.textBoxEmpireName.Visible = false;
            // 
            // labelEmpireName
            // 
            this.labelEmpireName.AutoSize = true;
            this.labelEmpireName.Location = new System.Drawing.Point(32, 81);
            this.labelEmpireName.Name = "labelEmpireName";
            this.labelEmpireName.Size = new System.Drawing.Size(73, 13);
            this.labelEmpireName.TabIndex = 2;
            this.labelEmpireName.Text = "Empire Name:";
            this.labelEmpireName.Visible = false;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(114, 128);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(630, 20);
            this.textBoxDestination.TabIndex = 5;
            this.textBoxDestination.Text = "E:\\Users\\joey_\\Documents\\StellarisBackups\\SpaceCatholic";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(32, 131);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(63, 13);
            this.labelDestination.TabIndex = 4;
            this.labelDestination.Text = "Destination:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(53, 198);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 42);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start Running";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(53, 272);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 42);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop Running";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(111, 101);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(317, 13);
            this.labelMP.TabIndex = 8;
            this.labelMP.Text = "Be sure to start your Empire Name with \"mp\" for multiplayer games";
            this.labelMP.Visible = false;
            // 
            // labelRunning
            // 
            this.labelRunning.AutoSize = true;
            this.labelRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunning.ForeColor = System.Drawing.Color.Green;
            this.labelRunning.Location = new System.Drawing.Point(425, 227);
            this.labelRunning.Name = "labelRunning";
            this.labelRunning.Size = new System.Drawing.Size(99, 25);
            this.labelRunning.TabIndex = 9;
            this.labelRunning.Text = "Running";
            this.labelRunning.Visible = false;
            // 
            // buttonTestBackup
            // 
            this.buttonTestBackup.Location = new System.Drawing.Point(53, 339);
            this.buttonTestBackup.Name = "buttonTestBackup";
            this.buttonTestBackup.Size = new System.Drawing.Size(123, 50);
            this.buttonTestBackup.TabIndex = 10;
            this.buttonTestBackup.Text = "Make a Backup Now";
            this.buttonTestBackup.UseVisualStyleBackColor = true;
            this.buttonTestBackup.Click += new System.EventHandler(this.buttonTestBackup_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(50, 428);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(312, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Save Game Backup Utility version 0.0.2 - Made by Joseph Slack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonTestBackup);
            this.Controls.Add(this.labelRunning);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.textBoxEmpireName);
            this.Controls.Add(this.labelEmpireName);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.labelSource);
            this.Name = "Form1";
            this.Text = "Save Game Backup Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxEmpireName;
        private System.Windows.Forms.Label labelEmpireName;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Label labelRunning;
        private System.Windows.Forms.Button buttonTestBackup;
        private System.Windows.Forms.Label labelTitle;
    }
}

