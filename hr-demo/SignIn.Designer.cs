namespace hr_demo
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            label5 = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblSignUp = new Label();
            btnRegister = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 217);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 21;
            label5.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 243);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 34);
            txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 168);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 34);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 142);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 290);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 22;
            label3.Text = "don’t have an account yet?";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = SystemColors.HotTrack;
            lblSignUp.Location = new Point(378, 290);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(57, 20);
            lblSignUp.TabIndex = 23;
            lblSignUp.Text = "SignUp";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ControlLight;
            btnRegister.Location = new Point(218, 331);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(194, 43);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "LogIn";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(255, 92);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 11;
            label1.Text = "Welcome Back!";
            // 
            // SignIn
            // 
            ClientSize = new Size(625, 501);
            Controls.Add(btnRegister);
            Controls.Add(lblSignUp);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private Label lblSignUp;
        private Button btnRegister;
        private Label label1;
    }
}
