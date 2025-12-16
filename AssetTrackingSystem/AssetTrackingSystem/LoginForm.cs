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
    /// <summary>
    /// main form used for users to log in and 
    /// manages the auto detection of hardware upon login
    /// </summary>
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
            // basic validation
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Enter email and password.";
                return;
            }

            try
            {
                DatabaseManager db = new DatabaseManager();
                // authenticate user
                var loggedUser = db.Authenticate(email, password);

                if (loggedUser == null)
                {
                    lblError.Text = "Invalid email or password.";
                    return;
                }

                // stores logged in user
                Session.CurrentUser = loggedUser;

                // does silent scan and linking of assets
                AutoScanAndLinkAssets(db);

                // continues to main app
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
        // attempts to auto detect users hardware and software and links said assets
        private void AutoScanAndLinkAssets(DatabaseManager db)
        {
            try
            {
                var hw = SystemInfoHelper.GetHardwareInfo();

                if (!db.HardwareExists(hw.SystemName))
                {
                    db.AddHardwareAsset(hw, Session.CurrentUser.EmployeeID);
                }

                // Get the hardware ID
                var hwId = db.GetHardwareIdByName(hw.SystemName);

                if (!hwId.HasValue)
                    return;

                var sw = SystemInfoHelper.GetSoftwareAsset();

                int softwareId = db.AddSoftwareAsset(sw);

                db.LinkSoftwareToHardware(hwId.Value, softwareId);
            }
            catch
            {
                // silently ignore failures login must always go thru
            }
        }
    }
}