using Microsoft.Data.SqlClient;

string connectionstring = "Server=localhost;Database=everyloop;Trusted_Connection=True; TrustServerCertificate = True";
string Query = "Select * from elements where period = 2";

using SqlConnection Connection = new(connectionstring);
Connection.Open();


while (true)
{
    Console.Write("Enter search string: ");
    string searchString = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(searchString)) break;
    FetchAirPorts(Connection,searchString,8);

}

static void FetchAirPorts(SqlConnection connection, string searchString,int max)
{
    try
    {
        string Query =
            "Select top (@maxCount) Iata, [Airport Name], [Location served] from airports2 where [airport name] like concat('%', @searchString, '%')";
        SqlCommand command = new SqlCommand(Query, connection);

        command.Parameters.Add("searchString",System.Data.SqlDbType.NVarChar).Value = searchString;
        command.Parameters.Add("maxCount", System.Data.SqlDbType.Int).Value = max;
        using SqlDataReader reader = command.ExecuteReader();

        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader.GetName(i).ToString().ToUpper().PadRight(40)}");
        }

        Console.WriteLine();

        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetValue(i).ToString().PadRight(40)}");
            }

            Console.WriteLine();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}