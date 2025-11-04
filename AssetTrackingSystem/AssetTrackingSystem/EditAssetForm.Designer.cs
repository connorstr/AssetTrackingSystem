namespace AssetTrackingSystem
{
    partial class EditAssetForm
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
            txtNote = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            txtType = new ComboBox();
            txtManufacturer = new TextBox();
            txtModel = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnSave = new Button();
            lblEditAsset = new Label();
            SuspendLayout();
            // 
            // txtNote
            // 
            txtNote.Location = new Point(373, 295);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 60);
            txtNote.TabIndex = 24;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(373, 253);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(200, 23);
            dtpPurchaseDate.TabIndex = 23;
            // 
            // txtType
            // 
            txtType.FormattingEnabled = true;
            txtType.Items.AddRange(new object[] { "Laptop", "Desktop", "Printer", "Server", "Phone" });
            txtType.Location = new Point(373, 217);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 23);
            txtType.TabIndex = 22;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(373, 178);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(200, 23);
            txtManufacturer.TabIndex = 21;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(373, 139);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(373, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(299, 290);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 18;
            label7.Text = "Notes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(228, 251);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 17;
            label6.Text = "Purchase Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(310, 212);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 16;
            label5.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(234, 173);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 15;
            label4.Text = "Manufacturer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(294, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 14;
            label3.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(248, 95);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 13;
            label1.Text = "Asset Name:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(393, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 44);
            btnSave.TabIndex = 25;
            btnSave.Text = "Edit Asset";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblEditAsset
            // 
            lblEditAsset.Dock = DockStyle.Top;
            lblEditAsset.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditAsset.Location = new Point(0, 0);
            lblEditAsset.Name = "lblEditAsset";
            lblEditAsset.Size = new Size(800, 59);
            lblEditAsset.TabIndex = 26;
            lblEditAsset.Text = "EditAsset";
            lblEditAsset.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditAssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEditAsset);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(txtType);
            Controls.Add(txtManufacturer);
            Controls.Add(txtModel);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EditAssetForm";
            Text = "EditAssetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNote;
        private DateTimePicker dtpPurchaseDate;
        private ComboBox txtType;
        private TextBox txtManufacturer;
        private TextBox txtModel;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnSave;
        private Label lblEditAsset;
    }
}