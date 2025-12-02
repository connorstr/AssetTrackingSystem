using MySqlX.XDevAPI;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Enter email and password.";
                return;
            }

            try
            {
                DatabaseManager db = new DatabaseManager();
                var loggedUser = db.Authenticate(email, password);

                if (loggedUser == null)
                {
                    lblError.Text = "Invalid email or password.";
                    return;
                }

                Session.CurrentUser = loggedUser;

                this.Hide();
                var main = new AddAssetForm();
                main.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }
    }
}
