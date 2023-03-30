// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");



foreach (var item in GetText())
{
    Console.WriteLine(item);
}


await foreach (var item in GetAllCustomers())
{
    Console.WriteLine(item.ContactName);
}

static IEnumerable<string> GetText()
{
    //var list = new List<string>();
    //list.Add("Hallo");
    //list.Add("Welt");
    //return list;

    yield return "Hallo";
    yield return "Welt";
}

static async IAsyncEnumerable<Customer> GetAllCustomers()
{
    var connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Northwnd;Integrated Security=True"; // replace with your own connection string

    using var connection = new SqlConnection(connectionString);
    var command = new SqlCommand("SELECT * FROM Customers", connection);
    await connection.OpenAsync();
    var reader = command.ExecuteReader();
    while (await reader.ReadAsync())
    {
        var customer = new Customer
        {
            CustomerID = reader.GetString(0),
            CompanyName = reader.GetString(1),
            ContactName = reader.GetString(2),
            ContactTitle = reader.GetString(3),
            Address = reader.GetString(4),
            City = reader.GetString(5),
            Region = reader.IsDBNull(6) ? null : reader.GetString(6),
            PostalCode = reader.IsDBNull(7) ? null : reader.GetString(7),
            Country = reader.GetString(8),
            Phone = reader.GetString(9),
            Fax = reader.IsDBNull(10) ? null : reader.GetString(10),
        };
        yield return customer;
    }
}



public class Customer
{
    public string CustomerID { get; set; }

    public string CompanyName { get; set; }

    public string ContactName { get; set; }

    public string ContactTitle { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string Region { get; set; }

    public string PostalCode { get; set; }

    public string Country { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }
}
