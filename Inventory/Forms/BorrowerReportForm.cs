using ClosedXML.Excel;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class BorrowerReportForm : UserControl
    {
        List<Borrower> borrowers;
        public BorrowerReportForm()
        {
            InitializeComponent();
            DateAndTimeLabel();
            timer1.Start();

            dtpStart.MaxDate = DateTime.Now;
            dtpEnd.MinDate = DateTime.Now;

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
        void RefreshGridByDate()
        {
            borrowers = Borrower.GetAllBorrowersByDate(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAndTimeLabel();
        }
        private void DateAndTimeLabel()
        {
            lblDate.Text = DateTime.Now.ToString("D");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        void DateTimePickerValues()
        {
            dtpStart.MaxDate = dtpEnd.Value;
            dtpEnd.MinDate = dtpStart.Value;
        }
        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerValues();
            RefreshGridByDate();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerValues();
            RefreshGridByDate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like export this report?", "Export", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dgvReport.Rows.Count == 0)
                {
                    MessageBox.Show("No data to be exported");
                    return;
                }

                DataTable report;

                report = new DataTable();
                foreach (DataGridViewColumn col in dgvReport.Columns)
                {
                    report.Columns.Add(col.HeaderText);
                }

                borrowers.ForEach(b =>
                {
                    report.Rows.Add(
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

                string filename = Util.SaveAndGetExcelName("Borrower_");

                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(report, "borrower");
                wb.SaveAs(filename);

                DialogResult result2 = MessageBox.Show("Borrower report exported. Would you like to open the report?", "Export", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    Process.Start(filename);
                }
                MessageBox.Show("You may find the exported file at " + filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new ReportDialog());
        }
    }
}
