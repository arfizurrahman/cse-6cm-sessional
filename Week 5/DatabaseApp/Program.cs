using System.Data.SqlClient;

string connectionString = "Server=localhost;Database=StudentDb;Trusted_Connection=True;";

using(SqlConnection connection = new SqlConnection(connectionString)){
    connection.Open();
    Console.WriteLine("Connected to the database");

    string query = "SELECT * FROM Students";
    SqlCommand command = new SqlCommand(query, connection);
    SqlDataReader reader = command.ExecuteReader();

    while(reader.Read()){
        Console.WriteLine($"ID: {reader["Id"]}, First Name: {reader["FirstName"]}, Last Name: {reader["LastName"]}, Date of Birth: {reader["DateOfBirth"]}");
    }

}