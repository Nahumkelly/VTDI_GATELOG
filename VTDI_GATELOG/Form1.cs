using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_GATELOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.MdiParent = this;
            login.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Click");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Click");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List Click");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Out and In Click");
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Report Click");
        }

        private void userLagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Lags Report Click");
        }
    }
}
