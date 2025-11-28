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
            txtIPAddress.Text = asset.IPAddress;
            LoadEmployees(asset.EmployeeID);
        }
        //loads the employees into combo box
        private void LoadEmployees(int? selectedEmployeeId = null)
        {
            try
            {
                using var conn = db.GetConnection();
                conn.Open();

                string sql = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM employees";
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
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
                if (selectedEmployeeId.HasValue)
                {
                    cmbEmployee.SelectedValue = selectedEmployeeId.Value;
                }
                else
                {
                    cmbEmployee.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
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
                asset.IPAddress = txtIPAddress.Text;
                asset.EmployeeID = cmbEmployee.SelectedValue != null ? (int)cmbEmployee.SelectedValue : (int?)null;

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
