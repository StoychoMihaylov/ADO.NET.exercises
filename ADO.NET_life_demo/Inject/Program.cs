using System;
using System.Data;
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
            Selecting("Judge RIP", connection);
        }
    }
   
    static void Selecting(string nameOfFail, SqlConnection connection)
    {
        string selectionCommandString = $"SELECT * FROM JudgeFails WHERE NameOfFail = @name";
        SqlCommand command = new SqlCommand(selectionCommandString, connection);
        //command.Parameters.AddWithValue("@name", nameOfFail); this's first way to define parameter
        SqlParameter parameter = new SqlParameter("@name", SqlDbType.VarChar, 50); //dis second way to difine parameter with exact Valude
        parameter.Value = nameOfFail;
        command.Parameters.Add(parameter);
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
    }
}

