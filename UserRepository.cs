using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace CarParkingBooking
{
    public class UserRepository
    {
        SqlConnection connection;
        string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public int AddCustomer(string firstName, string lastName, string gender, long mobileNo,string address,  string mailId, string password)
        {
            string query = "spUSERDETAILS_INSERT";
            int rows;
            connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@fName";
                param.Value = firstName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@lName";
                param.Value = lastName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@gender";
                param.Value = gender;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mobileNo";
                param.Value = mobileNo;
                param.SqlDbType = System.Data.SqlDbType.BigInt;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@address";
                param.Value = address;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@emailid";
                param.Value = mailId;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            return rows;
        }
        public bool ValidateLogin(string username, string password)
        {
            bool isValue = false;
            string query = "spUSERDETAILS_SELECT";
            connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@emailId";
                param.Value = username;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);
                connection.Open();
                SqlDataReader data = command.ExecuteReader();
                if (data.HasRows)
                    isValue = true;
            }
            return isValue;
        }
    }
}