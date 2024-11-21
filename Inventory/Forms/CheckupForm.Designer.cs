namespace Inventory.Forms
{
    partial class CheckupForm
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.tbDiagnose = new System.Windows.Forms.TextBox();
            this.tbEndUser = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbDateDelivered = new System.Windows.Forms.TextBox();
            this.tbReferenceNumber = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbCheckup = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOkay);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblRed);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblService);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.tbDateDelivered);
            this.panel1.Controls.Add(this.tbReferenceNumber);
            this.panel1.Controls.Add(this.tbSerialNumber);
            this.panel1.Controls.Add(this.tbCheckup);
            this.panel1.Controls.Add(this.lblRemarks);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 476);
            this.panel1.TabIndex = 0;
            // 
            // btnOkay
            // 
            this.btnOkay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOkay.Location = new System.Drawing.Point(670, 407);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 16;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Visible = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(781, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "*Required";
            this.lblStatus.Visible = false;
            // 
            // lblRed
            // 
            this.lblRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRed.AutoSize = true;
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(504, 382);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 16);
            this.lblRed.TabIndex = 14;
            this.lblRed.Text = "red";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "--SELECT--",
            "OPERATIONAL",
            "FIXED",
            "UNFIXABLE"});
            this.cbStatus.Location = new System.Drawing.Point(778, 64);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(138, 24);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label9.Location = new System.Drawing.Point(719, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Status:";
            // 
            // lblService
            // 
            this.lblService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.lblService.Location = new System.Drawing.Point(591, 26);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(207, 27);
            this.lblService.TabIndex = 11;
            this.lblService.Text = "CHECK UP FORM";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbProduct);
            this.groupBox1.Controls.Add(this.tbDiagnose);
            this.groupBox1.Controls.Add(this.tbEndUser);
            this.groupBox1.Controls.Add(this.tbItemName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 406);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Information";
            // 
            // pbProduct
            // 
            this.pbProduct.Location = new System.Drawing.Point(119, 27);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(196, 196);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduct.TabIndex = 17;
            this.pbProduct.TabStop = false;
            // 
            // tbDiagnose
            // 
            this.tbDiagnose.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiagnose.Location = new System.Drawing.Point(158, 329);
            this.tbDiagnose.Name = "tbDiagnose";
            this.tbDiagnose.ReadOnly = true;
            this.tbDiagnose.Size = new System.Drawing.Size(267, 28);
            this.tbDiagnose.TabIndex = 16;
            // 
            // tbEndUser
            // 
            this.tbEndUser.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndUser.Location = new System.Drawing.Point(158, 284);
            this.tbEndUser.Name = "tbEndUser";
            this.tbEndUser.ReadOnly = true;
            this.tbEndUser.Size = new System.Drawing.Size(267, 28);
            this.tbEndUser.TabIndex = 15;
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(158, 239);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.ReadOnly = true;
            this.tbItemName.Size = new System.Drawing.Size(267, 28);
            this.tbItemName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label7.Location = new System.Drawing.Point(3, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reported Diagnose:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label6.Location = new System.Drawing.Point(4, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "End User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label5.Location = new System.Drawing.Point(4, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(570, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDone.Location = new System.Drawing.Point(768, 407);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbDateDelivered
            // 
            this.tbDateDelivered.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDateDelivered.Enabled = false;
            this.tbDateDelivered.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateDelivered.Location = new System.Drawing.Point(649, 180);
            this.tbDateDelivered.Name = "tbDateDelivered";
            this.tbDateDelivered.ReadOnly = true;
            this.tbDateDelivered.Size = new System.Drawing.Size(267, 28);
            this.tbDateDelivered.TabIndex = 7;
            // 
            // tbReferenceNumber
            // 
            this.tbReferenceNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReferenceNumber.Enabled = false;
            this.tbReferenceNumber.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReferenceNumber.Location = new System.Drawing.Point(649, 147);
            this.tbReferenceNumber.Name = "tbReferenceNumber";
            this.tbReferenceNumber.ReadOnly = true;
            this.tbReferenceNumber.Size = new System.Drawing.Size(267, 28);
            this.tbReferenceNumber.TabIndex = 6;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSerialNumber.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerialNumber.Location = new System.Drawing.Point(649, 114);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.ReadOnly = true;
            this.tbSerialNumber.Size = new System.Drawing.Size(267, 28);
            this.tbSerialNumber.TabIndex = 5;
            // 
            // tbCheckup
            // 
            this.tbCheckup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCheckup.Location = new System.Drawing.Point(503, 290);
            this.tbCheckup.Multiline = true;
            this.tbCheckup.Name = "tbCheckup";
            this.tbCheckup.Size = new System.Drawing.Size(401, 90);
            this.tbCheckup.TabIndex = 4;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.lblRemarks.Location = new System.Drawing.Point(499, 255);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(76, 22);
            this.lblRemarks.TabIndex = 3;
            this.lblRemarks.Text = "Check-up:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(469, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Delivered:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(469, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference Number:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(4)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(469, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            // 
            // CheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.Controls.Add(this.panel1);
            this.Name = "CheckupForm";
            this.Size = new System.Drawing.Size(949, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReferenceNumber;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbCheckup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbDateDelivered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDiagnose;
        private System.Windows.Forms.TextBox tbEndUser;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnOkay;
    }
}
