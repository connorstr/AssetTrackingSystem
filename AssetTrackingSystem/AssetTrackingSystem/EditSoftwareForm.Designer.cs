namespace AssetTrackingSystem
{
    partial class EditSoftwareForm
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
            lblEditAsset = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOSManufacturer = new TextBox();
            txtOSVersion = new TextBox();
            txtOSName = new TextBox();
            dtpDetectedDate = new DateTimePicker();
            label4 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblEditAsset
            // 
            lblEditAsset.Dock = DockStyle.Top;
            lblEditAsset.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditAsset.Location = new Point(0, 0);
            lblEditAsset.Name = "lblEditAsset";
            lblEditAsset.Size = new Size(800, 59);
            lblEditAsset.TabIndex = 27;
            lblEditAsset.Text = "Edit Asset";
            lblEditAsset.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(183, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 28;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(183, 158);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 29;
            label2.Text = "Version:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(130, 207);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 30;
            label3.Text = "Manufacturer:";
            // 
            // txtOSManufacturer
            // 
            txtOSManufacturer.Location = new Point(282, 215);
            txtOSManufacturer.Name = "txtOSManufacturer";
            txtOSManufacturer.Size = new Size(200, 23);
            txtOSManufacturer.TabIndex = 31;
            // 
            // txtOSVersion
            // 
            txtOSVersion.Location = new Point(282, 166);
            txtOSVersion.Name = "txtOSVersion";
            txtOSVersion.Size = new Size(200, 23);
            txtOSVersion.TabIndex = 32;
            // 
            // txtOSName
            // 
            txtOSName.Location = new Point(282, 120);
            txtOSName.Name = "txtOSName";
            txtOSName.Size = new Size(200, 23);
            txtOSName.TabIndex = 33;
            // 
            // dtpDetectedDate
            // 
            dtpDetectedDate.Location = new Point(282, 262);
            dtpDetectedDate.Name = "dtpDetectedDate";
            dtpDetectedDate.Size = new Size(200, 23);
            dtpDetectedDate.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(122, 257);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 35;
            label4.Text = "Date Detected:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(282, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 25);
            btnSave.TabIndex = 36;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditSoftwareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dtpDetectedDate);
            Controls.Add(txtOSName);
            Controls.Add(txtOSVersion);
            Controls.Add(txtOSManufacturer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEditAsset);
            Name = "EditSoftwareForm";
            Text = "EditSoftwareForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditAsset;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOSManufacturer;
        private TextBox txtOSVersion;
        private TextBox txtOSName;
        private DateTimePicker dtpDetectedDate;
        private Label label4;
        private Button btnSave;
    }
}