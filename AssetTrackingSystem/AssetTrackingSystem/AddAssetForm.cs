using MySql.Data.MySqlClient;

namespace AssetTrackingSystem
{
    /// <summary>
    /// Form is responsible for adding new assets into the system
    /// handles user input, access control for different user types and 
    /// database insertion.
    /// </summary>
    public partial class AddAssetForm : Form
    {
        public AddAssetForm()
        {
            InitializeComponent();
            this.Load += AddAssetForm_Load;
        }
        // runs when the form loads and applies access restrictions based on user type
        private void AddAssetForm_Load(object sender, EventArgs e)
        {
            // non admin users arent allowed to assign assets to other users
            if (!Session.IsAdmin)
            {
                cmbEmployee.Visible = false;
                lblAssignedEmployee.Visible = false;
            }

            // load employess for admin view
            LoadEmployees();
        }
        // loads employee data from database 
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
                    
                    // admins can assign assets to other employees, non admins have assets auto assigned to them
                    EmployeeID = Session.IsAdmin && cmbEmployee.SelectedValue != null
                            ? (int)cmbEmployee.SelectedValue
                            : Session.CurrentUser.EmployeeID
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
            if (!Session.IsAdmin)
            {
                MessageBox.Show("Only IT staff may manage employees.");
                return;
            }

            EmployeeManagementForm employeeForm = new();
            employeeForm.ShowDialog();
        }
        // opens software management form
        private void btnSoftware_Click(object sender, EventArgs e)
        {
            new SoftwareManagementForm().ShowDialog();
        }
        // opens loinked hardware/software view
        private void btnViewLinks_Click(object sender, EventArgs e)
        {
            new LinkedAssetsForm().ShowDialog();
        }
        // clears all inputs in forms
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtModel.Clear();
            txtManufacturer.Clear();
            txtType.Text = "";
            txtNote.Clear();
            txtIPAddress.Clear();

            // Reset date picker to today
            dtpPurchaseDate.Value = DateTime.Today;

            // Reset employee dropdown (Admin only)
            if (Session.IsAdmin && cmbEmployee.Visible)
            {
                cmbEmployee.SelectedIndex = -1;
            }

            // Put cursor back into first field for faster input
            txtName.Focus();
        }
    }
}