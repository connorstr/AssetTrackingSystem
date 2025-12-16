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
    public partial class SoftwareManagementForm : Form
    {
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

        private async void btnCheckVulnerabilities_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin)
                return;

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
                var results = await NvdApiClient.SearchVulnerabilities(osName, osVersion);

                if (results.Count == 0)
                {
                    MessageBox.Show("No high or critical vulnerabilities found.");
                    return;
                }

                new VulnerabilityResultsForm(results).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NVD lookup failed: " + ex.Message);
            }
        }
    }
}
