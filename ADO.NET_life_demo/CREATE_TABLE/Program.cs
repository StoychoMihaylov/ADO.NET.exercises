using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREATE_TABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database= SoftUni; Trusted_Connection= True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using (connection)
            {
                string creationommandString = "CREATE TABLE Manafcheta " +
                                              "(" +
                                              "Name nvarchar(50), " +
                                              "NumberOfManafcheta int" +
                                              ")";
                SqlCommand createCommand = new SqlCommand(creationommandString, connection);
                createCommand.ExecuteNonQuery();
            }
        }
    }
}
