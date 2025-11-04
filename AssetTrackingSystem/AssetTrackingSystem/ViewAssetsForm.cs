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

            using var conn = db.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT AssetID, Name, Model, Manufacturer, Type, PurchaseDate, Note FROM assets";
                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Creates an Item for each asset
                    ListViewItem item = new ListViewItem(reader["AssetID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Model"].ToString());
                    item.SubItems.Add(reader["Manufacturer"].ToString());
                    item.SubItems.Add(reader["Type"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["PurchaseDate"]).ToShortDateString());
                    item.SubItems.Add(reader["Note"].ToString());

                    listViewAssets.Items.Add(item);
                }

                // Auto sizes the columns to fit different sizes
                for (int i = 0; i < listViewAssets.Columns.Count; i++)
                {
                    listViewAssets.Columns[i].Width = -2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assets: " + ex.Message);
            }
        }
    }
}
