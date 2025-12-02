namespace AssetTrackingSystem
{
    partial class EmployeeManagementForm
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
            listViewEmployees = new ListView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            btnAddEmployee = new Button();
            lblEmployeeManagement = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            btnDeleteEmployee = new Button();
            btnEditEmployee = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // listViewEmployees
            // 
            listViewEmployees.Location = new Point(385, 63);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(403, 315);
            listViewEmployees.TabIndex = 0;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(178, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(178, 155);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Segoe UI", 12F);
            btnAddEmployee.Location = new Point(214, 330);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(140, 34);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblEmployeeManagement
            // 
            lblEmployeeManagement.Dock = DockStyle.Top;
            lblEmployeeManagement.Font = new Font("Segoe UI", 25F);
            lblEmployeeManagement.Location = new Point(0, 0);
            lblEmployeeManagement.Name = "lblEmployeeManagement";
            lblEmployeeManagement.Size = new Size(800, 46);
            lblEmployeeManagement.TabIndex = 5;
            lblEmployeeManagement.Text = "Employee Management";
            lblEmployeeManagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 15F);
            lblFirstName.Location = new Point(40, 87);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 15F);
            lblLastName.Location = new Point(40, 150);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(107, 28);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15F);
            lblEmail.Location = new Point(84, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Font = new Font("Segoe UI", 12F);
            btnDeleteEmployee.Location = new Point(623, 406);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(150, 32);
            btnDeleteEmployee.TabIndex = 9;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Font = new Font("Segoe UI", 12F);
            btnEditEmployee.Location = new Point(437, 406);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(150, 32);
            btnEditEmployee.TabIndex = 10;
            btnEditEmployee.Text = "Edit Employee";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(53, 275);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 11;
            label1.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(178, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 23);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // EmployeeManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblEmployeeManagement);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(listViewEmployees);
            Name = "EmployeeManagementForm";
            Text = "EmployeeManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEmployees;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button btnAddEmployee;
        private Label lblEmployeeManagement;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Button btnDeleteEmployee;
        private Button btnEditEmployee;
        private Label label1;
        private TextBox txtPassword;
    }
}