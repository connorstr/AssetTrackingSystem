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
    public partial class EmployeeManagementForm : Form
    {
        private DatabaseManager db;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            db = new DatabaseManager();
            SetupListView();
            LoadDepartments();
            LoadEmployees();
        }

        private void SetupListView()
        {
            listViewEmployees.View = View.Details;
            listViewEmployees.FullRowSelect = true;
            listViewEmployees.GridLines = true;

            listViewEmployees.Columns.Add("ID", 50);
            listViewEmployees.Columns.Add("First Name", 100);
            listViewEmployees.Columns.Add("Last Name", 100);
            listViewEmployees.Columns.Add("Email", 150);
            listViewEmployees.Columns.Add("Department", 120);
        }
        // loads the listview of employees when form is open
        private void LoadEmployees()
        {
            listViewEmployees.Items.Clear();

            try
            {
                string sql = "SELECT EmployeeID, FirstName, LastName, Email, Department FROM employees";
                DataTable dt = db.ExecuteSelect(sql);

                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row["EmployeeID"].ToString());
                    item.SubItems.Add(row["FirstName"].ToString());
                    item.SubItems.Add(row["LastName"].ToString());
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["Department"].ToString());
                    listViewEmployees.Items.Add(item);
                }

                // Auto resize columns
                foreach (ColumnHeader col in listViewEmployees.Columns)
                    col.Width = -2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void LoadDepartments()
        {
            cmbDepartment.Items.Clear();

            cmbDepartment.Items.AddRange(new string[]
            {
                "IT",
                "Finance",
                "Human Resources",
                "Operations",
                "Sales"
            });

            cmbDepartment.SelectedIndex = 0; // Default to IT
        }

        // click event for adding new employee to database
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter a password for the employee.");
                    return;
                }

                Employee newEmp = new Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Department = cmbDepartment.SelectedItem.ToString()
                };

                db.AddEmployee(newEmp, txtPassword.Text);

                MessageBox.Show("Employee added successfully!");
                LoadEmployees();

                // Clear entry boxes
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            // checks if user has selected an employee to delete yet
            if (listViewEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete");
                return;
            }

            int employeeId = int.Parse(listViewEmployees.SelectedItems[0].SubItems[0].Text);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.DeleteEmployee(employeeId);
                    MessageBox.Show("Employee deleted successfully!");
                    LoadEmployees(); // refresh list with record now deleted
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message);
                }
            }
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to edit.");
                return;
            }
            int employeeId = int.Parse(listViewEmployees.SelectedItems[0].SubItems[0].Text);
            Employee employeeToEdit = null;

            using var conn = db.GetConnection();
            conn.Open();
            string sql = "SELECT * FROM employees WHERE EmployeeID = @EmployeeID";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                employeeToEdit = new Employee
                {
                    EmployeeID = employeeId,
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString()
                };
            }

            if (employeeToEdit != null)
            {
                EditEmployeeForm editForm = new EditEmployeeForm(employeeToEdit);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
        }
    }
}
