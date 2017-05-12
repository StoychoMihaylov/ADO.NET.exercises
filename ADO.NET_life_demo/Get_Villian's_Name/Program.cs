using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Villian_s_Name
{
    class Program
    {
        static void Main()
        {
            string connectionString = "Server= .\\SQLEXPRESS; Database= MinionsDB; Trusted_Connection= True";
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();
                string connectionCommandString = "SELECT v.Name, COUNT(MinionID)AS[CountOfminnions] FROM Villians v\n" +
                                                 "JOIN MinionsVillians mv\n" +
                                                 "ON v.VillianID = mv.VilianID\n" +
                                                 "GROUP BY v.Name\n" +
                                                 "HAVING COUNT(MinionID) > 3\n" +
                                                 "ORDER BY CountOfminnions DESC";
                SqlCommand command = new SqlCommand(connectionCommandString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+ " "+reader[1]);
                }
            }
            Console.WriteLine();
        }
    }
}
