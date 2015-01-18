using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Access = Microsoft.Office.Interop.Access;
using System.IO;


namespace SchedulerCSharp
{
    public partial class frmScheduler : Form
    {
        private void frmScheduler_Load(object sender, EventArgs e) { }
        public frmScheduler()
        {
            //This is the method that loads the scheduler form
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);           // Every time timer ticks, timer_Tick will be called
            timer1.Interval = 1000;                                 // Timer will tick every second
            timer1.Enabled = true;                                  // Enable the timer
            timer1.Start();                                         // Start the timer
            dtpSetTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
        public void OpenAFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Macro Files (*.xlsm)|*.xlsm| Access Database Files (*.mdb)|*.mdb"
                 + "| Access Database Files (*.accdb)|*.accdb";
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK) // Test result.
            {
                txtFileName.Text = dialog.FileName.ToString();
            }
            return;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstBox.Items.Remove(lstBox.SelectedItem);   
            addToQueue();
        }
        protected override void OnResize(EventArgs e)
        {
            try
            {
                base.OnResize(e);
                //Determines whether the cursor is in the taskbar
                bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
                if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
                {
                    this.ShowInTaskbar = false;
                    notifyIcon.Visible = true;
                    this.Hide();
                }
                else if (FormWindowState.Normal == this.WindowState)
                {
                    notifyIcon.Visible = false;
                    this.ShowInTaskbar = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
        public void OpenExcelFile()
        {
            if (lblOnDeck.Text == "")
            {
                return;
            }
            try
            {
                if (TextManipulation.RightOf(lblOnDeck.Text, ".") == "xlsm")
                {
                    string mySheet = lblOnDeck.Text;
                    var excelApp = new Excel.Application();
                    excelApp.Visible = true;
                    Excel.Workbooks books = excelApp.Workbooks;
                    Excel.Workbook sheet = books.Open(mySheet);
                }
                else if (TextManipulation.RightOf(lblOnDeck.Text, ".") == "mdb" ||
                    TextManipulation.RightOf(lblOnDeck.Text, ".") == "accdb")
                {
                    string mydb = lblOnDeck.Text;
                    var accessApp = new Access.Application(lblOnDeck.Text);
                    accessApp.Visible = true;
                    accessApp.OpenCurrentDatabase(lblOnDeck.Text);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            string mySetTime = lblSetTime.Text.Replace(System.Environment.NewLine, "");
            if (lblCurrentTime.Text == mySetTime)
            {
                TextManipulation.writeFile("Scheduler.txt", DateTime.Now.ToString("M/d/yyyy") + " " + lblOnDeck.Text + "|" + lblSetTime.Text);
                OpenExcelFile();
                addToQueue();
            }
            else if (lblCurrentTime.Text == "12:00:00 AM")
            {
                addToQueue();
            }
        }
        public void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenAFile();
        }
        private void btnGetLast_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Scheduler.txt");
                DateTime aDate = new DateTime();
                string line = "";
                DateTime MyDate = TextManipulation.getLastDate("Scheduler.txt", " ");
                Convert.ToDateTime(MyDate);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        aDate = Convert.ToDateTime(TextManipulation.LeftOf(line, " "));
                        if (aDate == MyDate)
                        {
                            lstBox.Items.Add(line.Substring(TextManipulation.Search(line, " ", 1, false),
                                line.Length - TextManipulation.Search(line, " ", 1, false)));
                        }
                    }
                }
                addToQueue();
            }
            catch (Exception x)
            {
                MessageBox.Show("This feature requires that a task has been logged prior. "
                    + x.Message);
            }
        }
        private void btnViewLog_Click(object sender, EventArgs e)
        {
            frmLog flog = new frmLog();
            flog.ShowDialog();
        }
        private void frmScheduler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lblOnDeck.Text != "" && lblSetTime.Text != "Set Time")
            {
                DialogResult dialog = MessageBox.Show("Are you sure you would like to exit the scheduler?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else if (dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnAddtoList_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "" || dtpSetTime.Text == "")
            {
                return;
            }
            else
            {
                string weekString = "Mon,Tues,Wed,Thurs,Fri,Sat,Sun";
                lstBox.Items.Add(txtFileName.Text + "|" + dtpSetTime.Text + "|" + weekString);
                txtFileName.Text = "";
                lblCurrentTime.Font = new Font(lblCurrentTime.Font, FontStyle.Bold);
                ActiveForm.Text = "Scheduler [Timer Set]";
                addToQueue();
            }
        }
        private void addToQueue()
        { //this routine changes the who's on deck based on the algorithm looking for which file is next
            if (lstBox.Items.Count != 0)
            {
                string[] todayList = todayQualifiers();

                if (todayList.Length > 0)
                {
                    DateTime[] myTimeArr = convertToTimes(todayList);
                    int nextIndex = nextLowestTime(myTimeArr);
                    lblOnDeck.Text = TextManipulation.LeftOf(todayList[nextIndex].ToString(), "|");
                    int startIndex = TextManipulation.Search(todayList[nextIndex].ToString(), "|", 1);
                    int endIndex = TextManipulation.Search(todayList[nextIndex].ToString(), "|", 2) - startIndex;
                    lblSetTime.Text = todayList[nextIndex].ToString().Substring(startIndex, endIndex - 1);
                    ReOrder();
                }
            }
        }
        private void ReOrder()
        {
            for (int i = 0; i < lstBox.Items.Count; i++ )
            {
                string item = lstBox.Items[i].ToString();
                string indicator = item.Substring(0, TextManipulation.Search(item, "|", 2) - 1);
                if (indicator == lblOnDeck.Text + "|" + lblSetTime.Text)
                {
                    lstBox.Items.RemoveAt(i);
                    lstBox.Items.Insert(0, item);
                }

                i++;
            }
        }
        private string[] todayQualifiers()
        {   
            ArrayList rList = new ArrayList();
            string weekDay = getToday();
            string monthDay = DateTime.Now.Day.ToString();
            foreach (string line in lstBox.Items)
            {
                string mDays = TextManipulation.RightOf(line, "|", 1);
                string[] cDays = mDays.Split(new string[] { "," }, StringSplitOptions.None);
                foreach (string d in cDays)
                {
                    if (d == weekDay || d == monthDay)
                    {
                        rList.Add(line);
                        break;
                    }
                }
            }
            string[] meArray = rList.ToArray(typeof(string)) as string[];
            return meArray;
        }   
        private string getToday()
        {
            string fullDay = DateTime.Today.DayOfWeek.ToString();
            string abrvDay = "";
            switch (fullDay)
            {
                case "Monday":
                    abrvDay = "Mon";
                    break;
                case "Tuesday":
                    abrvDay = "Tues";
                    break;
                case "Wednesday":
                    abrvDay = "Wed";
                    break;
                case "Thursday":
                    abrvDay = "Thurs";
                    break;
                case "Friday":
                    abrvDay = "Fri";
                    break;
                case "Saturday":
                    abrvDay = "Sat";
                    break;
                case "Sunday":
                    abrvDay = "Sun";
                    break;
            }
            return abrvDay;
        }
        private int nextLowestTime(DateTime[] myTimeArr)
        {   
            int i =0;
            int currentInt = 0;
            DateTime currentTime;
            int currentTimeDiff = 0;
            DateTime now1 = DateTime.Now;
            foreach (DateTime dt in myTimeArr)
            {
                int timeDiff = Convert.ToInt32(dt.Subtract(now1).TotalMinutes);
               if (i == 0)
               {
                   currentInt = i;
                   currentTime = dt;
                   currentTimeDiff = timeDiff;
               }
               else if (currentTimeDiff > 0 && timeDiff > 0 && timeDiff < currentTimeDiff)
               {
                   currentInt = i;
                   currentTime = dt;
                   currentTimeDiff = timeDiff;
               }
               else if (currentTimeDiff < 0 && timeDiff > 0)
               {
                   currentInt = i;
                   currentTime = dt;
                   currentTimeDiff = timeDiff;
               }
               else if (currentTimeDiff < 0 && timeDiff < currentTimeDiff)
               {
                   currentInt = i;
                   currentTime = dt;
                   currentTimeDiff = timeDiff;
               }
               i++;
            }
            return currentInt;
        }
        private DateTime[] convertToTimes(string[] todayList)
        {
            int i = 0;
            int itemNum = todayList.Count();
            DateTime[] myArr = new DateTime[itemNum];
            foreach (string item in todayList)
           {
               int startIndex = TextManipulation.Search(item, "|", 1);
               int endIndex = TextManipulation.Search(item, "|", 2) - startIndex;
               string myTime = item.Substring(startIndex, endIndex - 1);
               myArr[i] = Convert.ToDateTime(myTime);
               i++;
           }
           return myArr;
        }
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != "")
            {
                ScheduleSetUp SSU = new ScheduleSetUp(txtFileName.Text);
                SSU.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a file to include in the scheduler");
            }
        }
        private void frmScheduler_Activated(object sender, EventArgs e)
        {
            if (DataStore.FileData != "" && DataStore.FileData != null)
            {
                lstBox.Items.Add(DataStore.FileData);
                DataStore.FileData = "";
                txtFileName.Text = "";
                dtpSetTime.Text = "";
                addToQueue();
            }
        }
    }
    public static class TextManipulation
    {
        public static void writeFile(string FileName, string MyLine)
        {
            StreamWriter sw = new StreamWriter(FileName, true);
            sw.WriteLine(MyLine.Replace(System.Environment.NewLine, ""));
            sw.Close();
        }
        public static string readFile(string FileName)
        {
            StreamReader sr = new StreamReader(FileName);
            string aString = sr.ReadToEnd();
            sr.Close();
            return aString;
        }
        public static string LeftOf(string yourString, string yourMarker)
        {
            //method or function that pulls everything left of a unique Marker
            int anum = 0;
            int len = yourString.Length;
            int len2 = yourMarker.Length;
            string newString = "";
            do
            {
                string temp = yourString.Substring(anum, len2);
                if (temp == yourMarker)
                {
                    return newString;
                }
                newString = newString + temp;
                anum += 1;
            } while (anum < len);
            return "";
        }
        public static string RightOf(string yourString, string yourMarker, int inst = 1)
        {
            //method or function that pulls everything right of a unique Marker
            int myIndex = 0;
            int len = yourString.Length;
            int len2 = yourMarker.Length;
            int cnt = 0;
            for (int i = (len - len2); i > 0; i--)
            {
                cnt = cnt + 1;
                string temp = yourString.Substring(i, len2);
                if (temp == yourMarker)
                {
                    myIndex++;
                    if (myIndex == inst)
                    {
                        string newString = yourString.Substring(i + len2, cnt - 1);
                        return newString;
                    }
                }
            }
            return "";
        }
        public static DateTime getLastDate(string TxtFile, string Marker)
        {
            StreamReader sr = new StreamReader(TxtFile);
            DateTime MyDate = new DateTime();
            int cnt = 0;
            string line = "";
            while (line != null)
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    MyDate = Convert.ToDateTime(LeftOf(line, " "));
                    cnt += 1;
                }
            }
            return MyDate;
        }
        public static int Search(string yourString, string yourMarker, int yourInst = 1, bool yourCapPref = true)
        {
            //returns the placement of a string in another string
            int num = 1;
            int ginst = 1;
            int mlen = yourMarker.Length;
            int slen = yourString.Length;
            string tString = "";

            try
            {
                if (yourCapPref == false)
                {
                    yourString = yourString.ToLower();
                    yourMarker = yourMarker.ToLower();
                }

                while (num < slen)
                {
                    tString = yourString.Substring(num, mlen);

                    if (tString == yourMarker && ginst == yourInst)
                    {
                        return num + 1;
                    }
                    else if (tString == yourMarker && yourInst != ginst)
                    {
                        ginst += 1;
                        num += 1;
                    }
                    else
                    {
                        num += 1;
                    }
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}

