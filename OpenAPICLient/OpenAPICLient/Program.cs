// See https://aka.ms/new-console-template for more information
using OpenAPICLient;

Console.WriteLine("Hello, World!");


DateTime dateTime = DateTime.Now;


var client = new swaggerClient("https://localhost:7220/", new HttpClient());


foreach (var item in await client.GetWeatherForecastAsync())
{
    Console.WriteLine($"{item.Date} {item.TemperatureC}");
}

