using Inventory.Forms;
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

            if (form == "Service")
            {
                label4.Text = "Enter your product reference number";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form == "Service")
            {
                var checkUp = Check_up.CheckCheckupExist(tbSerialNumber.Text);
                if (checkUp == null)
                {
                    var product = Product.SearchProduct(tbSerialNumber.Text);
                    if (product == null)
                    {
                        MessageBox.Show("No record found");
                        return;
                    }
                    MessageBox.Show("Hello Ms/Mr " + product.End_User + ", your product '" + product.Item + "' has not yet been checked up.");
                    return;
                }
                MainForm.LoadForm(new CheckupForm(tbSerialNumber.Text));
                this.Dispose();
            }
            else
            {
                var borrower = Borrower.GetBorrowerBySerial(tbSerialNumber.Text);
                if(borrower == null)
                {
                    MessageBox.Show("No record found");
                    return;
                }
                MainForm.LoadForm(new UpdateBorrowerForm(tbSerialNumber.Text));
                this.Dispose();
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
