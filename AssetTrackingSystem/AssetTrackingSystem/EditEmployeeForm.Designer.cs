namespace AssetTrackingSystem
{
    partial class EditEmployeeForm
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
            btnSaveEmployee = new Button();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblEmail = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            EditEmployeeDetails = new Label();
            SuspendLayout();
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Font = new Font("Segoe UI", 12F);
            btnSaveEmployee.Location = new Point(442, 190);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(131, 34);
            btnSaveEmployee.TabIndex = 38;
            btnSaveEmployee.Text = "Edit Employee";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(373, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 34;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(373, 107);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 33;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(373, 68);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 32;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15F);
            lblEmail.Location = new Point(295, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 15F);
            lblLastName.Location = new Point(251, 102);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(107, 28);
            lblLastName.TabIndex = 27;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 15F);
            lblFirstName.Location = new Point(248, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 26;
            lblFirstName.Text = "First Name:";
            // 
            // EditEmployeeDetails
            // 
            EditEmployeeDetails.Dock = DockStyle.Top;
            EditEmployeeDetails.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            EditEmployeeDetails.Location = new Point(0, 0);
            EditEmployeeDetails.Name = "EditEmployeeDetails";
            EditEmployeeDetails.Size = new Size(800, 45);
            EditEmployeeDetails.TabIndex = 39;
            EditEmployeeDetails.Text = "Edit Employee Details";
            EditEmployeeDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditEmployeeDetails);
            Controls.Add(btnSaveEmployee);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveEmployee;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblFirstName;
        private Label EditEmployeeDetails;
    }
}