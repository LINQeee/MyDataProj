using System;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace DataAppProj
{

    class MainService
    {
        static void Main()
        {
            DataBaseServices.Setup();
        using (SqlConnection connection = new SqlConnection(DataBaseServices.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("use mainData; insert into test (personId) values (11)", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
