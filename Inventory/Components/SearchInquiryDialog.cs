using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Components
{
    public partial class SearchInquiryDialog : Form
    {
        string form;
        public SearchInquiryDialog(string form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form == "Service")
            {
                var checkUp = Check_up.CheckCheckupExist(tbSerialNumber.Text);
                if (checkUp == null)
                {
                    MessageBox.Show("No record found!");
                    return;
                }
                MessageBox.Show(checkUp.ToString());
            }
            else
            {
                var borrower = Borrower.GetBorrowerBySerial(tbSerialNumber.Text);
                if(borrower == null)
                {
                    MessageBox.Show("No record found");
                    return;
                }
                MessageBox.Show(borrower.ToString());
            }
        }

        private void button1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void tbSerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
