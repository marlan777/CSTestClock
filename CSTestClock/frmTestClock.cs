using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTestClock
{
    public partial class frmCSClock : Form
    {
        public frmCSClock()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*string d = DateTime.Now.Date.ToShortDateString(); */
            lblDate.Text = DateTime.Now.Date.ToShortDateString();
            lblTime.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void frmCSClock_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            /*timer1.Enabled = true; */
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text.Equals("START"))
            {
                timer1.Enabled = true;
                timer1.Start();
                btnStartStop.Text = "STOP";
                btnExit.Enabled = false;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnStartStop.Text = "START";
                btnExit.Enabled = true;
            }
        }
    }
}
