namespace hr_demo
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            pnlLoading = new Panel();
            lblLoading = new Label();
            dtgListUser = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            txtSearch = new TextBox();
            cmbCompanyFilter = new ComboBox();
            btnClearFilter = new Button();
            panel7 = new Panel();
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            btnDeleteCustomer = new Button();
            chartSummary = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            lblTotalResigned = new Label();
            label12 = new Label();
            lblTotalActive = new Label();
            label4 = new Label();
            lblTotalEmp = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblAttendanceLate = new Label();
            lblAttentdancePresent = new Label();
            label17 = new Label();
            label16 = new Label();
            lblTotalAttendance = new Label();
            label6 = new Label();
            panel5 = new Panel();
            lblRequestBenefit = new Label();
            lblRequestLeave = new Label();
            ll = new Label();
            label20 = new Label();
            lblTotalPendingRequest = new Label();
            llx = new Label();
            panel6 = new Panel();
            lblTotalIncomingBd = new Label();
            label14 = new Label();
            btnLohout = new Button();
            btnScanMonitor = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnManageEmp = new Button();
            lblTitle = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListUser).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSummary).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLohout);
            panel1.Controls.Add(btnScanMonitor);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnManageEmp);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 632);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 8, 9, 8);
            panel2.Size = new Size(1446, 526);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(pnlLoading);
            panel8.Controls.Add(dtgListUser);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(txtSearch);
            panel8.Controls.Add(cmbCompanyFilter);
            panel8.Controls.Add(btnClearFilter);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(9, 119);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(9, 0, 0, 0);
            panel8.Size = new Size(1065, 400);
            panel8.TabIndex = 3;
            // 
            // pnlLoading
            // 
            pnlLoading.BackColor = Color.LightGray;
            pnlLoading.Controls.Add(lblLoading);
            pnlLoading.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlLoading.Location = new Point(676, 123);
            pnlLoading.Margin = new Padding(3, 2, 3, 2);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(219, 94);
            pnlLoading.TabIndex = 6;
            pnlLoading.Visible = false;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(71, 38);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(72, 20);
            lblLoading.TabIndex = 0;
            lblLoading.Text = "Loading...";
            // 
            // dtgListUser
            // 
            dtgListUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgListUser.BackgroundColor = Color.White;
            dtgListUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListUser.Location = new Point(2, 39);
            dtgListUser.Margin = new Padding(3, 2, 3, 2);
            dtgListUser.Name = "dtgListUser";
            dtgListUser.RowHeadersWidth = 51;
            dtgListUser.Size = new Size(1038, 326);
            dtgListUser.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 17);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 1;
            label9.Text = "Showing 0 of 0 Customers";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 2);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 0;
            label8.Text = "Title";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(276, 10);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(193, 23);
            txtSearch.TabIndex = 3;
            // 
            // cmbCompanyFilter
            // 
            cmbCompanyFilter.Location = new Point(474, 10);
            cmbCompanyFilter.Margin = new Padding(3, 2, 3, 2);
            cmbCompanyFilter.Name = "cmbCompanyFilter";
            cmbCompanyFilter.Size = new Size(176, 23);
            cmbCompanyFilter.TabIndex = 4;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(662, 10);
            btnClearFilter.Margin = new Padding(3, 2, 3, 2);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(83, 22);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Clear";
            btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnAddCustomer);
            panel7.Controls.Add(btnUpdateCustomer);
            panel7.Controls.Add(btnDeleteCustomer);
            panel7.Controls.Add(chartSummary);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1074, 119);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(363, 399);
            panel7.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.SlateGray;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.ForeColor = SystemColors.Control;
            btnAddCustomer.Location = new Point(18, 10);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(88, 31);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.SlateGray;
            btnUpdateCustomer.ForeColor = SystemColors.Control;
            btnUpdateCustomer.Location = new Point(114, 10);
            btnUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(88, 31);
            btnUpdateCustomer.TabIndex = 1;
            btnUpdateCustomer.Text = "Update";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.OrangeRed;
            btnDeleteCustomer.ForeColor = SystemColors.Control;
            btnDeleteCustomer.Location = new Point(210, 10);
            btnDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(76, 31);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // chartSummary
            // 
            chartSummary.BackColor = Color.WhiteSmoke;
            chartSummary.BorderStyle = BorderStyle.FixedSingle;
            chartSummary.Location = new Point(18, 52);
            chartSummary.Margin = new Padding(3, 2, 3, 2);
            chartSummary.Name = "chartSummary";
            chartSummary.Size = new Size(333, 312);
            chartSummary.TabIndex = 3;
            chartSummary.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel6, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(9, 8);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1428, 111);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(lblTotalResigned);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(lblTotalActive);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblTotalEmp);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 107);
            panel3.TabIndex = 0;
            // 
            // lblTotalResigned
            // 
            lblTotalResigned.AutoSize = true;
            lblTotalResigned.Location = new Point(309, 85);
            lblTotalResigned.Name = "lblTotalResigned";
            lblTotalResigned.Size = new Size(13, 15);
            lblTotalResigned.TabIndex = 5;
            lblTotalResigned.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 55);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 4;
            label12.Text = "Active";
            // 
            // lblTotalActive
            // 
            lblTotalActive.AutoSize = true;
            lblTotalActive.Location = new Point(309, 55);
            lblTotalActive.Name = "lblTotalActive";
            lblTotalActive.Size = new Size(13, 15);
            lblTotalActive.TabIndex = 3;
            lblTotalActive.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 82);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "Resigned";
            // 
            // lblTotalEmp
            // 
            lblTotalEmp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalEmp.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalEmp.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalEmp.Location = new Point(297, 19);
            lblTotalEmp.Name = "lblTotalEmp";
            lblTotalEmp.Size = new Size(41, 28);
            lblTotalEmp.TabIndex = 1;
            lblTotalEmp.Text = "0";
            lblTotalEmp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(-3, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 0;
            label2.Text = "Total Employees";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(lblAttendanceLate);
            panel4.Controls.Add(lblAttentdancePresent);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(lblTotalAttendance);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(360, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 107);
            panel4.TabIndex = 1;
            // 
            // lblAttendanceLate
            // 
            lblAttendanceLate.AutoSize = true;
            lblAttendanceLate.Location = new Point(316, 82);
            lblAttendanceLate.Name = "lblAttendanceLate";
            lblAttendanceLate.Size = new Size(13, 15);
            lblAttendanceLate.TabIndex = 8;
            lblAttendanceLate.Text = "0";
            // 
            // lblAttentdancePresent
            // 
            lblAttentdancePresent.AutoSize = true;
            lblAttentdancePresent.Location = new Point(316, 55);
            lblAttentdancePresent.Name = "lblAttentdancePresent";
            lblAttentdancePresent.Size = new Size(13, 15);
            lblAttentdancePresent.TabIndex = 6;
            lblAttentdancePresent.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(9, 82);
            label17.Name = "label17";
            label17.Size = new Size(24, 15);
            label17.TabIndex = 7;
            label17.Text = "สาย";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(9, 55);
            label16.Name = "label16";
            label16.Size = new Size(18, 15);
            label16.TabIndex = 6;
            label16.Text = "ลา";
            // 
            // lblTotalAttendance
            // 
            lblTotalAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalAttendance.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAttendance.Location = new Point(302, 12);
            lblTotalAttendance.Name = "lblTotalAttendance";
            lblTotalAttendance.Size = new Size(46, 35);
            lblTotalAttendance.TabIndex = 1;
            lblTotalAttendance.Text = "0";
            lblTotalAttendance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 19);
            label6.TabIndex = 0;
            label6.Text = "Today's Attendance";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(lblRequestBenefit);
            panel5.Controls.Add(lblRequestLeave);
            panel5.Controls.Add(ll);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(lblTotalPendingRequest);
            panel5.Controls.Add(llx);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(717, 2);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(351, 107);
            panel5.TabIndex = 2;
            // 
            // lblRequestBenefit
            // 
            lblRequestBenefit.AutoSize = true;
            lblRequestBenefit.Location = new Point(298, 82);
            lblRequestBenefit.Name = "lblRequestBenefit";
            lblRequestBenefit.Size = new Size(13, 15);
            lblRequestBenefit.TabIndex = 9;
            lblRequestBenefit.Text = "0";
            // 
            // lblRequestLeave
            // 
            lblRequestLeave.AutoSize = true;
            lblRequestLeave.Location = new Point(298, 55);
            lblRequestLeave.Name = "lblRequestLeave";
            lblRequestLeave.Size = new Size(13, 15);
            lblRequestLeave.TabIndex = 9;
            lblRequestLeave.Text = "0";
            // 
            // ll
            // 
            ll.AutoSize = true;
            ll.Location = new Point(3, 82);
            ll.Name = "ll";
            ll.Size = new Size(90, 15);
            ll.TabIndex = 10;
            ll.Text = "คำขอเบิกสวัสดิการ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 55);
            label20.Name = "label20";
            label20.Size = new Size(43, 15);
            label20.TabIndex = 9;
            label20.Text = "คำขอลา";
            // 
            // lblTotalPendingRequest
            // 
            lblTotalPendingRequest.AutoSize = true;
            lblTotalPendingRequest.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPendingRequest.Location = new Point(298, 12);
            lblTotalPendingRequest.Name = "lblTotalPendingRequest";
            lblTotalPendingRequest.Size = new Size(25, 30);
            lblTotalPendingRequest.TabIndex = 1;
            lblTotalPendingRequest.Text = "0";
            // 
            // llx
            // 
            llx.AutoSize = true;
            llx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llx.Location = new Point(3, 0);
            llx.Name = "llx";
            llx.Size = new Size(120, 19);
            llx.TabIndex = 0;
            llx.Text = "Pending Requests";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(lblTotalIncomingBd);
            panel6.Controls.Add(label14);
            panel6.Dock = DockStyle.Fill;
            panel6.ForeColor = Color.Black;
            panel6.Location = new Point(1074, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(351, 107);
            panel6.TabIndex = 3;
            // 
            // lblTotalIncomingBd
            // 
            lblTotalIncomingBd.AutoSize = true;
            lblTotalIncomingBd.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalIncomingBd.Location = new Point(303, 14);
            lblTotalIncomingBd.Name = "lblTotalIncomingBd";
            lblTotalIncomingBd.Size = new Size(25, 30);
            lblTotalIncomingBd.TabIndex = 1;
            lblTotalIncomingBd.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(225, 19);
            label14.TabIndex = 0;
            label14.Text = "Upcoming Birthdays/Anniversaries";
            // 
            // btnLohout
            // 
            btnLohout.Location = new Point(9, 584);
            btnLohout.Margin = new Padding(3, 2, 3, 2);
            btnLohout.Name = "btnLohout";
            btnLohout.Size = new Size(82, 22);
            btnLohout.TabIndex = 4;
            btnLohout.Text = "Logout";
            btnLohout.UseVisualStyleBackColor = true;
            btnLohout.Click += btnLohout_Click;
            // 
            // btnScanMonitor
            // 
            btnScanMonitor.ForeColor = SystemColors.HotTrack;
            btnScanMonitor.Location = new Point(662, 9);
            btnScanMonitor.Margin = new Padding(3, 2, 3, 2);
            btnScanMonitor.Name = "btnScanMonitor";
            btnScanMonitor.Size = new Size(174, 22);
            btnScanMonitor.TabIndex = 5;
            btnScanMonitor.Text = "Scan monitor(Real Time)";
            btnScanMonitor.UseVisualStyleBackColor = true;
            btnScanMonitor.Click += btnScanMonitor_Click;
            // 
            // button4
            // 
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(842, 8);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(260, 22);
            button4.TabIndex = 4;
            button4.Text = "การตั้งค่าและรายงาน (Settings and Reports)";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(483, 8);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(174, 22);
            button3.TabIndex = 3;
            button3.Text = "ระบบเงินเดือน (Payroll)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(304, 8);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(174, 22);
            button2.TabIndex = 2;
            button2.Text = "ระบบบันทึกเวลาและขาดลา";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnManageEmp
            // 
            btnManageEmp.BackColor = Color.Transparent;
            btnManageEmp.FlatAppearance.BorderSize = 0;
            btnManageEmp.FlatStyle = FlatStyle.Flat;
            btnManageEmp.ForeColor = SystemColors.HotTrack;
            btnManageEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageEmp.Location = new Point(125, 9);
            btnManageEmp.Margin = new Padding(3, 2, 3, 2);
            btnManageEmp.Name = "btnManageEmp";
            btnManageEmp.Size = new Size(170, 22);
            btnManageEmp.TabIndex = 1;
            btnManageEmp.Text = "ระบบบริหารจัดการพนักงาน";
            btnManageEmp.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "A.I Technology";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 630);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnlLoading.ResumeLayout(false);
            pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListUser).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSummary).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblTotalActive;
        private Label label4;
        private Label lblTotalEmp;
        private Label label2;
        private Label lblTotalAttendance;
        private Label label6;
        private Label lblTotalPendingRequest;
        private Label llx;
        private Label lblTotalIncomingBd;
        private Label label14;
        private Label lblTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dtgListUser;
        // filter controls
        private TextBox txtSearch;
        private ComboBox cmbCompanyFilter;
        private Button btnClearFilter;
        private Panel panel8;
        private Label label9;
        private Label label8;
        private Button btnLohout;
        private Button button2;
        private Button btnManageEmp;
        private Panel panel7;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private PictureBox chartSummary;
        private Button button4;
        private Button button3;
        private Label label12;
        private Label lblTotalResigned;
        private Label lblAttendanceLate;
        private Label lblAttentdancePresent;
        private Label label17;
        private Label label16;
        private Label lblRequestBenefit;
        private Label lblRequestLeave;
        private Label ll;
        private Label label20;
        private Panel pnlLoading;
        private Label lblLoading;
        private Button btnScanMonitor;
    }
}