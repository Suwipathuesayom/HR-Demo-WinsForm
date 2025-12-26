namespace hr_demo
{
    partial class UpdateCustomerForm
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
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            txtUpdate = new Button();
            label4 = new Label();
            txtIdRead = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Update Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 102);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(332, 102);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 37);
            txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 174);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(332, 174);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 34);
            txtLastName.TabIndex = 4;
            // 
            // txtUpdate
            // 
            txtUpdate.Location = new Point(553, 357);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(169, 41);
            txtUpdate.TabIndex = 5;
            txtUpdate.Text = "Update";
            txtUpdate.UseVisualStyleBackColor = true;
            txtUpdate.Click += txtUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 32);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 6;
            label4.Text = "ID :";
            // 
            // txtIdRead
            // 
            txtIdRead.Location = new Point(238, 31);
            txtIdRead.Name = "txtIdRead";
            txtIdRead.ReadOnly = true;
            txtIdRead.Size = new Size(125, 27);
            txtIdRead.TabIndex = 7;
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(txtIdRead);
            Controls.Add(label4);
            Controls.Add(txtUpdate);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Button txtUpdate;
        private Label label4;
        private TextBox txtIdRead;
    }
}