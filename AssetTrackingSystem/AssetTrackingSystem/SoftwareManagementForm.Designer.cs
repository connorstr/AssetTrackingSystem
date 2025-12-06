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
            // SoftwareManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewSoftware);
            Controls.Add(lblSoftwareAssets);
            Name = "SoftwareManagementForm";
            Text = "SoftwareManagementForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSoftwareAssets;
        private ListView listViewSoftware;
    }
}