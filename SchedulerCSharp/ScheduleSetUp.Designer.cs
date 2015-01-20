namespace SchedulerCSharp
{
    partial class ScheduleSetUp
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmeSetTime = new System.Windows.Forms.DateTimePicker();
            this.cbxMon = new System.Windows.Forms.CheckBox();
            this.cbxThurs = new System.Windows.Forms.CheckBox();
            this.cbxSat = new System.Windows.Forms.CheckBox();
            this.cbxTues = new System.Windows.Forms.CheckBox();
            this.cbxWed = new System.Windows.Forms.CheckBox();
            this.cbxFri = new System.Windows.Forms.CheckBox();
            this.cbxSun = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMonthDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(563, 134);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(125, 24);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(452, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // tmeSetTime
            // 
            this.tmeSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tmeSetTime.Location = new System.Drawing.Point(125, 58);
            this.tmeSetTime.Name = "tmeSetTime";
            this.tmeSetTime.ShowUpDown = true;
            this.tmeSetTime.Size = new System.Drawing.Size(103, 20);
            this.tmeSetTime.TabIndex = 3;
            this.tmeSetTime.Value = new System.DateTime(2014, 9, 3, 0, 0, 0, 0);
            // 
            // cbxMon
            // 
            this.cbxMon.AutoSize = true;
            this.cbxMon.Location = new System.Drawing.Point(125, 93);
            this.cbxMon.Name = "cbxMon";
            this.cbxMon.Size = new System.Drawing.Size(47, 17);
            this.cbxMon.TabIndex = 22;
            this.cbxMon.Text = "Mon";
            this.cbxMon.UseVisualStyleBackColor = true;
            // 
            // cbxThurs
            // 
            this.cbxThurs.AutoSize = true;
            this.cbxThurs.Location = new System.Drawing.Point(295, 93);
            this.cbxThurs.Name = "cbxThurs";
            this.cbxThurs.Size = new System.Drawing.Size(53, 17);
            this.cbxThurs.TabIndex = 19;
            this.cbxThurs.Text = "Thurs";
            this.cbxThurs.UseVisualStyleBackColor = true;
            // 
            // cbxSat
            // 
            this.cbxSat.AutoSize = true;
            this.cbxSat.Location = new System.Drawing.Point(401, 93);
            this.cbxSat.Name = "cbxSat";
            this.cbxSat.Size = new System.Drawing.Size(42, 17);
            this.cbxSat.TabIndex = 17;
            this.cbxSat.Text = "Sat";
            this.cbxSat.UseVisualStyleBackColor = true;
            // 
            // cbxTues
            // 
            this.cbxTues.AutoSize = true;
            this.cbxTues.Location = new System.Drawing.Point(180, 93);
            this.cbxTues.Name = "cbxTues";
            this.cbxTues.Size = new System.Drawing.Size(50, 17);
            this.cbxTues.TabIndex = 21;
            this.cbxTues.Text = "Tues";
            this.cbxTues.UseVisualStyleBackColor = true;
            // 
            // cbxWed
            // 
            this.cbxWed.AutoSize = true;
            this.cbxWed.Location = new System.Drawing.Point(238, 93);
            this.cbxWed.Name = "cbxWed";
            this.cbxWed.Size = new System.Drawing.Size(49, 17);
            this.cbxWed.TabIndex = 20;
            this.cbxWed.Text = "Wed";
            this.cbxWed.UseVisualStyleBackColor = true;
            // 
            // cbxFri
            // 
            this.cbxFri.AutoSize = true;
            this.cbxFri.Location = new System.Drawing.Point(356, 93);
            this.cbxFri.Name = "cbxFri";
            this.cbxFri.Size = new System.Drawing.Size(37, 17);
            this.cbxFri.TabIndex = 18;
            this.cbxFri.Text = "Fri";
            this.cbxFri.UseVisualStyleBackColor = true;
            // 
            // cbxSun
            // 
            this.cbxSun.AutoSize = true;
            this.cbxSun.Location = new System.Drawing.Point(451, 93);
            this.cbxSun.Name = "cbxSun";
            this.cbxSun.Size = new System.Drawing.Size(45, 17);
            this.cbxSun.TabIndex = 16;
            this.cbxSun.Text = "Sun";
            this.cbxSun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Weekly";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "or";
            // 
            // cbxMonthDay
            // 
            this.cbxMonthDay.FormattingEnabled = true;
            this.cbxMonthDay.Items.AddRange(new object[] {
            "Month Date",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxMonthDay.Location = new System.Drawing.Point(549, 89);
            this.cbxMonthDay.Name = "cbxMonthDay";
            this.cbxMonthDay.Size = new System.Drawing.Size(105, 21);
            this.cbxMonthDay.TabIndex = 26;
            this.cbxMonthDay.Text = "Month Date";
            this.cbxMonthDay.SelectedIndexChanged += new System.EventHandler(this.cbxMonthDay_SelectedIndexChanged);
            // 
            // ScheduleSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 173);
            this.Controls.Add(this.cbxMonthDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSun);
            this.Controls.Add(this.cbxFri);
            this.Controls.Add(this.cbxWed);
            this.Controls.Add(this.cbxTues);
            this.Controls.Add(this.cbxSat);
            this.Controls.Add(this.cbxThurs);
            this.Controls.Add(this.cbxMon);
            this.Controls.Add(this.tmeSetTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "ScheduleSetUp";
            this.Text = "ScheduleSetUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tmeSetTime;
        private System.Windows.Forms.CheckBox cbxMon;
        private System.Windows.Forms.CheckBox cbxThurs;
        private System.Windows.Forms.CheckBox cbxSat;
        private System.Windows.Forms.CheckBox cbxTues;
        private System.Windows.Forms.CheckBox cbxWed;
        private System.Windows.Forms.CheckBox cbxFri;
        private System.Windows.Forms.CheckBox cbxSun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMonthDay;
    }
}