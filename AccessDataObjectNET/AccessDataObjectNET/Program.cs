/*====================================
 
      CONECCION RUDIMENTARIA 
             A UNA 
        BASE DE DATOS LOCAL
 
====================================== */

using System.Data.SqlClient;

var connetionString = @"Server=SHA-DEV;Database=Northwind;Trusted_Connection=True";


using (SqlConnection connection = new SqlConnection(connetionString))
{
    connection.Open();
    var command = new SqlCommand("SELECT * FROM Customers", connection);
    var reader = command.ExecuteReader();
    while (reader.Read())
    {
    Console.WriteLine($"{reader["CustomerID"]}{reader["CompanyName"]}");
    }
    Console.ReadKey(); 
}

//Console.WriteLine(reader.GetString(0));








