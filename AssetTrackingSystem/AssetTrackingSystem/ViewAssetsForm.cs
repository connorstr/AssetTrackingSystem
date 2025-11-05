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
    public partial class ViewAssetsForm : Form
    {
        private DatabaseManager db;

        public ViewAssetsForm()
        {
            InitializeComponent();
            db = new DatabaseManager(); // initializes the database manager
            SetupListView(); // configures the ListView to display the assets
            LoadAssets(); // Loads the assets from the database to be put into the ListView
        }

        // sets up the columns and properties for the ListView
        private void SetupListView()
        {
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;

            listViewAssets.Columns.Add("AssetID", 50);
            listViewAssets.Columns.Add("Name", 50);
            listViewAssets.Columns.Add("Model", 50);
            listViewAssets.Columns.Add("Manufacturer", 50);
            listViewAssets.Columns.Add("Type", 50);
            listViewAssets.Columns.Add("Purchase Date", 50);
            listViewAssets.Columns.Add("Note", 100);
        }

        // Loads all the assets from the database into ListView
        private void LoadAssets()
        {
            listViewAssets.Items.Clear();

            try
            {
                string sql = "SELECT AssetID, Name, Model, Manufacturer, Type, PurchaseDate, Note FROM assets";
                DataTable dt = db.ExecuteSelect(sql);

                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row["AssetID"].ToString());
                    item.SubItems.Add(row["Name"].ToString());
                    item.SubItems.Add(row["Model"].ToString());
                    item.SubItems.Add(row["Manufacturer"].ToString());
                    item.SubItems.Add(row["Type"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["PurchaseDate"]).ToShortDateString());
                    item.SubItems.Add(row["Note"].ToString());
                    listViewAssets.Items.Add(item);
                }

                // Auto-size columns
                foreach (ColumnHeader col in listViewAssets.Columns)
                    col.Width = -2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assets: " + ex.Message);
            }
        }


        private void btnEditAsset_Click(object sender, EventArgs e)
        {
            if (listViewAssets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an asset to edit.");
                return;
            }

            // Get selected asset ID from database
            int assetId = int.Parse(listViewAssets.SelectedItems[0].SubItems[0].Text);

            // Fetch asset details from the database
            Asset assetToEdit = null;
            using var conn = db.GetConnection();
            conn.Open();
            string sql = "SELECT * FROM assets WHERE AssetID = @AssetID";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AssetID", assetId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                assetToEdit = new Asset
                {
                    AssetID = assetId,
                    Name = reader["Name"].ToString(),
                    Model = reader["Model"].ToString(),
                    Manufacturer = reader["Manufacturer"].ToString(),
                    Type = reader["Type"].ToString(),
                    PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"]),
                    Note = reader["Note"].ToString()
                };
            }

            if (assetToEdit != null)
            {
                EditAssetForm editForm = new EditAssetForm(assetToEdit);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAssets(); // Refresh the list after editing
                }
            }
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (listViewAssets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an asset to delete.");
                return;
            }

            // Get the selected AssetID
            int assetId = int.Parse(listViewAssets.SelectedItems[0].SubItems[0].Text);

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this asset?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.DeleteAsset(assetId);
                    MessageBox.Show("Asset deleted successfully!");
                    LoadAssets(); // Refresh the list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting asset: " + ex.Message);
                }
            }
        }

    }
}
