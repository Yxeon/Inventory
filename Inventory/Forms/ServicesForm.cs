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
    public partial class ServicesForm : UserControl
    {
        List<Check_up> check_Up;
        List<Statuss> statusList;
        List<Validator> validators = new List<Validator>();

        public ServicesForm()
        {
            InitializeComponent();

            validators.Add(new Validator(tbReferenceNumber, lblRefNum, "Reference no.", "required|min:5|unique:tblProduct,Ref_No"));
            validators.Add(new Validator(tbItem, lblItem, "Item", "required|min:3"));
            validators.Add(new Validator(tbDescription, lblDescription, "Description", "required|min:5"));
            validators.Add(new Validator(tbEndUser, lblEndUser, "End user", "required|min:5"));
            validators.Add(new Validator(tbDiagnosed, lblDiagnosed, "Diagnose", "required|min:3"));

            RefreshCheckup();
            RefreshStatus();
        }

        private void ClearAll()
        {
            tbReferenceNumber.Text = string.Empty;
            tbEndUser.Text = string.Empty;
            tbItem.Text = string.Empty;
            tbDescription.Text = string.Empty;
            tbDiagnosed.Text = string.Empty;
            pbPicture.ImageLocation = null;
            linkLabel1.Text = "Add image";

            btnAddRecord.Visible = true;
            btnSaveRecord.Visible = false;
        }

        private void RefreshCheckup()
        {
            check_Up = Check_up.GetAllCheckUp();
            dgvCheckup.Rows.Clear();
            check_Up.ForEach(c =>
            {
                dgvCheckup.Rows.Add(
                    c.Serial_Number,
                    c.Ref_No,
                    c.Date_Delivered,
                    c.History,
                    c.Date_Checked
                    );
            });
            if (check_Up.Count == 0) dgvCheckup.Rows.Add("", "", "No check upsfound", "", "");
        }

        private void RefreshStatus()
        {
            statusList = Models.Statuss.GetAllStatus();
            dgvStatus.Rows.Clear();
            statusList.ForEach(s =>
            {
                var datedisposed = s.Date_Diposed.ToString("MM/dd/yyyy hh:mm:ss");
                
                dgvStatus.Rows.Add(
                    s.Ref_No,
                    s.Stat,
                    s.Remarks,
                    s.Date_Diposed
                    );
            });
            if (statusList.Count == 0) dgvStatus.Rows.Add("No status found");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (check_Up.Count == 0) return;
                Check_up checkup = check_Up[e.RowIndex];
                Product product = Product.SearchProduct(checkup.Ref_No);
                Statuss status = Statuss.CheckStatusExist(checkup.Ref_No);
                if (status == null || status.Stat == "OPERATIONAL")
                {
                    DialogResult result = MessageBox.Show("Are you sure that add another check-up for " + product.Ref_No + " product?", "Check up", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new CheckupForm(product));
                    }
                }
                else
                {
                    MessageBox.Show("This product has already been disposed");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure to remove this product?", "Remove product", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var product = new Product()
                {
                    Ref_No = tbReferenceNumber.Text
                };
                product.DeleteProduct();
                MessageBox.Show("Product successfully removed");
                ClearAll();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new FileMaintenanceForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenFileDialogAddImage.ShowDialog() == DialogResult.OK)
            {
                linkLabel1.Text = OpenFileDialogAddImage.FileName;
                pbPicture.ImageLocation = OpenFileDialogAddImage.FileName;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnUndoRecord_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new CheckupForm(Product.SearchProduct(tbReferenceNumber.Text)));
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    var pic = pbPicture.ImageLocation;
                    if (pbPicture.ImageLocation == null)
                    {
                        pic = "No attached image";
                    }
                    if (tbReferenceNumber.Text == string.Empty) throw new Level1Exception("Please enter a valid reference number");
                    var product = new Product()
                    {
                        Ref_No = tbReferenceNumber.Text.Trim(),
                        Item = tbItem.Text,
                        Description = tbDescription.Text,
                        End_User = tbEndUser.Text,
                        Diagnosed = tbDiagnosed.Text,
                        Picture = pic,
                        Date_Delivered = DateTime.Now
                    };
                    product.AddProduct();
                    ClearAll();
                    DialogResult result = MessageBox.Show("Would you like also to perform check-up?", "Check-up", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new CheckupForm(product));
                    }
                    MessageBox.Show("Product successfully added");
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void tbReferenceNumber_TextChanged(object sender, EventArgs e)
        {
            Product product = Product.SearchProduct(tbReferenceNumber.Text);
            validators.ForEach(v => v.Reset());
            if (product != null)
            {
                tbItem.Text = product.Item;
                tbDescription.Text = product.Description;
                tbEndUser.Text = product.End_User;
                tbDiagnosed.Text = product.Diagnosed;
                linkLabel1.Text = product.Picture;
                pbPicture.ImageLocation = product.Picture;

                btnAddRecord.Visible = false;
                btnSaveRecord.Visible = true;
                btnCheckUp.Visible = true;
            }
            else
            {
                tbItem.Text = string.Empty;
                tbDescription.Text = string.Empty;
                tbEndUser.Text = string.Empty;
                tbDiagnosed.Text = string.Empty;
                linkLabel1.Text = "Attach image";
                pbPicture.ImageLocation = null;

                btnAddRecord.Visible = true;
                btnSaveRecord.Visible = false;
                btnCheckUp.Visible = false;
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (validators.Count((validator) => validator.IsValid()) == validators.Count)
            {

                var product = new Product()
                {
                    Ref_No = tbReferenceNumber.Text,
                    Item = tbItem.Text,
                    Description = tbDescription.Text,
                    End_User = tbEndUser.Text,
                    Diagnosed = tbDiagnosed.Text,
                    Picture = pbPicture.ImageLocation,
                };
                product.UpdateProduct();
                Check_up check = Check_up.CheckCheckupExist(product.Ref_No);
                if (check == null)
                {
                    DialogResult result = MessageBox.Show("This product hasn't been checked. Want to proceed to check up?", "Check up", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new CheckupForm(product));
                    }
                }
                ClearAll();
                MessageBox.Show("Product" + product.Item + " successfully updated");
            }
        }

        private void dgvStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (statusList.Count == 0) return;
            }
        }

        private void dgvStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (statusList.Count == 0) return;
                Statuss stat = statusList[e.RowIndex];
                Product product = Product.SearchProduct(stat.Ref_No);
                if (stat.Stat == "OPERATIONAL")
                {
                    DialogResult result = MessageBox.Show("Are you sure that add another check-up for " + product.Ref_No + " product?", "Check up", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new CheckupForm(product));
                    }
                }
                else
                {
                    MessageBox.Show("This product has already been disposed");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new ProductList());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
