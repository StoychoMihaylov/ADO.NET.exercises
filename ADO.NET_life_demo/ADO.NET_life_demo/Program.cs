using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=.\\SQLEXPRESS; Database=SoftUni; Trusted_Connection= True";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        using (connection)
        {
            string selectionCommandString = "SELECT * FROM JudgeFails ";
            SqlCommand command = new SqlCommand(selectionCommandString, connection);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader[i]} ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            SqlDataReader Secondreader = command.ExecuteReader();
            using (Secondreader)
            {
                while (Secondreader.Read())
                {
                    for (int i = 0; i < Secondreader.FieldCount; i++)
                    {
                        Console.Write($"{Secondreader[i]} ");
                    }
                    Console.WriteLine();
                }
            }           
        }
    }
}

