namespace AssetTrackingSystem
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
        }

        // event handler for the add asset button press
        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            try
            {
                // takes user input and creates new asset for table
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
                db.AddAsset(newAsset); // adding asset to table

                MessageBox.Show("Asset added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding asset: " + ex.Message);
            }
        }

        // event handler for the button to swap to the view asset form
        private void btnViewAssets_Click(object sender, EventArgs e)
        {
            ViewAssetsForm viewForm = new ViewAssetsForm();
            viewForm.ShowDialog();
        }


    }
}
