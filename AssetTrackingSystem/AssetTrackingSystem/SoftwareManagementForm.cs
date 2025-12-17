using MySqlX.XDevAPI.Common;
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
    /// <summary>
    /// form used for displaying list view of software assets from database
    /// admin users have ability to scan for vulnerabilities against the NVD database
    /// </summary>
    public partial class SoftwareManagementForm : Form
    {
        private bool isScanning = false;
        private DatabaseManager db = new DatabaseManager();

        public SoftwareManagementForm()
        {
            InitializeComponent();
            SetupListView();
            LoadSoftware();
        }

        private void SoftwareManagementForm_Load(object sender, EventArgs e)
        {
            btnCheckVulnerabilities.Visible = Session.IsAdmin;
        }
        // sets up the list view columns and names
        private void SetupListView()
        {
            listViewSoftware.View = View.Details;
            listViewSoftware.FullRowSelect = true;
            listViewSoftware.GridLines = true;

            listViewSoftware.Columns.Add("ID", 60);
            listViewSoftware.Columns.Add("OS Name", 150);
            listViewSoftware.Columns.Add("Version", 100);
            listViewSoftware.Columns.Add("Manufacturer", 150);
            listViewSoftware.Columns.Add("Detected Date", 120);
        }
        // populates the list view with software details from database
        private void LoadSoftware()
        {
            listViewSoftware.Items.Clear();

            var db = new DatabaseManager();

            var software = db.GetAllSoftware();

            foreach (var s in software)
            {
                var item = new ListViewItem(s.SoftwareID.ToString());

                item.SubItems.Add(s.OSName);
                item.SubItems.Add(s.OSVersion);
                item.SubItems.Add(s.OSManufacturer);
                item.SubItems.Add(s.DetectedDate.ToShortDateString());

                listViewSoftware.Items.Add(item);
            }
        }
        // button used to scan for vulnerabilities, 
        private async void btnCheckVulnerabilities_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin)
            {
                MessageBox.Show("Admin access required.");
                return;
            }

            if (listViewSoftware.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select software first.");
                return;
            }

            var item = listViewSoftware.SelectedItems[0];
            string osName = item.SubItems[1].Text;
            string osVersion = item.SubItems[2].Text;

            try
            {
                btnCheckVulnerabilities.Enabled = false;
                btnCheckVulnerabilities.Text = "Scanning...";

                var results = await NvdApiClient.SearchVulnerabilities(osName, osVersion);

                if (results == null || results.Count == 0)
                {
                    MessageBox.Show(
                        "No HIGH or CRITICAL vulnerabilities were found for this software.",
                        "Scan Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                using (var form = new VulnerabilityResultsForm(results))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NVD lookup failed:\n" + ex.Message);
            }
            finally
            {
                btnCheckVulnerabilities.Enabled = true;
                btnCheckVulnerabilities.Text = "Check Vulnerabilities";
            }
        }
        // button used to bring up the edit software form
        private void btnEditSoftware_Click(object sender, EventArgs e)
        {
            if (listViewSoftware.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select software to edit.");
                return;
            }

            var item = listViewSoftware.SelectedItems[0];
            int softwareId = int.Parse(item.SubItems[0].Text);

            var sw = db.GetAllSoftware().FirstOrDefault(s => s.SoftwareID == softwareId);
            if (sw == null) return;

            EditSoftwareForm editForm = new EditSoftwareForm(sw);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadSoftware(); // refresh the list
            }
        }
        // button for deleting software entities from database
        private void btnDeleteSoftware_Click(object sender, EventArgs e)
        {
            if (listViewSoftware.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select software to delete.");
                return;
            }

            int softwareId = int.Parse(listViewSoftware.SelectedItems[0].SubItems[0].Text);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this software? Any linked hardware associations will also be removed.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.DeleteSoftware(softwareId);
                    MessageBox.Show("Software deleted successfully!");
                    LoadSoftware(); // Refresh list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting software: " + ex.Message);
                }
            }
        }

    }
}
