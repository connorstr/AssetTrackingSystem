namespace AssetTrackingSystem
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                Asset newAsset = new Asset
                {
                    Name = txtName.Text,
                    Model = txtModel.Text,
                    Manufacturer = txtManufacturer.Text,
                    Type = txtType.Text,
                    PurchaseDate = dtpPurchaseDate.Value,
                    Note = txtNote.Text
                };

                DatabaseManager db = new DatabaseManager();
                db.AddAsset(newAsset);

                MessageBox.Show("Asset added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding asset: " + ex.Message);
            }
        }
    }
}
