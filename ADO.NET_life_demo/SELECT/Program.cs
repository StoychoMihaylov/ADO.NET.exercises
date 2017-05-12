using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELECT
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS; Database= SoftUni; Trusted_Connection=True";
            SqlConnection connetion = new SqlConnection(connectionString);
            connetion.Open();
            using (connetion)
            {
                string selectionCommandString = "SELECT * FROM Manafcheta";
                SqlCommand command = new SqlCommand(selectionCommandString, connetion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader[i]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
