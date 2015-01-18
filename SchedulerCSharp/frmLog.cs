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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            try
            {
                txtLog.Text = TextManipulation.readFile("Scheduler.txt");
            }
            catch (Exception)
            { 
                MessageBox.Show("You have not scheduled any tasks");
            }
        }
    }
}
