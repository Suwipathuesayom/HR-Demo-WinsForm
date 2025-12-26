namespace hr_demo
{
    partial class PayRoll
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
            this.AutoScaleDimensions = new SizeF(13F, 13F);
            panel1 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            lblTitle = new Label();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtSearch = new TextBox();
            cmbEmployeeFilter = new ComboBox();
            btnClearFilter = new Button();
            dtgShowPayRoll = new DataGridView();
            btnViewSlip = new Button();
            btnEdit = new Button();
            btnSendSlip = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtBankNo = new TextBox();
            txtJobTitle = new TextBox();
            txtFullname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            txtOtSummary = new TextBox();
            txtAbsent = new TextBox();
            txtLate = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            txtStatulation = new TextBox();
            txtIncentive = new TextBox();
            txtBaseSalary = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowPayRoll).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1653, 57);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 11);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 4;
            label1.Text = "ระบบเงินเดือน (Payroll System)";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1547, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(17, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "A.I Technology";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1454, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(992, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 11;
            // 
            // cmbEmployeeFilter
            // 
            cmbEmployeeFilter.Location = new Point(1248, 63);
            cmbEmployeeFilter.Name = "cmbEmployeeFilter";
            cmbEmployeeFilter.Size = new Size(200, 28);
            cmbEmployeeFilter.TabIndex = 12;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(1551, 61);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(90, 30);
            btnClearFilter.TabIndex = 13;
            btnClearFilter.Text = "Clear";
            btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // dtgShowPayRoll
            // 
            dtgShowPayRoll.BackgroundColor = Color.Silver;
            dtgShowPayRoll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgShowPayRoll.Location = new Point(13, 106);
            dtgShowPayRoll.Name = "dtgShowPayRoll";
            dtgShowPayRoll.RowHeadersWidth = 51;
            dtgShowPayRoll.Size = new Size(1254, 708);
            dtgShowPayRoll.TabIndex = 16;
            // 
            // btnViewSlip
            // 
            btnViewSlip.Location = new Point(1529, 715);
            btnViewSlip.Name = "btnViewSlip";
            btnViewSlip.Size = new Size(112, 29);
            btnViewSlip.TabIndex = 17;
            btnViewSlip.Text = "View Slip";
            btnViewSlip.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1529, 750);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 29);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit Adjustment";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSendSlip
            // 
            btnSendSlip.Location = new Point(1529, 785);
            btnSendSlip.Name = "btnSendSlip";
            btnSendSlip.Size = new Size(112, 29);
            btnSendSlip.TabIndex = 19;
            btnSendSlip.Text = "Send Mail";
            btnSendSlip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1293, 719);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 20;
            label2.Text = "ดูสลิปเงินเดือน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1293, 762);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 21;
            label3.Text = "แก้ไข";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1293, 797);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 22;
            label4.Text = "ส่งสลิปเงินเดือน";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(txtBankNo);
            panel2.Controls.Add(txtJobTitle);
            panel2.Controls.Add(txtFullname);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(1293, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 199);
            panel2.TabIndex = 23;
            // 
            // txtBankNo
            // 
            txtBankNo.Location = new Point(118, 138);
            txtBankNo.Name = "txtBankNo";
            txtBankNo.Size = new Size(211, 27);
            txtBankNo.TabIndex = 6;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(119, 103);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(211, 27);
            txtJobTitle.TabIndex = 5;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(120, 67);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(211, 27);
            txtFullname.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 141);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 3;
            label10.Text = "Bank Info:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 106);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 2;
            label9.Text = "Job Title:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 67);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 1;
            label8.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(18, 27);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 0;
            label5.Text = "ข้อมูลสรุปพนักงาน";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(txtOtSummary);
            panel3.Controls.Add(txtAbsent);
            panel3.Controls.Add(txtLate);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(1293, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 167);
            panel3.TabIndex = 24;
            // 
            // txtOtSummary
            // 
            txtOtSummary.Location = new Point(130, 116);
            txtOtSummary.Name = "txtOtSummary";
            txtOtSummary.Size = new Size(196, 27);
            txtOtSummary.TabIndex = 9;
            // 
            // txtAbsent
            // 
            txtAbsent.Location = new Point(130, 80);
            txtAbsent.Name = "txtAbsent";
            txtAbsent.Size = new Size(196, 27);
            txtAbsent.TabIndex = 8;
            // 
            // txtLate
            // 
            txtLate.Location = new Point(131, 40);
            txtLate.Name = "txtLate";
            txtLate.Size = new Size(196, 27);
            txtLate.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 116);
            label13.Name = "label13";
            label13.Size = new Size(96, 20);
            label13.TabIndex = 4;
            label13.Text = "OT Summary:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 83);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 3;
            label12.Text = "ขาดงาน (Absent):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 43);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 2;
            label11.Text = "มาสาย (Late):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(13, 14);
            label6.Name = "label6";
            label6.Size = new Size(193, 23);
            label6.TabIndex = 1;
            label6.Text = "สถิติเวลาทำงานรายเดือน";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(txtStatulation);
            panel4.Controls.Add(txtIncentive);
            panel4.Controls.Add(txtBaseSalary);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(1293, 484);
            panel4.Name = "panel4";
            panel4.Size = new Size(348, 191);
            panel4.TabIndex = 25;
            // 
            // txtStatulation
            // 
            txtStatulation.Location = new Point(15, 145);
            txtStatulation.Name = "txtStatulation";
            txtStatulation.Size = new Size(309, 27);
            txtStatulation.TabIndex = 12;
            // 
            // txtIncentive
            // 
            txtIncentive.Location = new Point(117, 79);
            txtIncentive.Name = "txtIncentive";
            txtIncentive.Size = new Size(209, 27);
            txtIncentive.TabIndex = 11;
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.Location = new Point(115, 41);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(209, 27);
            txtBaseSalary.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(13, 122);
            label16.Name = "label16";
            label16.Size = new Size(161, 20);
            label16.TabIndex = 5;
            label16.Text = "Statutory Deductions: *";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 79);
            label15.Name = "label15";
            label15.Size = new Size(77, 20);
            label15.TabIndex = 4;
            label15.Text = "Incentives:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 41);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 3;
            label14.Text = "Base Salary:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(11, 11);
            label7.Name = "label7";
            label7.Size = new Size(242, 23);
            label7.TabIndex = 2;
            label7.Text = "รายละเอียดรายได้และรายการหัก";
            // 
            // PayRoll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSendSlip);
            Controls.Add(btnEdit);
            Controls.Add(btnViewSlip);
            Controls.Add(dtgShowPayRoll);
            Controls.Add(btnSearch);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSearch);
            Controls.Add(cmbEmployeeFilter);
            Controls.Add(btnClearFilter);
            Controls.Add(panel1);
            Name = "PayRoll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayRoll";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowPayRoll).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnBack;
        private Label lblTitle;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSearch;
        private ComboBox cmbEmployeeFilter;
        private Button btnClearFilter;
        private DataGridView dtgShowPayRoll;
        private Button btnViewSlip;
        private Button btnEdit;
        private Button btnSendSlip;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private Panel panel3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label6;
        private Panel panel4;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label7;
        private TextBox txtBankNo;
        private TextBox txtJobTitle;
        private TextBox txtFullname;
        private TextBox txtOtSummary;
        private TextBox txtAbsent;
        private TextBox txtLate;
        private TextBox txtStatulation;
        private TextBox txtIncentive;
        private TextBox txtBaseSalary;
    }
}