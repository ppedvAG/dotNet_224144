using HalloYield.Model;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

Customer customer = new Customer();
var customer2 = new Customer();
Customer customer3 = new();



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
    string tt = """lerkjglkmregklöregm  "wichtig"      relö kgmrelkgmlkre         lökergmlerkmg""";

    await Console.Out.WriteLineAsync(   tt);

    var db = "Northwnd";
    var connectionString = @$"Data Source=(localdb)\mssqllocaldb;Initial Catalog={db};Integrated Security=True"; // replace with your own connection string

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
