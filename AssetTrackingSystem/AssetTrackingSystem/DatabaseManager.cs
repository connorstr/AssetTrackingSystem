using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTrackingSystem
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = "server=lochnagar.abertay.ac.uk;user=sql2308259;password=already-patrol-finish-fight;database=sql2308259";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void AddAsset(Asset asset)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = "INSERT INTO assets (Name, Model, Manufacturer, Type, PurchaseDate, Note) VALUES (@Name, @Model, @Manufacturer, @Type, @PurchaseDate, @Note)";

            using MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", asset.Name);
            cmd.Parameters.AddWithValue("@Model", asset.Model);
            cmd.Parameters.AddWithValue("@Manufacturer", asset.Manufacturer);
            cmd.Parameters.AddWithValue("@Type", asset.Type);
            cmd.Parameters.AddWithValue("@PurchaseDate", asset.PurchaseDate);
            cmd.Parameters.AddWithValue("@Note", asset.Note);
            cmd.ExecuteNonQuery();

        }
    }
}
