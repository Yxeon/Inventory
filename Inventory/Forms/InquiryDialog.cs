using Inventory.Components;
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
    public partial class InquiryDialog : UserControl
    {
        public InquiryDialog()
        {
            InitializeComponent();
        }

        private void btnFileMaintenance_Click(object sender, EventArgs e)
        {
            SearchInquiryDialog inquire = new SearchInquiryDialog("Borrower");
            inquire.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchInquiryDialog inquire = new SearchInquiryDialog("Service");
            inquire.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new HomeForm());
        }
    }
}
