namespace hr_demo
{
    partial class ScanMonitor
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
            lblStatus = new Label();
            dtgLoggerScan = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtIpAddress = new TextBox();
            txtPort = new TextBox();
            btnConnect = new Button();
            btnDisConnect = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgLoggerScan).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 16);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 4;
            label1.Text = "Scan Monitor (Real Time)";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1547, 12);
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
            // panel2
            // 
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(dtgLoggerScan);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtIpAddress);
            panel2.Controls.Add(txtPort);
            panel2.Controls.Add(btnConnect);
            panel2.Controls.Add(btnDisConnect);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1653, 783);
            panel2.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(77, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(82, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Disconnect";
            // 
            // dtgLoggerScan
            // 
            dtgLoggerScan.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtgLoggerScan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLoggerScan.Location = new Point(17, 69);
            dtgLoggerScan.Name = "dtgLoggerScan";
            dtgLoggerScan.ReadOnly = true;
            dtgLoggerScan.RowHeadersWidth = 51;
            dtgLoggerScan.Size = new Size(1620, 672);
            dtgLoggerScan.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 15);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "status :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 15);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "IP Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1104, 15);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Port :";
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(820, 17);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(261, 27);
            txtIpAddress.TabIndex = 3;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(1152, 16);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(231, 27);
            txtPort.TabIndex = 2;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 192, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(1403, 15);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(104, 29);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // btnDisConnect
            // 
            btnDisConnect.BackColor = Color.Red;
            btnDisConnect.ForeColor = Color.White;
            btnDisConnect.Location = new Point(1513, 15);
            btnDisConnect.Name = "btnDisConnect";
            btnDisConnect.Size = new Size(124, 29);
            btnDisConnect.TabIndex = 0;
            btnDisConnect.Text = "Disconnect";
            btnDisConnect.UseVisualStyleBackColor = false;
            btnDisConnect.Click += btnDisConnect_Click_1;
            // 
            // ScanMonitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ScanMonitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScanMonitor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgLoggerScan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnBack;
        private Label lblTitle;
        private Panel panel2;
        private Label label2;
        private TextBox txtIpAddress;
        private TextBox txtPort;
        private Button btnConnect;
        private Button btnDisConnect;
        private Label lblStatus;
        private DataGridView dtgLoggerScan;
        private Label label4;
        private Label label3;
    }
}