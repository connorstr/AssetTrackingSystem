namespace AssetTrackingSystem
{
    partial class AddAssetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtModel = new TextBox();
            txtManufacturer = new TextBox();
            txtType = new ComboBox();
            dtpPurchaseDate = new DateTimePicker();
            txtNote = new TextBox();
            btnAddAsset = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(268, 60);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Asset Name:";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 45);
            label2.TabIndex = 1;
            label2.Text = "Add New Asset";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(314, 99);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(254, 138);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 3;
            label4.Text = "Manufacturer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(330, 177);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 4;
            label5.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(248, 216);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 5;
            label6.Text = "Purchase Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(319, 255);
            label7.Name = "label7";
            label7.Size = new Size(68, 28);
            label7.TabIndex = 6;
            label7.Text = "Notes:";
            // 
            // txtName
            // 
            txtName.Location = new Point(393, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(393, 104);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 23);
            txtModel.TabIndex = 8;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(393, 143);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(200, 23);
            txtManufacturer.TabIndex = 9;
            // 
            // txtType
            // 
            txtType.FormattingEnabled = true;
            txtType.Items.AddRange(new object[] { "Laptop", "Desktop", "Printer", "Server", "Phone" });
            txtType.Location = new Point(393, 182);
            txtType.Name = "txtType";
            txtType.Size = new Size(200, 23);
            txtType.TabIndex = 10;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(393, 218);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(200, 23);
            dtpPurchaseDate.TabIndex = 11;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(393, 260);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(200, 60);
            txtNote.TabIndex = 12;
            // 
            // btnAddAsset
            // 
            btnAddAsset.Font = new Font("Segoe UI", 15F);
            btnAddAsset.Location = new Point(411, 344);
            btnAddAsset.Name = "btnAddAsset";
            btnAddAsset.Size = new Size(124, 36);
            btnAddAsset.TabIndex = 13;
            btnAddAsset.Text = "Add Asset";
            btnAddAsset.UseVisualStyleBackColor = true;
            btnAddAsset.Click += btnAddAsset_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(254, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 36);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // AddAssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAddAsset);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAssetForm";
            Text = "Asset Tracking System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtModel;
        private TextBox txtManufacturer;
        private ComboBox txtType;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtNote;
        private Button btnAddAsset;
        private Button btnClear;
    }
}
