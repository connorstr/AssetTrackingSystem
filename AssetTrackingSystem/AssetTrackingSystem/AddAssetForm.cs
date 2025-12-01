using MySql.Data.MySqlClient;

namespace AssetTrackingSystem
{
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
            this.Load += AddAssetForm_Load;
        }
        private void AddAssetForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                using var conn = db.GetConnection();
                conn.Open();
                string sql = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM employees";
                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                var employees = new List<Employee>();
                while (reader.Read())
                {
                    employees.Add(new Employee
                    {
                        EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                        FirstName = reader["FullName"].ToString()
                    });
                }
                cmbEmployee.DataSource = employees;
                cmbEmployee.DisplayMember = "FirstName";
                cmbEmployee.ValueMember = "EmployeeID";
                cmbEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
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
                    Note = txtNote.Text,
                    IPAddress = txtIPAddress.Text,
                    EmployeeID = cmbEmployee.SelectedValue != null ? (int)cmbEmployee.SelectedValue : (int?)null
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
        // event handler for button to open employee management form
        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagementForm employeeForm = new EmployeeManagementForm();
            employeeForm.ShowDialog(); 
        }
    }
}
