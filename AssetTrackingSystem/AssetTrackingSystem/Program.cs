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
                DatabaseManager db = new();
                using var conn = db.GetConnection();
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return;
            }

            Application.Run(new AddAssetForm()); // starts the main add asset form
        }
    }
}