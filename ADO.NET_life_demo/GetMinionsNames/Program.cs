using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server= .\\SQLEXPRESS; Database= MinionsDB; Trusted_Connection= True";
            SqlConnection connection = new SqlConnection(connectionString);

            int id = int.Parse(Console.ReadLine());
            string villianNameSQL = "SELECT Name FROM Villians WHERE villianID = @villianID";
            SqlCommand cmd = new SqlCommand(villianNameSQL, connection);
            cmd.Parameters.AddWithValue("@villianId", id);
            connection.Open();
            using (connection)
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (!reader.HasRows)
                {
                    Console.WriteLine("No villian with ID "+ id + "exist");
                    return;
                }

                reader.Read();
                string villianName = reader[0].ToString();
                Console.WriteLine("Villian: "+ villianName);
            }

            connection.Open();
           
                string minionsSQL = "SELECT m.Name, m.Age FROM Minions m\n" +
                                    "JOIN MinionsVillians mv\n" +
                                    "ON m.MinionID = mv.MinionID\n" +
                                    "JOIN Villians v\n" +
                                    "ON v.VillianID = mv.VilianID\n" +
                                    "WHERE v.VillianID = @villianID\n";
                cmd = new SqlCommand(minionsSQL, connection);
                cmd.Parameters.AddWithValue("@villianID", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("<no minions>");
                        return;
                    }

                    int counter = 1;
                    while (reader.Read())
                    {
                        Console.WriteLine(counter + " " + reader["name"] + " " + reader["age"]);
                        counter++;
                    }
                }

            
        }
    }
}
