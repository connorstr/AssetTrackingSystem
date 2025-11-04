namespace AssetTrackingSystem
{
    partial class ViewAssetsForm
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
            listViewAssets = new ListView();
            lblAllAssets = new Label();
            SuspendLayout();
            // 
            // listViewAssets
            // 
            listViewAssets.Location = new Point(0, 48);
            listViewAssets.Name = "listViewAssets";
            listViewAssets.Size = new Size(800, 406);
            listViewAssets.TabIndex = 0;
            listViewAssets.UseCompatibleStateImageBehavior = false;
            listViewAssets.View = View.Details;
            // 
            // lblAllAssets
            // 
            lblAllAssets.Dock = DockStyle.Top;
            lblAllAssets.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllAssets.Location = new Point(0, 0);
            lblAllAssets.Name = "lblAllAssets";
            lblAllAssets.Size = new Size(800, 45);
            lblAllAssets.TabIndex = 1;
            lblAllAssets.Text = "All Assets";
            lblAllAssets.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewAssetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAllAssets);
            Controls.Add(listViewAssets);
            Name = "ViewAssetsForm";
            Text = "ViewAssetsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAssets;
        private Label lblAllAssets;
    }
}