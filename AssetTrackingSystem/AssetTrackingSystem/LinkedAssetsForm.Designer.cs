namespace AssetTrackingSystem
{
    partial class LinkedAssetsForm
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
            listViewLinks = new ListView();
            lblLinkedAssets = new Label();
            SuspendLayout();
            // 
            // listViewLinks
            // 
            listViewLinks.FullRowSelect = true;
            listViewLinks.Location = new Point(0, 51);
            listViewLinks.Name = "listViewLinks";
            listViewLinks.Size = new Size(800, 348);
            listViewLinks.TabIndex = 1;
            listViewLinks.UseCompatibleStateImageBehavior = false;
            listViewLinks.View = View.Details;
            // 
            // lblLinkedAssets
            // 
            lblLinkedAssets.Dock = DockStyle.Top;
            lblLinkedAssets.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLinkedAssets.Location = new Point(0, 0);
            lblLinkedAssets.Name = "lblLinkedAssets";
            lblLinkedAssets.Size = new Size(800, 45);
            lblLinkedAssets.TabIndex = 2;
            lblLinkedAssets.Text = "Linked Assets";
            lblLinkedAssets.TextAlign = ContentAlignment.TopCenter;
            // 
            // LinkedAssetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLinkedAssets);
            Controls.Add(listViewLinks);
            Name = "LinkedAssetsForm";
            Text = "LinkedAssetsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewLinks;
        private Label lblLinkedAssets;
    }
}