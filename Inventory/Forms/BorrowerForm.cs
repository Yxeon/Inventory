using Inventory.Components;
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
    public partial class BorrowerForm : UserControl
    {
        List<Borrower> borrowers;
        List<Validator> validators = new List<Validator>();
        public BorrowerForm()
        {
            InitializeComponent();

            validators.Add(new Validator(tbSerialNumber, lblSerialNum, "Reference no.", "required|min:5|unique:tblBorrowers,Serial_No"));
            validators.Add(new Validator(tbItem, lblItem, "Item", "required|min:3"));
            validators.Add(new Validator(tbLastname, lblLastname, "", "required|min:2"));
            validators.Add(new Validator(tbFirstname, lblFirstname, "", "required|min:2"));
            validators.Add(new Validator(tbMiddlename, lblMiddlename, "", "required|min:1"));
            validators.Add(new Validator(tbDepartment, lblDepartment, "Department", "required|min:1"));

            RefreshGrid();
        }

        void RefreshGrid()
        {
            borrowers = Borrower.GetAllBorrowers();
            dgvReport.Rows.Clear();
            borrowers.ForEach(b =>
            {
                dgvReport.Rows.Add(
                    b.Serial_No,
                    b.Item,
                    b.Lastname + ", " + b.Firstname + " " + b.Middlename,
                    b.Department,
                    b.Date_Borrowed,
                    b.Status,
                    b.Remarks,
                    b.Head,
                    b.Lab_Assistant
                    );
            });
            if (borrowers.Count == 0) dgvReport.Rows.Add("No Record Found");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCheckup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (validators.Count((validator) => validator.IsValid()) == validators.Count)
            {
                var borrowerModel = new Borrower()
                {
                    Serial_No = tbSerialNumber.Text,
                    Lastname = tbLastname.Text,
                    Firstname = tbFirstname.Text,
                    Middlename = tbMiddlename.Text,
                    Department = tbDepartment.Text,
                    Item = tbItem.Text,
                    Status = "Pending",
                    Remarks = " ",
                    Head = "Unassigned",
                    Lab_Assistant = "Unassigned"
                };
                borrowerModel.Save();
                RefreshGrid();
                MessageBox.Show("Borrower successfully added!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new FileMaintenanceForm());
        }

        private void dgvReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (borrowers.Count == 0) return;
                Borrower borrower = borrowers[e.RowIndex];
                if (borrower.Status != "Pending")
                {
                    DialogResult result = MessageBox.Show("This borrower has already been " + borrower.Status + ". Are you sure you want to proceed to update borrower?", "Borrower", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new UpdateBorrowerForm(borrower));
                    }
                }
                else
                {
                    MainForm.LoadForm(new UpdateBorrowerForm(borrower));
                }
            }
        }
    }
}
