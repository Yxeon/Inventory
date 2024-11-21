using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class HomeForm : UserControl
    {
        static HomeForm Instance;

        public HomeForm()
        {
            InitializeComponent();

        }

        private void btnFileMaintenance_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new FileMaintenanceForm());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReportGenerator_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new ReportDialog());
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new InquiryDialog());
        }

        private void btnControlFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to reset your password?", "Control File", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("Reseting your password will remove the current password and recovery. Continue?", "Control File", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    Password reset = new Password();
                    reset.Delete();
                    MessageBox.Show("Password reset successfully!");
                    MainForm.LoadForm(new RegisterForm());
                }
            }
        }

        private void btnActionCodeModule_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new LoginForm());
        }
    }
}
