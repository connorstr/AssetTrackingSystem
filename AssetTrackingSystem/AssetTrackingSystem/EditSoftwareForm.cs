using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetTrackingSystem
{
    public partial class EditSoftwareForm : Form
    {
        private SoftwareAsset software;
        private DatabaseManager db;

        public EditSoftwareForm(SoftwareAsset sw)
        {
            InitializeComponent();
            software = sw;
            db = new DatabaseManager();

            // Populate form fields
            txtOSName.Text = software.OSName;
            txtOSVersion.Text = software.OSVersion;
            txtOSManufacturer.Text = software.OSManufacturer;
            dtpDetectedDate.Value = software.DetectedDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Update software object
                software.OSName = txtOSName.Text;
                software.OSVersion = txtOSVersion.Text;
                software.OSManufacturer = txtOSManufacturer.Text;
                software.DetectedDate = dtpDetectedDate.Value;

                db.UpdateSoftware(software);

                MessageBox.Show("Software updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating software: " + ex.Message);
            }
        }
    }
}
