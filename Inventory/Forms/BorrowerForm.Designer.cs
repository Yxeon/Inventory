namespace Inventory.Forms
{
    partial class BorrowerForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Ref_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 529);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvReport);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(890, 456);
            this.panel5.TabIndex = 23;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(736, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(11, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.MaximumSize = new System.Drawing.Size(585, 0);
            this.label8.MinimumSize = new System.Drawing.Size(579, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(579, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "BORROWER LIST";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 372);
            this.panel4.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSaveRecord);
            this.panel2.Controls.Add(this.tbItem);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbDepartment);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbMiddlename);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbFirstname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbLastname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbSerialNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 344);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.btnSaveRecord.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSaveRecord.Location = new System.Drawing.Point(676, 269);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(127, 37);
            this.btnSaveRecord.TabIndex = 14;
            this.btnSaveRecord.Text = "Add";
            this.btnSaveRecord.UseVisualStyleBackColor = false;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // tbItem
            // 
            this.tbItem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItem.Location = new System.Drawing.Point(126, 282);
            this.tbItem.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbItem.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(230, 28);
            this.tbItem.TabIndex = 12;
            this.tbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(65, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Item: ";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartment.Location = new System.Drawing.Point(126, 232);
            this.tbDepartment.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbDepartment.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(230, 28);
            this.tbDepartment.TabIndex = 10;
            this.tbDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDepartment.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(17, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Department:";
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddlename.Location = new System.Drawing.Point(573, 143);
            this.tbMiddlename.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbMiddlename.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(230, 28);
            this.tbMiddlename.TabIndex = 8;
            this.tbMiddlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMiddlename.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(642, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Middlename";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstname.Location = new System.Drawing.Point(294, 143);
            this.tbFirstname.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbFirstname.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(230, 28);
            this.tbFirstname.TabIndex = 6;
            this.tbFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(367, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Firstname";
            // 
            // tbLastname
            // 
            this.tbLastname.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastname.Location = new System.Drawing.Point(21, 143);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbLastname.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(230, 28);
            this.tbLastname.TabIndex = 4;
            this.tbLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(96, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerialNumber.Location = new System.Drawing.Point(102, 69);
            this.tbSerialNumber.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbSerialNumber.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(230, 28);
            this.tbSerialNumber.TabIndex = 2;
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Serial No: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(141, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(585, 0);
            this.label1.MinimumSize = new System.Drawing.Size(579, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "BORROWER FORM MODULE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ref_No,
            this.Item,
            this.Description,
            this.End_User,
            this.Diagnose,
            this.Serial_No,
            this.Date_Delivered,
            this.Date_Checked,
            this.Remarks});
            this.dgvReport.Location = new System.Drawing.Point(17, 34);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(846, 367);
            this.dgvReport.TabIndex = 22;
            // 
            // Ref_No
            // 
            this.Ref_No.HeaderText = "Serial Number";
            this.Ref_No.MinimumWidth = 6;
            this.Ref_No.Name = "Ref_No";
            this.Ref_No.Width = 125;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Fullname";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // End_User
            // 
            this.End_User.HeaderText = "Department";
            this.End_User.MinimumWidth = 6;
            this.End_User.Name = "End_User";
            this.End_User.Width = 125;
            // 
            // Diagnose
            // 
            this.Diagnose.HeaderText = "Date Borrow";
            this.Diagnose.MinimumWidth = 6;
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Width = 125;
            // 
            // Serial_No
            // 
            this.Serial_No.HeaderText = "Status";
            this.Serial_No.MinimumWidth = 6;
            this.Serial_No.Name = "Serial_No";
            this.Serial_No.Width = 125;
            // 
            // Date_Delivered
            // 
            this.Date_Delivered.HeaderText = "Remarks";
            this.Date_Delivered.MinimumWidth = 6;
            this.Date_Delivered.Name = "Date_Delivered";
            this.Date_Delivered.Width = 125;
            // 
            // Date_Checked
            // 
            this.Date_Checked.HeaderText = "Head";
            this.Date_Checked.MinimumWidth = 6;
            this.Date_Checked.Name = "Date_Checked";
            this.Date_Checked.Width = 125;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Lab Assistant";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 125;
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.panel1);
            this.Name = "BorrowerForm";
            this.Size = new System.Drawing.Size(911, 529);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveRecord;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}
