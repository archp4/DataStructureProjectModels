using System.Data.SqlClient;

namespace DataStructureProjectModels.Models.Database
{
    internal class TouristSystemDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=Ninja-LOQ\\SQLEXPRESS01;Initial Catalog=TouristSystem;Integrated Security=True;";

            // If using App.Config
            // string connectionString = ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
