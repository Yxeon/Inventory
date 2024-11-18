using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
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
    public partial class ProductList : UserControl
    {
        List<Product> products;

        public ProductList()
        {
            InitializeComponent();
            RefreshGrid();
        }

        void RefreshGrid()
        {
            products = Product.GetAllProducts();
            dgvCheckup.Rows.Clear();
            products.ForEach(p =>
            {
                dgvCheckup.Rows.Add(
                    p.Ref_No,
                    p.Item,
                    p.Description,
                    p.End_User,
                    p.Diagnosed,
                    p.Date_Delivered
                    );
            });
            if (products.Count == 0) dgvCheckup.Rows.Add("No Product Found");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new ServicesForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select search by");
                RefreshGrid();
                return;
            }
            products = Product.SearchProductBy(comboBox1.Text, textBox1.Text);
            dgvCheckup.Rows.Clear();
            products.ForEach(p =>
            {
                dgvCheckup.Rows.Add(
                    p.Ref_No,
                    p.Item,
                    p.Description,
                    p.End_User,
                    p.Diagnosed,
                    p.Date_Delivered
                    );
            });
            if (products.Count == 0) dgvCheckup.Rows.Add("No Product Found");
        }

        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void dgvCheckup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (products.Count == 0) return;
                Product product = products[e.RowIndex];
                Statuss status = Statuss.CheckStatusExist(product.Ref_No);
                if (status == null)
                {
                    DialogResult result = MessageBox.Show("Are you sure that add a check-up for " + product.Ref_No + " product?", "Check up", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.LoadForm(new CheckupForm(product));
                    }
                }
                else if (status == null || status.Stat == "OPERATIONAL")
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
    }
}
