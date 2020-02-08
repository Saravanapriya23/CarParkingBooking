using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CarParkingBooking
{
    public static class AdminRepository
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        static SqlConnection connection = connection = new SqlConnection(connectionString);
        public static DataTable ViewParkingSiteDetails()
        {
            string procedure = "sp_CARPARKINGSITEDETAILS_VIEW";
            DataTable table;
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            return table;
        }
        public static void DeleteParkingSiteDetails(int serialNo)
        {
            string procedure = "sp_CARPARKINGSITEDETAILS_DELETE";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@serialno", serialNo);
                connection.Open();
                int i = command.ExecuteNonQuery();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateParkingSiteDetails(int serialNo, string siteName,string location,string emailId,int parkingSlots)
        {
            string procedure = "sp_CARPARKINGSITEDETAILS_UPDATE";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@serialno", serialNo);
                command.Parameters.AddWithValue("@sitename", siteName);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@emailid", emailId);
                command.Parameters.AddWithValue("@parkingslots", parkingSlots);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void InsertParkingSiteDetails(string siteName, string location, string emailId, int parkingSlots)
        {
            string procedure = "spCARPARKINGSITEDETAILS_INSERT";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@sitename", siteName);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@emailid", emailId);
                command.Parameters.AddWithValue("@parkingslots", parkingSlots);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}