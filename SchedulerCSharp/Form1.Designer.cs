namespace SchedulerCSharp
{
    partial class frmScheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduler));
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnViewLog = new System.Windows.Forms.Button();
            this.btnAddtoList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblOnDeck = new System.Windows.Forms.Label();
            this.dtpSetTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(15, 60);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(114, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose File:";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(154, 62);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(417, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentTime.Location = new System.Drawing.Point(664, 25);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(126, 20);
            this.lblCurrentTime.TabIndex = 3;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // lblSetTime
            // 
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetTime.Location = new System.Drawing.Point(701, 138);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(75, 17);
            this.lblSetTime.TabIndex = 4;
            this.lblSetTime.Text = "Set Time";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Scheduler";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(15, 22);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(114, 23);
            this.btnViewLog.TabIndex = 8;
            this.btnViewLog.Text = "View Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnAddtoList
            // 
            this.btnAddtoList.Location = new System.Drawing.Point(81, 100);
            this.btnAddtoList.Name = "btnAddtoList";
            this.btnAddtoList.Size = new System.Drawing.Size(48, 23);
            this.btnAddtoList.TabIndex = 10;
            this.btnAddtoList.Text = "Add";
            this.btnAddtoList.UseVisualStyleBackColor = true;
            this.btnAddtoList.Click += new System.EventHandler(this.btnAddtoList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Del.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQueue.Location = new System.Drawing.Point(12, 138);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(115, 17);
            this.lblQueue.TabIndex = 12;
            this.lblQueue.Text = "Current Queue:";
            // 
            // lblOnDeck
            // 
            this.lblOnDeck.AutoSize = true;
            this.lblOnDeck.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnDeck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOnDeck.Location = new System.Drawing.Point(133, 138);
            this.lblOnDeck.Name = "lblOnDeck";
            this.lblOnDeck.Size = new System.Drawing.Size(70, 17);
            this.lblOnDeck.TabIndex = 13;
            this.lblOnDeck.Text = "On Deck";
            // 
            // dtpSetTime
            // 
            this.dtpSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSetTime.Location = new System.Drawing.Point(154, 102);
            this.dtpSetTime.Name = "dtpSetTime";
            this.dtpSetTime.ShowUpDown = true;
            this.dtpSetTime.Size = new System.Drawing.Size(103, 20);
            this.dtpSetTime.TabIndex = 14;
            this.dtpSetTime.Value = new System.DateTime(2015, 1, 20, 0, 0, 0, 0);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(275, 100);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(89, 23);
            this.btnAddSchedule.TabIndex = 15;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(15, 157);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(775, 264);
            this.lstBox.TabIndex = 16;
            // 
            // frmScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(806, 433);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.dtpSetTime);
            this.Controls.Add(this.lblOnDeck);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddtoList);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScheduler";
            this.Opacity = 0.85D;
            this.Text = "Scheduler";
            this.Activated += new System.EventHandler(this.frmScheduler_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScheduler_FormClosing);
            this.Load += new System.EventHandler(this.frmScheduler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Button btnAddtoList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblOnDeck;
        private System.Windows.Forms.DateTimePicker dtpSetTime;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.ListBox lstBox;
    }
}

