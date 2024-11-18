using ClosedXML.Excel;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class ReportGeneratorScreenForm : UserControl
    {
        List<Product> productReport;
        public ReportGeneratorScreenForm()
        {
            InitializeComponent();
            DateAndTimeLabel();
            timer1.Start();
            
            dtpStart.MaxDate = DateTime.Now;
            dtpEnd.MinDate = DateTime.Now;

            RefreshReportGrid();
        }

        private void DateAndTimeLabel()
        {
            lblDate.Text = DateTime.Now.ToString("D");
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAndTimeLabel();
        }

        private void RefreshReportGrid()
        {
            productReport = Product.GetAllProductsWithStatus();
            dgvReport.Rows.Clear();
            productReport.ForEach(r =>
            {
                dgvReport.Rows.Add(
                    r.Ref_No,
                    r.Item,
                    r.Description,
                    r.End_User,
                    r.Diagnosed,
                    r.Serial_Number,
                    r.Date_Delivered.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Date_Checked.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Remarks,
                    r.Date_Disposed.ToString("MM/dd/yyyy hh:mm:ss")
                    );
            });
            if ( productReport.Count == 0 ) dgvReport.Rows.Add("No record found");
        }

        private void RefreshReportGridByDate()
        {
            productReport = Product.GetAllProductsWithStatusByDate(dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd"));
            dgvReport.Rows.Clear();
            productReport.ForEach(r =>
            {
                dgvReport.Rows.Add(
                    r.Ref_No,
                    r.Item,
                    r.Description,
                    r.End_User,
                    r.Diagnosed,
                    r.Serial_Number,
                    r.Date_Delivered.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Date_Checked.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Remarks,
                    r.Date_Disposed.ToString("MM/dd/yyyy hh:mm:ss")
                    );
            });
            if (productReport.Count == 0) dgvReport.Rows.Add("No record found");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new HomeForm());
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            RefreshReportGridByDate();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            RefreshReportGridByDate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshReportGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to be exported");
                return;
            }

            DataTable report;

            report = new DataTable();
            foreach(DataGridViewColumn col in dgvReport.Columns)
            {
                report.Columns.Add(col.Name);
            }

            productReport.ForEach(r =>
            {
                var datedisposed = r.Date_Disposed.ToString("MM/dd/yyyy hh:mm:ss");
                if (r.Date_Disposed.ToString("MM/dd/yyyy hh:mm:ss") == "01/01/1999 12:00:00")
                {
                    datedisposed = " ";
                }
                report.Rows.Add(
                    r.Ref_No,
                    r.Item,
                    r.Description,
                    r.End_User,
                    r.Diagnosed,
                    r.Serial_Number,
                    r.Date_Delivered.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Date_Checked.ToString("MM/dd/yyyy hh:mm:ss"),
                    r.Remarks,
                    datedisposed
                    );
            });

            string filename = Util.SaveAndGetExcelName();

            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(report, "service");
            wb.SaveAs(filename);

            DialogResult result = MessageBox.Show("Service report exported. Would you like to open the report?", "Export", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Process.Start(filename);
            }
        }
    }
}
