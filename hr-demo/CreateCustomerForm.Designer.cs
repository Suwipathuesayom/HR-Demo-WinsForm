namespace hr_demo
{
    partial class CreateCustomerForm
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtStreet = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtIndusty = new TextBox();
            txtWebsite = new TextBox();
            label11 = new Label();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtPastalCode = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtSelectCompanies = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 18);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(189, 155);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(165, 34);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(514, 158);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 34);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 213);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(165, 34);
            txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(514, 213);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(176, 34);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(186, 327);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(501, 33);
            txtStreet.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(55, 155);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 213);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 280);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 155);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 10;
            label5.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 213);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(728, 158);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 12;
            label7.Text = "Company Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1417, 775);
            button1.Name = "button1";
            button1.Size = new Size(172, 44);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(728, 105);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 14;
            label8.Text = "Company";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(54, 105);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 15;
            label9.Text = "Customer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1065, 158);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 16;
            label10.Text = "Industy";
            // 
            // txtIndusty
            // 
            txtIndusty.Location = new Point(1142, 158);
            txtIndusty.Multiline = true;
            txtIndusty.Name = "txtIndusty";
            txtIndusty.Size = new Size(221, 34);
            txtIndusty.TabIndex = 17;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(862, 214);
            txtWebsite.Multiline = true;
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(501, 65);
            txtWebsite.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(728, 217);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 19;
            label11.Text = "Website";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(186, 389);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(501, 34);
            txtCity.TabIndex = 20;
            // 
            // txtState
            // 
            txtState.Location = new Point(186, 463);
            txtState.Multiline = true;
            txtState.Name = "txtState";
            txtState.Size = new Size(165, 34);
            txtState.TabIndex = 21;
            // 
            // txtPastalCode
            // 
            txtPastalCode.Location = new Point(466, 465);
            txtPastalCode.Multiline = true;
            txtPastalCode.Name = "txtPastalCode";
            txtPastalCode.Size = new Size(221, 34);
            txtPastalCode.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(64, 330);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 23;
            label12.Text = "Street";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(66, 390);
            label13.Name = "label13";
            label13.Size = new Size(32, 20);
            label13.TabIndex = 24;
            label13.Text = "city";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(64, 463);
            label14.Name = "label14";
            label14.Size = new Size(43, 20);
            label14.TabIndex = 25;
            label14.Text = "State";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(373, 466);
            label15.Name = "label15";
            label15.Size = new Size(87, 20);
            label15.TabIndex = 26;
            label15.Text = "Postal Code";
            // 
            // txtSelectCompanies
            // 
            txtSelectCompanies.FormattingEnabled = true;
            txtSelectCompanies.Location = new Point(863, 153);
            txtSelectCompanies.Name = "txtSelectCompanies";
            txtSelectCompanies.Size = new Size(151, 28);
            txtSelectCompanies.TabIndex = 27;
            // 
            // CreateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(txtSelectCompanies);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtPastalCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(label11);
            Controls.Add(txtWebsite);
            Controls.Add(txtIndusty);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStreet);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "CreateCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtStreet;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtIndusty;
        private TextBox txtWebsite;
        private Label label11;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtPastalCode;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox txtSelectCompanies;
    }
}