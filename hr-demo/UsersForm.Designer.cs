namespace hr_demo
{
    partial class UsersForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataListShowCustomer = new DataGridView();
            label2 = new Label();
            txtTotal = new TextBox();
            btnAddCompany = new Button();
            ((System.ComponentModel.ISupportInitialize)dataListShowCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 0;
            label1.Text = "User List";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1449, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1549, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataListShowCustomer
            // 
            dataListShowCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataListShowCustomer.Location = new Point(36, 97);
            dataListShowCustomer.Name = "dataListShowCustomer";
            dataListShowCustomer.RowHeadersWidth = 51;
            dataListShowCustomer.Size = new Size(1605, 690);
            dataListShowCustomer.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 796);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(83, 793);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "0";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 6;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(144, 54);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(152, 29);
            btnAddCompany.TabIndex = 7;
            btnAddCompany.Text = "Add Company";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 840);
            Controls.Add(btnAddCompany);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(dataListShowCustomer);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)dataListShowCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataListShowCustomer;
        private Label label2;
        private TextBox txtTotal;
        private Button btnAddCompany;
    }
}