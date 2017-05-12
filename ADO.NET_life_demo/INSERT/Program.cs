using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSERT
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectinString = "Server=.\\SQLEXPRESS; Database= SoftUni; Trusted_Connection= True";
            SqlConnection connection = new SqlConnection(connectinString);
            connection.Open();
            using (connection)
            {
                string insertCommandString = "INSERT INTO Manafcheta VALUES " +
                                             "('Piperoncheta', 450)," +
                                             "('Marmotcheta', 250)," +
                                             "('Ciceroncheta', 8324)";
                SqlCommand insertCommand = new SqlCommand(insertCommandString, connection);
                Console.WriteLine(insertCommand.ExecuteNonQuery());
            }

        }
    }
}
