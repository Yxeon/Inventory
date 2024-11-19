using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
