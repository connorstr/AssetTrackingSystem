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
            btnEditAsset = new Button();
            btnDeleteAsset = new Button();
            SuspendLayout();
            // 
            // listViewAssets
            // 
            listViewAssets.Location = new Point(0, 48);
            listViewAssets.Name = "listViewAssets";
            listViewAssets.Size = new Size(800, 348);
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
            // btnEditAsset
            // 
            btnEditAsset.Font = new Font("Segoe UI", 15F);
            btnEditAsset.Location = new Point(244, 402);
            btnEditAsset.Name = "btnEditAsset";
            btnEditAsset.Size = new Size(134, 38);
            btnEditAsset.TabIndex = 2;
            btnEditAsset.Text = "Edit Asset";
            btnEditAsset.UseVisualStyleBackColor = true;
            btnEditAsset.Click += btnEditAsset_Click;
            // 
            // btnDeleteAsset
            // 
            btnDeleteAsset.Font = new Font("Segoe UI", 15F);
            btnDeleteAsset.Location = new Point(448, 402);
            btnDeleteAsset.Name = "btnDeleteAsset";
            btnDeleteAsset.Size = new Size(134, 38);
            btnDeleteAsset.TabIndex = 3;
            btnDeleteAsset.Text = "Delete Asset";
            btnDeleteAsset.UseVisualStyleBackColor = true;
            btnDeleteAsset.Click += btnDeleteAsset_Click;
            // 
            // ViewAssetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteAsset);
            Controls.Add(btnEditAsset);
            Controls.Add(lblAllAssets);
            Controls.Add(listViewAssets);
            Name = "ViewAssetsForm";
            Text = "ViewAssetsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewAssets;
        private Label lblAllAssets;
        private Button btnEditAsset;
        private Button btnDeleteAsset;
    }
}