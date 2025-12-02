using BCrypt.Net;
namespace AssetTrackingSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // attempts to connect to database, throws error if unsuccessful
            try
            {
                DatabaseManager dbTest = new();
                using var testConn = dbTest.GetConnection();
                testConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return;
            }


            // auto detects current machine and trys to add it to database
            try
            {
                DatabaseManager db = new();
                var hw = SystemInfoHelper.GetHardwareInfo();

                if (!db.HardwareExists(hw.SystemName))
                {
                    db.AddHardwareAsset(hw, null);
                    MessageBox.Show("This device has been automatically added to the asset database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auto-add failed: " + ex.Message);
            }
       

            string hash = BCrypt.Net.BCrypt.HashPassword("Test123!");

            // Application.Run(new EmployeeManagementForm());
            Application.Run(new LoginForm()); // starts the main login form
        }
    }
}