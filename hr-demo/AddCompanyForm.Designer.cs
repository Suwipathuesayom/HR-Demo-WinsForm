namespace hr_demo
{
    partial class AddCompanyForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCompanyName = new TextBox();
            txtIndustry = new TextBox();
            txtWebsite = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Company";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 95);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 95);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Industry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 211);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Website";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(63, 136);
            txtCompanyName.Multiline = true;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(215, 36);
            txtCompanyName.TabIndex = 4;
            // 
            // txtIndustry
            // 
            txtIndustry.Location = new Point(337, 136);
            txtIndustry.Multiline = true;
            txtIndustry.Name = "txtIndustry";
            txtIndustry.Size = new Size(224, 36);
            txtIndustry.TabIndex = 5;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(63, 234);
            txtWebsite.Multiline = true;
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(215, 34);
            txtWebsite.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(491, 371);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddCompanyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(button1);
            Controls.Add(txtWebsite);
            Controls.Add(txtIndustry);
            Controls.Add(txtCompanyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCompanyForm";
            Text = "AddCompanyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCompanyName;
        private TextBox txtIndustry;
        private TextBox txtWebsite;
        private Button button1;
    }
}