namespace AssetTrackingSystem
{
    partial class SoftwareManagementForm
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
            lblSoftwareAssets = new Label();
            listViewSoftware = new ListView();
            btnCheckVulnerabilities = new Button();
            btnEditSoftware = new Button();
            btnDeleteSoftware = new Button();
            SuspendLayout();
            // 
            // lblSoftwareAssets
            // 
            lblSoftwareAssets.Dock = DockStyle.Top;
            lblSoftwareAssets.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoftwareAssets.Location = new Point(0, 0);
            lblSoftwareAssets.Name = "lblSoftwareAssets";
            lblSoftwareAssets.Size = new Size(800, 45);
            lblSoftwareAssets.TabIndex = 2;
            lblSoftwareAssets.Text = "Software Assets";
            lblSoftwareAssets.TextAlign = ContentAlignment.TopCenter;
            // 
            // listViewSoftware
            // 
            listViewSoftware.FullRowSelect = true;
            listViewSoftware.GridLines = true;
            listViewSoftware.Location = new Point(0, 51);
            listViewSoftware.Name = "listViewSoftware";
            listViewSoftware.Size = new Size(800, 348);
            listViewSoftware.TabIndex = 3;
            listViewSoftware.UseCompatibleStateImageBehavior = false;
            listViewSoftware.View = View.Details;
            // 
            // btnCheckVulnerabilities
            // 
            btnCheckVulnerabilities.Location = new Point(597, 405);
            btnCheckVulnerabilities.Name = "btnCheckVulnerabilities";
            btnCheckVulnerabilities.Size = new Size(155, 33);
            btnCheckVulnerabilities.TabIndex = 4;
            btnCheckVulnerabilities.Text = "Check Vulnerabilities";
            btnCheckVulnerabilities.UseVisualStyleBackColor = true;
            btnCheckVulnerabilities.Click += btnCheckVulnerabilities_Click;
            // 
            // btnEditSoftware
            // 
            btnEditSoftware.Location = new Point(102, 415);
            btnEditSoftware.Name = "btnEditSoftware";
            btnEditSoftware.Size = new Size(75, 23);
            btnEditSoftware.TabIndex = 5;
            btnEditSoftware.Text = "Edit";
            btnEditSoftware.UseVisualStyleBackColor = true;
            btnEditSoftware.Click += btnEditSoftware_Click;
            // 
            // btnDeleteSoftware
            // 
            btnDeleteSoftware.Location = new Point(241, 416);
            btnDeleteSoftware.Name = "btnDeleteSoftware";
            btnDeleteSoftware.Size = new Size(75, 23);
            btnDeleteSoftware.TabIndex = 6;
            btnDeleteSoftware.Text = "Delete";
            btnDeleteSoftware.UseVisualStyleBackColor = true;
            btnDeleteSoftware.Click += btnDeleteSoftware_Click;
            // 
            // SoftwareManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteSoftware);
            Controls.Add(btnEditSoftware);
            Controls.Add(btnCheckVulnerabilities);
            Controls.Add(listViewSoftware);
            Controls.Add(lblSoftwareAssets);
            Name = "SoftwareManagementForm";
            Text = "SoftwareManagementForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSoftwareAssets;
        private ListView listViewSoftware;
        private Button btnCheckVulnerabilities;
        private Button btnEditSoftware;
        private Button btnDeleteSoftware;
    }
}