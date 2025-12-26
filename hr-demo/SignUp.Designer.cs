namespace hr_demo
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstname = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textLastname = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            lblSignUp = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(230, 35);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 0;
            label1.Text = "Register For System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 1;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 260);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(97, 130);
            txtFirstname.Multiline = true;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(200, 34);
            txtFirstname.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(346, 212);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ControlLight;
            btnRegister.Location = new Point(346, 370);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(194, 43);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(346, 104);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 7;
            label4.Text = "Lastname";
            // 
            // textLastname
            // 
            textLastname.Location = new Point(346, 130);
            textLastname.Multiline = true;
            textLastname.Name = "textLastname";
            textLastname.Size = new Size(200, 34);
            textLastname.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 286);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(443, 34);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(346, 186);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 186);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 12;
            label6.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 212);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 34);
            txtUsername.TabIndex = 11;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = SystemColors.HotTrack;
            lblSignUp.Location = new Point(374, 335);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(50, 20);
            lblSignUp.TabIndex = 25;
            lblSignUp.Text = "SignIn";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(193, 335);
            label7.Name = "label7";
            label7.Size = new Size(208, 20);
            label7.TabIndex = 24;
            label7.Text = "you already have an account? ";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 501);
            Controls.Add(lblSignUp);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(textLastname);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtFirstname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstname;
        private TextBox txtPassword;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textLastname;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private TextBox txtUsername;
        private Label lblSignUp;
        private Label label7;
    }
}
