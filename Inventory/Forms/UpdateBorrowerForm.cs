using Inventory.Components;
using Inventory.Error_Handler;
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

namespace Inventory.Forms
{
    public partial class UpdateBorrowerForm : UserControl
    {
        Borrower borrower;
        List<Validator> validators = new List<Validator>();
        public UpdateBorrowerForm(Borrower _borrower)
        {
            InitializeComponent();
            this.borrower = _borrower;

            validators.Add(new Validator(tbItemNumber, lblItem, "Item", "required|min:3"));
            validators.Add(new Validator(tbLastname, lblLast, "Lastname", "required|min:2"));
            validators.Add(new Validator(tbFirstname, lblFirst, "Firstname", "required|min:2"));
            validators.Add(new Validator(tbMiddlename, lblMiddle, "Middlename", "required|min:1"));
            validators.Add(new Validator(tbDepartment, lblDepartment, "Department", "required|min:1"));
            validators.Add(new Validator(tbHead, lblHead, "Head", "required|min:1"));
            validators.Add(new Validator(tbLabAssistant, lblLabAssistant, "Department", "required|min:1"));
            validators.Add(new Validator(tbRemarks, lblRemark, "Department", "required|min:1"));

            AutoFill();
        }

        public UpdateBorrowerForm(string _borrower)
        {
            InitializeComponent();
            this.borrower = Borrower.GetBorrowerBySerial(_borrower);

            validators.Add(new Validator(tbItemNumber, lblItem, "Item", "required|min:3"));
            validators.Add(new Validator(tbLastname, lblLast, "Lastname", "required|min:2"));
            validators.Add(new Validator(tbFirstname, lblFirst, "Firstname", "required|min:2"));
            validators.Add(new Validator(tbMiddlename, lblMiddle, "Middlename", "required|min:1"));
            validators.Add(new Validator(tbDepartment, lblDepartment, "Department", "required|min:1"));
            validators.Add(new Validator(tbHead, lblHead, "Head", "required|min:1"));
            validators.Add(new Validator(tbLabAssistant, lblLabAssistant, "Department", "required|min:1"));
            validators.Add(new Validator(tbRemarks, lblRemark, "Department", "required|min:1"));

            AutoFillInquiry();
        }

        void AutoFill()
        {
            if (borrower.Status != "Pending")
            {
                tbHead.Text = borrower.Head;
                tbLabAssistant.Text = borrower.Lab_Assistant;
                tbRemarks.Text = borrower.Remarks;
            }
            tbSerialNumber.Text = borrower.Serial_No;
            tbItemNumber.Text = borrower.Item;
            tbLastname.Text = borrower.Lastname;
            tbFirstname.Text = borrower.Firstname;
            tbMiddlename.Text = borrower.Middlename;
            tbDepartment.Text = borrower.Department;
        }

        void AutoFillInquiry()
        {
            lblTitle.Text = "BORROWER INQUIRY";
            lblStatus.Text = "STATUS: " + borrower.Status;
            if (borrower.Status != "Pending")
            {
                tbHead.Text = borrower.Head;
                tbLabAssistant.Text = borrower.Lab_Assistant;
                tbRemarks.Text = borrower.Remarks;
            }
            tbHead.Text = "Unassigned";
            tbLabAssistant.Text = "Unassigned";
            
            tbSerialNumber.Text = borrower.Serial_No;
            tbItemNumber.Text = borrower.Item;
            tbLastname.Text = borrower.Lastname;
            tbFirstname.Text = borrower.Firstname;
            tbMiddlename.Text = borrower.Middlename;
            tbDepartment.Text = borrower.Department;

            tbHead.Enabled = false;
            tbLabAssistant.Enabled = false;
            tbRemarks.Enabled = false;
            
            btnApprove.Visible = false;
            btnBack.Visible = false;
            btnDecline.Visible = false;
            btnEdit.Visible = false;

            btnDone.Visible = true;
            lblStatus.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnSave.Visible = true;
            tbSerialNumber.ReadOnly = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new BorrowerForm());
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    DialogResult result = MessageBox.Show("Are you sure to approve this borrower?", "Approve", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        borrower.Status = "Approved";
                        borrower.Head = tbHead.Text;
                        borrower.Lab_Assistant = tbLabAssistant.Text;
                        borrower.Remarks = tbRemarks.Text;

                        borrower.Update();
                        MessageBox.Show("Borrower updated successfully!");
                        MainForm.LoadForm(new BorrowerForm());
                    }
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    DialogResult result = MessageBox.Show("Are you sure to decline this borrower?", "Decline", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        borrower.Status = "Declined";
                        borrower.Head = tbHead.Text;
                        borrower.Lab_Assistant = tbLabAssistant.Text;
                        borrower.Remarks = tbRemarks.Text;

                        borrower.Update();
                        MessageBox.Show("Borrower updated successfully!");
                        MainForm.LoadForm(new BorrowerForm());
                    }
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    borrower.Item = tbItemNumber.Text;
                    borrower.Lastname = tbLastname.Text;
                    borrower.Firstname = tbFirstname.Text;
                    borrower.Middlename = tbMiddlename.Text;
                    borrower.Department = tbDepartment.Text;

                    borrower.Update();
                    MessageBox.Show("Borrower updated successfully!");
                    btnSave.Visible = false;
                    groupBox1.Enabled = false;
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new InquiryDialog());
        }
    }
}
