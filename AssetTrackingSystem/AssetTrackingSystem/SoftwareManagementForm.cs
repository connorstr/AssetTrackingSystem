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
    }
}
