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
    public partial class LinkedAssetsForm : Form
    {
        public LinkedAssetsForm()
        {
            InitializeComponent();
            Setup();
            LoadLinks();
        }

        void Setup()
        {
            listViewLinks.Columns.Add("Hardware", 150);
            listViewLinks.Columns.Add("Model", 120);
            listViewLinks.Columns.Add("Manufacturer", 150);
            listViewLinks.Columns.Add("OS", 200);
            listViewLinks.Columns.Add("Version", 100);
        }

        void LoadLinks()
        {
            var db = new DatabaseManager();

            var data = db.GetLinkedAssets(
                Session.IsAdmin,
                Session.CurrentUser.EmployeeID
            );

            listViewLinks.Items.Clear();

            foreach (var item in data)
            {
                var row = new ListViewItem(item.HardwareName);

                row.SubItems.Add(item.Model);
                row.SubItems.Add(item.Manufacturer);
                row.SubItems.Add(item.OSName);
                row.SubItems.Add(item.OSVersion);

                listViewLinks.Items.Add(row);
            }
        }
    }
}
