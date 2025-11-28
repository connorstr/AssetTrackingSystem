using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    // Connects the app to database and handles adding assets to it
    public class DatabaseManager
    {
        private string connectionString;

        // sets up the database connection string details
        public DatabaseManager()
        {
            connectionString = "server=lochnagar.abertay.ac.uk;user=sql2308259;password=already-patrol-finish-fight;database=sql2308259";
        }

        // returns a new MYSQL connection object
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // adds a new record to the database
        public void AddAsset(Asset asset)
        {
            using var conn = GetConnection();
            conn.Open();

            // SQL command to insert correct values into table
            string sql = @"INSERT INTO assets (Name, Model, Manufacturer, Type, PurchaseDate, Note, EmployeeID, IPAddress) VALUES (@Name, @Model, @Manufacturer, @Type, @PurchaseDate, @Note, @EmployeeID, @IPAddress)";

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", asset.Name);
            cmd.Parameters.AddWithValue("@Model", asset.Model);
            cmd.Parameters.AddWithValue("@Manufacturer", asset.Manufacturer);
            cmd.Parameters.AddWithValue("@Type", asset.Type);
            cmd.Parameters.AddWithValue("@PurchaseDate", asset.PurchaseDate);
            cmd.Parameters.AddWithValue("@Note", asset.Note);
            cmd.Parameters.AddWithValue("@EmployeeID", asset.EmployeeID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IPAddress", asset.IPAddress);
            cmd.ExecuteNonQuery();
        }

        // updates the existing record with new one input by user
        public void UpdateAsset(Asset asset)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = @"UPDATE assets 
                   SET Name = @Name, 
                       Model = @Model, 
                       Manufacturer = @Manufacturer, 
                       Type = @Type, 
                       PurchaseDate = @PurchaseDate, 
                       Note = @Note,
                       EmployeeID = @EmployeeID
                       IPAddress = @IPAddress
                   WHERE AssetID = @AssetID";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", asset.Name);
            cmd.Parameters.AddWithValue("@Model", asset.Model);
            cmd.Parameters.AddWithValue("@Manufacturer", asset.Manufacturer);
            cmd.Parameters.AddWithValue("@Type", asset.Type);
            cmd.Parameters.AddWithValue("@PurchaseDate", asset.PurchaseDate);
            cmd.Parameters.AddWithValue("@Note", asset.Note);
            cmd.Parameters.AddWithValue("@EmployeeID", asset.EmployeeID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IPAddress", asset.IPAddress);
            cmd.Parameters.AddWithValue("@AssetID", asset.AssetID);

            cmd.ExecuteNonQuery();
        }

        public void DeleteAsset(int assetId)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = "DELETE FROM assets WHERE AssetID = @AssetID";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@AssetID", assetId);
            cmd.ExecuteNonQuery();
        }


        public void AddEmployee(Employee employee)
        {
            using var conn = GetConnection();
            conn.Open();

            // SQL command to insert correct values into employees table
            string sql = "INSERT INTO employees (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.ExecuteNonQuery();
        }
        public void UpdateEmployee(Employee employee)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = @"UPDATE employees 
                   SET FirstName = @FirstName, 
                       LastName = @LastName, 
                       Email = @Email 
                   WHERE EmployeeID = @EmployeeID";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmd.Parameters.AddWithValue("@LastName", employee.LastName);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteEmployee(int employeeId)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = "DELETE FROM employees WHERE EmployeeID = @EmployeeID";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.ExecuteNonQuery();
        }


        public DataTable ExecuteSelect(string sql)
        {
            using var conn = GetConnection();
            conn.Open();

            using var cmd = new MySqlCommand(sql, conn);
            using var adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


    }
}
