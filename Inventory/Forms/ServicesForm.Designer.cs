namespace Inventory.Forms
{
    partial class ServicesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFileDialogAddImage = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Checkup = new System.Windows.Forms.TabPage();
            this.dgvCheckup = new System.Windows.Forms.DataGridView();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.TabPage();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.Status_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Disposed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckUp = new System.Windows.Forms.Button();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.lblDiagnosed = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblEndUser = new System.Windows.Forms.Label();
            this.tbReferenceNumber = new System.Windows.Forms.TextBox();
            this.lblRefNum = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbDiagnosed = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbEndUser = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Checkup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckup)).BeginInit();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OpenFileDialogAddImage
            // 
            this.OpenFileDialogAddImage.FileName = "openFileDialog1";
            this.OpenFileDialogAddImage.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.btnBackToMainMenu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 561);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 482);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label9.Location = new System.Drawing.Point(25, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Image";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label8.Location = new System.Drawing.Point(25, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Diagnose:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(25, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "End User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(25, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(25, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(25, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reference No.:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.Checkup);
            this.tabControl1.Controls.Add(this.Status);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 488);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 456);
            this.tabControl1.TabIndex = 2;
            // 
            // Checkup
            // 
            this.Checkup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.Checkup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Checkup.Controls.Add(this.dgvCheckup);
            this.Checkup.Location = new System.Drawing.Point(4, 31);
            this.Checkup.Name = "Checkup";
            this.Checkup.Padding = new System.Windows.Forms.Padding(3);
            this.Checkup.Size = new System.Drawing.Size(914, 421);
            this.Checkup.TabIndex = 0;
            this.Checkup.Text = "Check-up";
            // 
            // dgvCheckup
            // 
            this.dgvCheckup.AllowUserToAddRows = false;
            this.dgvCheckup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCheckup.ColumnHeadersHeight = 30;
            this.dgvCheckup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheckup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.Ref_No,
            this.Date_Delivered,
            this.History,
            this.Date_Checked});
            this.dgvCheckup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheckup.Location = new System.Drawing.Point(3, 3);
            this.dgvCheckup.Name = "dgvCheckup";
            this.dgvCheckup.RowHeadersWidth = 51;
            this.dgvCheckup.RowTemplate.Height = 24;
            this.dgvCheckup.Size = new System.Drawing.Size(908, 415);
            this.dgvCheckup.TabIndex = 0;
            this.dgvCheckup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCheckup.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCheckup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Serial_Number
            // 
            this.Serial_Number.HeaderText = "Serial Number";
            this.Serial_Number.MinimumWidth = 6;
            this.Serial_Number.Name = "Serial_Number";
            // 
            // Ref_No
            // 
            this.Ref_No.HeaderText = "Reference Number";
            this.Ref_No.MinimumWidth = 6;
            this.Ref_No.Name = "Ref_No";
            // 
            // Date_Delivered
            // 
            this.Date_Delivered.HeaderText = "Date Delivered";
            this.Date_Delivered.MinimumWidth = 6;
            this.Date_Delivered.Name = "Date_Delivered";
            // 
            // History
            // 
            this.History.HeaderText = "History";
            this.History.MinimumWidth = 6;
            this.History.Name = "History";
            // 
            // Date_Checked
            // 
            this.Date_Checked.HeaderText = "Date Checked";
            this.Date_Checked.MinimumWidth = 6;
            this.Date_Checked.Name = "Date_Checked";
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.Status.Controls.Add(this.dgvStatus);
            this.Status.Location = new System.Drawing.Point(4, 31);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(3);
            this.Status.Size = new System.Drawing.Size(914, 421);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status";
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStatus.ColumnHeadersHeight = 30;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status_Id,
            this.dataGridViewTextBoxColumn1,
            this.Remarks,
            this.Date_Disposed});
            this.dgvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatus.Location = new System.Drawing.Point(3, 3);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersWidth = 51;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.Size = new System.Drawing.Size(908, 415);
            this.dgvStatus.TabIndex = 1;
            this.dgvStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellContentClick);
            this.dgvStatus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellDoubleClick);
            // 
            // Status_Id
            // 
            this.Status_Id.HeaderText = "Reference Number";
            this.Status_Id.MinimumWidth = 6;
            this.Status_Id.Name = "Status_Id";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            // 
            // Date_Disposed
            // 
            this.Date_Disposed.HeaderText = "Date Disposed";
            this.Date_Disposed.MinimumWidth = 6;
            this.Date_Disposed.Name = "Date_Disposed";
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(806, 962);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(147, 41);
            this.btnBackToMainMenu.TabIndex = 4;
            this.btnBackToMainMenu.Text = "Back";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCheckUp);
            this.panel3.Controls.Add(this.btnSaveRecord);
            this.panel3.Controls.Add(this.lblDiagnosed);
            this.panel3.Controls.Add(this.btnAddRecord);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.lblEndUser);
            this.panel3.Controls.Add(this.tbReferenceNumber);
            this.panel3.Controls.Add(this.lblRefNum);
            this.panel3.Controls.Add(this.lblItem);
            this.panel3.Controls.Add(this.lblDescription);
            this.panel3.Controls.Add(this.pbPicture);
            this.panel3.Controls.Add(this.tbItem);
            this.panel3.Controls.Add(this.tbDiagnosed);
            this.panel3.Controls.Add(this.tbDescription);
            this.panel3.Controls.Add(this.tbEndUser);
            this.panel3.Location = new System.Drawing.Point(190, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 482);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(595, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "List Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(585, 0);
            this.label1.MinimumSize = new System.Drawing.Size(579, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILE MAINTENANCE MODULE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckUp
            // 
            this.btnCheckUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.btnCheckUp.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCheckUp.Location = new System.Drawing.Point(441, 432);
            this.btnCheckUp.Name = "btnCheckUp";
            this.btnCheckUp.Size = new System.Drawing.Size(127, 37);
            this.btnCheckUp.TabIndex = 3;
            this.btnCheckUp.Text = "Check-up";
            this.btnCheckUp.UseVisualStyleBackColor = false;
            this.btnCheckUp.Visible = false;
            this.btnCheckUp.Click += new System.EventHandler(this.btnUndoRecord_Click);
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.btnSaveRecord.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSaveRecord.Location = new System.Drawing.Point(595, 432);
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.Size = new System.Drawing.Size(127, 37);
            this.btnSaveRecord.TabIndex = 2;
            this.btnSaveRecord.Text = "Save Record";
            this.btnSaveRecord.UseVisualStyleBackColor = false;
            this.btnSaveRecord.Visible = false;
            this.btnSaveRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // lblDiagnosed
            // 
            this.lblDiagnosed.AutoSize = true;
            this.lblDiagnosed.ForeColor = System.Drawing.Color.Red;
            this.lblDiagnosed.Location = new System.Drawing.Point(24, 358);
            this.lblDiagnosed.Name = "lblDiagnosed";
            this.lblDiagnosed.Size = new System.Drawing.Size(27, 16);
            this.lblDiagnosed.TabIndex = 11;
            this.lblDiagnosed.Text = "red";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(122)))), ((int)(((byte)(145)))));
            this.btnAddRecord.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAddRecord.Location = new System.Drawing.Point(595, 433);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(127, 37);
            this.btnAddRecord.TabIndex = 0;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Brown;
            this.linkLabel1.Location = new System.Drawing.Point(129, 377);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(398, 92);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Attach image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblEndUser
            // 
            this.lblEndUser.AutoSize = true;
            this.lblEndUser.ForeColor = System.Drawing.Color.Red;
            this.lblEndUser.Location = new System.Drawing.Point(24, 305);
            this.lblEndUser.Name = "lblEndUser";
            this.lblEndUser.Size = new System.Drawing.Size(27, 16);
            this.lblEndUser.TabIndex = 10;
            this.lblEndUser.Text = "red";
            // 
            // tbReferenceNumber
            // 
            this.tbReferenceNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReferenceNumber.Location = new System.Drawing.Point(18, 117);
            this.tbReferenceNumber.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbReferenceNumber.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbReferenceNumber.MinimumSize = new System.Drawing.Size(230, 30);
            this.tbReferenceNumber.Name = "tbReferenceNumber";
            this.tbReferenceNumber.Size = new System.Drawing.Size(666, 28);
            this.tbReferenceNumber.TabIndex = 1;
            this.tbReferenceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbReferenceNumber.TextChanged += new System.EventHandler(this.tbReferenceNumber_TextChanged);
            // 
            // lblRefNum
            // 
            this.lblRefNum.AutoSize = true;
            this.lblRefNum.ForeColor = System.Drawing.Color.Red;
            this.lblRefNum.Location = new System.Drawing.Point(24, 149);
            this.lblRefNum.Name = "lblRefNum";
            this.lblRefNum.Size = new System.Drawing.Size(27, 16);
            this.lblRefNum.TabIndex = 7;
            this.lblRefNum.Text = "red";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.ForeColor = System.Drawing.Color.Red;
            this.lblItem.Location = new System.Drawing.Point(24, 202);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 16);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "red";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.Red;
            this.lblDescription.Location = new System.Drawing.Point(24, 253);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(27, 16);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "red";
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.Control;
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(18, 377);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(10);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(98, 98);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbItem
            // 
            this.tbItem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItem.Location = new System.Drawing.Point(18, 169);
            this.tbItem.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbItem.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbItem.MinimumSize = new System.Drawing.Size(230, 30);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(666, 28);
            this.tbItem.TabIndex = 2;
            this.tbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDiagnosed
            // 
            this.tbDiagnosed.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiagnosed.Location = new System.Drawing.Point(18, 325);
            this.tbDiagnosed.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbDiagnosed.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbDiagnosed.MinimumSize = new System.Drawing.Size(230, 30);
            this.tbDiagnosed.Name = "tbDiagnosed";
            this.tbDiagnosed.Size = new System.Drawing.Size(666, 28);
            this.tbDiagnosed.TabIndex = 5;
            this.tbDiagnosed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(18, 221);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbDescription.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbDescription.MinimumSize = new System.Drawing.Size(230, 30);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(666, 28);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEndUser
            // 
            this.tbEndUser.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndUser.Location = new System.Drawing.Point(18, 273);
            this.tbEndUser.Margin = new System.Windows.Forms.Padding(10, 10, 3, 12);
            this.tbEndUser.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.tbEndUser.MinimumSize = new System.Drawing.Size(230, 30);
            this.tbEndUser.Name = "tbEndUser";
            this.tbEndUser.Size = new System.Drawing.Size(666, 28);
            this.tbEndUser.TabIndex = 4;
            this.tbEndUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(482, 919);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 12;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(97)))));
            this.CausesValidation = false;
            this.Controls.Add(this.panel2);
            this.Name = "ServicesForm";
            this.Size = new System.Drawing.Size(993, 561);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Checkup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckup)).EndInit();
            this.Status.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogAddImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckUp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Checkup;
        private System.Windows.Forms.DataGridView dgvCheckup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Checked;
        private System.Windows.Forms.TabPage Status;
        private System.Windows.Forms.DataGridView dgvStatus;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbReferenceNumber;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbEndUser;
        private System.Windows.Forms.TextBox tbDiagnosed;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label lblDiagnosed;
        private System.Windows.Forms.Label lblEndUser;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblRefNum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Disposed;
        private System.Windows.Forms.Button button1;
    }
}
