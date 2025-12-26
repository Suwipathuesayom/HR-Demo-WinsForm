namespace hr_demo
{
    partial class TimeAttendance
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
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPresent = new TabPage();
            pnlLoading = new Panel();
            label2 = new Label();
            dtgShowLists = new DataGridView();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtSearch = new TextBox();
            cmbEmployeeFilter = new ComboBox();
            btnClearFilter = new Button();
            tablLate = new TabPage();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            button5 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            dtgShowLate = new DataGridView();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            tabOnLeave = new TabPage();
            tabAbsent = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPresent.SuspendLayout();
            pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowLists).BeginInit();
            tablLate.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowLate).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 11);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 4;
            label1.Text = "ระบบบันทึกเวลาและขาดลา";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1533, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
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
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1653, 783);
            panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPresent);
            tabControl1.Controls.Add(tablLate);
            tabControl1.Controls.Add(tabOnLeave);
            tabControl1.Controls.Add(tabAbsent);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1641, 780);
            tabControl1.TabIndex = 0;
            // 
            // tabPresent
            // 
            tabPresent.BackColor = Color.FromArgb(224, 224, 224);
            tabPresent.Controls.Add(pnlLoading);
            tabPresent.Controls.Add(dtgShowLists);
            tabPresent.Controls.Add(btnSearch);
            tabPresent.Controls.Add(dateTimePicker1);
            tabPresent.Controls.Add(txtSearch);
            tabPresent.Controls.Add(cmbEmployeeFilter);
            tabPresent.Controls.Add(btnClearFilter);
            tabPresent.ForeColor = SystemColors.HotTrack;
            tabPresent.Location = new Point(4, 29);
            tabPresent.Margin = new Padding(10);
            tabPresent.Name = "tabPresent";
            tabPresent.Padding = new Padding(5);
            tabPresent.RightToLeft = RightToLeft.No;
            tabPresent.Size = new Size(1633, 747);
            tabPresent.TabIndex = 0;
            tabPresent.Text = "มาทำงาน(Present)";
            // 
            // pnlLoading
            // 
            pnlLoading.Controls.Add(label2);
            pnlLoading.Location = new Point(682, 275);
            pnlLoading.Name = "pnlLoading";
            pnlLoading.Size = new Size(250, 125);
            pnlLoading.TabIndex = 12;
            pnlLoading.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(89, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 0;
            label2.Text = "Loading...";
            // 
            // dtgShowLists
            // 
            dtgShowLists.BackgroundColor = SystemColors.ButtonHighlight;
            dtgShowLists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgShowLists.Location = new Point(13, 58);
            dtgShowLists.Name = "dtgShowLists";
            dtgShowLists.RowHeadersWidth = 51;
            dtgShowLists.Size = new Size(1612, 671);
            dtgShowLists.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1438, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(976, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 6;
            // 
            // cmbEmployeeFilter
            // 
            cmbEmployeeFilter.Location = new Point(1232, 11);
            cmbEmployeeFilter.Name = "cmbEmployeeFilter";
            cmbEmployeeFilter.Size = new Size(200, 28);
            cmbEmployeeFilter.TabIndex = 7;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(1535, 9);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(90, 30);
            btnClearFilter.TabIndex = 8;
            btnClearFilter.Text = "Clear";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // tablLate
            // 
            tablLate.BackColor = Color.FromArgb(224, 224, 224);
            tablLate.Controls.Add(button2);
            tablLate.Controls.Add(label5);
            tablLate.Controls.Add(label4);
            tablLate.Controls.Add(button5);
            tablLate.Controls.Add(button4);
            tablLate.Controls.Add(panel3);
            tablLate.Controls.Add(dtgShowLate);
            tablLate.Controls.Add(button1);
            tablLate.Controls.Add(dateTimePicker2);
            tablLate.Controls.Add(textBox1);
            tablLate.Controls.Add(comboBox1);
            tablLate.Controls.Add(button3);
            tablLate.ForeColor = SystemColors.HotTrack;
            tablLate.Location = new Point(4, 29);
            tablLate.Margin = new Padding(10);
            tablLate.Name = "tablLate";
            tablLate.Padding = new Padding(5);
            tablLate.Size = new Size(1633, 747);
            tablLate.TabIndex = 1;
            tablLate.Text = "มาสาย(Late)";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1498, 10);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 0;
            button2.Text = "Export";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1346, 459);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 21;
            label5.Text = "กรณีที่พนักงานมีเหตุจำเป็น";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1346, 412);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 20;
            label4.Text = "Send Email : ";
            // 
            // button5
            // 
            button5.Location = new Point(1528, 459);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 19;
            button5.Text = "Approve Excuse";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1528, 412);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Send";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1265, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 316);
            panel3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = "Total Late Minutes:";
            // 
            // dtgShowLate
            // 
            dtgShowLate.BackgroundColor = SystemColors.ButtonHighlight;
            dtgShowLate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgShowLate.Location = new Point(15, 53);
            dtgShowLate.Name = "dtgShowLate";
            dtgShowLate.RowHeadersWidth = 51;
            dtgShowLate.Size = new Size(1230, 667);
            dtgShowLate.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(1055, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(593, 8);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 13);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search...";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(849, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(1152, 6);
            button3.Name = "button3";
            button3.Size = new Size(90, 30);
            button3.TabIndex = 13;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabOnLeave
            // 
            tabOnLeave.ForeColor = SystemColors.HotTrack;
            tabOnLeave.Location = new Point(4, 29);
            tabOnLeave.Margin = new Padding(10);
            tabOnLeave.Name = "tabOnLeave";
            tabOnLeave.Padding = new Padding(5);
            tabOnLeave.Size = new Size(1296, 649);
            tabOnLeave.TabIndex = 2;
            tabOnLeave.Text = "ลา";
            tabOnLeave.UseVisualStyleBackColor = true;
            // 
            // tabAbsent
            // 
            tabAbsent.ForeColor = SystemColors.HotTrack;
            tabAbsent.Location = new Point(4, 29);
            tabAbsent.Margin = new Padding(10);
            tabAbsent.Name = "tabAbsent";
            tabAbsent.Padding = new Padding(5);
            tabAbsent.Size = new Size(1296, 649);
            tabAbsent.TabIndex = 3;
            tabAbsent.Text = "ขาดงาน";
            tabAbsent.UseVisualStyleBackColor = true;
            // 
            // TimeAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TimeAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TimeAttendance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPresent.ResumeLayout(false);
            tabPresent.PerformLayout();
            pnlLoading.ResumeLayout(false);
            pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowLists).EndInit();
            tablLate.ResumeLayout(false);
            tablLate.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgShowLate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label lblTitle;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPresent;
        private TabPage tablLate;
        private TabPage tabOnLeave;
        private TabPage tabAbsent;
        private Button button2;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSearch;
        private ComboBox cmbEmployeeFilter;
        private Button btnClearFilter;
        private DataGridView dtgShowLists;
        private Panel pnlLoading;
        private Label label2;
        private DataGridView dtgShowLate;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button3;
        private Label label5;
        private Label label4;
        private Button button5;
        private Button button4;
        private Panel panel3;
        private Label label3;
    }
}