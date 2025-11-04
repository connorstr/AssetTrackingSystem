using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssetTrackingSystem
{
    public partial class EditAssetForm : Form
    {
        private Asset asset;
        private DatabaseManager db;

        public EditAssetForm(Asset assetToEdit)
        {
            InitializeComponent();
            asset = assetToEdit;
            db = new DatabaseManager();

            // Populate the form fields with current asset data so user knows what is being changed
            txtName.Text = asset.Name;
            txtModel.Text = asset.Model;
            txtManufacturer.Text = asset.Manufacturer;
            txtType.Text = asset.Type;
            dtpPurchaseDate.Value = asset.PurchaseDate;
            txtNote.Text = asset.Note;
        }

        // Event handler for Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Update asset object with new values from the edit form
                asset.Name = txtName.Text;
                asset.Model = txtModel.Text;
                asset.Manufacturer = txtManufacturer.Text;
                asset.Type = txtType.Text;
                asset.PurchaseDate = dtpPurchaseDate.Value;
                asset.Note = txtNote.Text;

                // Save changes to the database
                db.UpdateAsset(asset);

                MessageBox.Show("Asset updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating asset: " + ex.Message);
            }
        }
    }
}
