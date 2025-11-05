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
    public partial class EditEmployeeForm : Form
    {
        private Employee employee;
        private DatabaseManager db;

        public EditEmployeeForm(Employee employeeToEdit)
        {
            InitializeComponent();
            employee = employeeToEdit;
            db = new DatabaseManager();

            // fill text boxes with data of the employee the user clicks on to edit
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtEmail.Text = employee.Email;
        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.Email = txtEmail.Text;

                db.UpdateEmployee(employee);
                MessageBox.Show("Employee updated successfully!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }
    }
}

