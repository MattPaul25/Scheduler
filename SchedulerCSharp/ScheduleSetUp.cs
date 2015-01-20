using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerCSharp
{
    public partial class ScheduleSetUp : Form
    {
        public ScheduleSetUp()
        {
            InitializeComponent();
        }
        public ScheduleSetUp(string FileName, string currentTime)
        {
            InitializeComponent();
            txtFilePath.Text = FileName;
            tmeSetTime.Text = currentTime;
            tmeSetTime.Format = DateTimePickerFormat.Custom;
            tmeSetTime.CustomFormat = "h:mm tt";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbxMonthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMonthDay.SelectedIndex != 0)
            {
                foreach (var checkBox in this.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = false;
                }
            }
            if (cbxMonthDay.SelectedIndex == 0)
                foreach (var checkBox in this.Controls.OfType<CheckBox>())
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool monthDate = false;

            string mySched = txtFilePath.Text + "|" + tmeSetTime.Text;
            string days = "";
            foreach (var checkBox in this.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    days = days + checkBox.Text + ",";
                }
            }
            if (days == "" && cbxMonthDay.Text != "Month Date") 
            { 
                days = cbxMonthDay.Text;
                monthDate = true;
            }
            else if (days == "" && cbxMonthDay.Text == "Month Date") 
            {
                days = "Mon,Tues,Wed,Thurs,Fri,Sat,Sun"; 
            }
            else 
            { 
                days = days.Substring(0, days.Length - 1); 
            }
            days = dayReorder(days);
            mySched = mySched + "|" + days;
            DataStore.FileData = mySched;
            DataStore.isNum = monthDate;
            this.Close();
        }

        private string dayReorder(string days)
        {
            //puts the days in correct order
            string[] cDayArr = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            string[] splitDayArr = days.Split(',');
            string nDays = "";
            foreach (string d in cDayArr)
            {
                foreach (string y in splitDayArr)
                {
                    if (d == y) 
                    {
                        nDays = nDays + "," + y;
                        break;
                    }
                }
            }
            nDays = nDays.Substring(1, nDays.Length - 1); 
            return nDays;
        }
    }
}
