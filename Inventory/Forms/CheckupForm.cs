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
    public partial class CheckupForm : UserControl
    {
        Product product;
        List<Validator> validators = new List<Validator>();

        public CheckupForm(Product product)
        {
            this.product = product;
            InitializeComponent();

            validators.Add(new Validator(tbCheckup, lblRed, "Check up", "required|min:5"));

            cbStatus.SelectedIndex = 0;
            lblStatus.Visible = false;

            Autofill();
        }
        private void Autofill()
        {
            var check = Check_up.CheckCheckupExist(product.Ref_No);
            if (check == null)
            {
                tbSerialNumber.Text = Check_up.GenerateSerialNumberForm();
            }
            else
            {
                tbSerialNumber.Text = check.Serial_Number;
            }

            tbReferenceNumber.Text = product.Ref_No;
            tbDateDelivered.Text = product.Date_Delivered.ToString("d");
            tbItemName.Text = product.Item;
            tbEndUser.Text = product.End_User;
            tbDiagnose.Text = product.Diagnosed;
            pbProduct.ImageLocation = product.Picture;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (validators.Count((validator) => validator.IsValid()) == validators.Count)
                {
                    if (cbStatus.SelectedIndex == 0)
                    {
                        lblStatus.Visible = true;
                        MessageBox.Show("Please select status.");
                        return;
                    }
                    else if (cbStatus.SelectedIndex == 1)
                    {
                        var history = "";
                        Check_up gethistory = Check_up.CheckCheckupExist(product.Ref_No);
                        if (gethistory != null)
                        {
                            history = gethistory.History + ", " + tbCheckup.Text;
                            var checkup = new Check_up()
                            {
                                Serial_Number = tbSerialNumber.Text,
                                History = history,
                                Date_Checked = DateTime.Now
                            };
                            checkup.UpdateCheckup();
                        }
                        else
                        {
                            history = tbCheckup.Text;
                            var checkup = new Check_up()
                            {
                                Ref_No = tbReferenceNumber.Text,
                                Date_Delivered = product.Date_Delivered,
                                History = history,
                                Date_Checked = DateTime.Now
                            };
                            checkup.AddCheckup();
                        }

                        var status = new Statuss()
                        {
                            Ref_No = tbReferenceNumber.Text,
                            Stat = cbStatus.Text,
                            Remarks = "Ongoing checkup",
                            Date_Diposed = DateTime.Parse("01/01/1999")
                        }; 
                        status.SaveStatus();

                        MessageBox.Show("Product successfully added to check-up");
                        MainForm.LoadForm(new ServicesForm());
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("You chose fixed or fixed meaning the product will be disposed. Continue?", "Status", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            var status = new Statuss()
                            {
                                Stat = cbStatus.Text,
                                Ref_No = tbReferenceNumber.Text,
                                Remarks = tbCheckup.Text,
                                Date_Diposed = DateTime.Now,
                            };
                            status.UpdateStatus();
                            MessageBox.Show("Product successfully disposed");
                            MainForm.LoadForm(new ServicesForm());
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex != 0 || tbCheckup.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("The changes will not be saved. Are you sure to close this form?", "Cancel", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MainForm.LoadForm(new ServicesForm());
                }
                else
                {
                    return;
                }
            }
            MainForm.LoadForm(new ServicesForm());
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                lblStatus.Visible = true;
            }
            else if (cbStatus.SelectedIndex == 1)
            {
                lblStatus.Visible = false;
                lblRemarks.Text = "Check-up";
            }
            else
            {
                lblStatus.Visible = false;
                lblRemarks.Text = "Remarks";
            }
        }
    }
}
