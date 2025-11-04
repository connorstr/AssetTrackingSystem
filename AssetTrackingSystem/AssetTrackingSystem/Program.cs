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

            try
            {
                DatabaseManager db = new();
                using var conn = db.GetConnection();
                conn.Open();
                MessageBox.Show("Connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return;
            }

            Application.Run(new AddAssetForm());
        }
    }
}