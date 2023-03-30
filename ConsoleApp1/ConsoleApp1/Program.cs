// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

var url = "https://localhost:7220/WeatherForecast";

var http = new HttpClient();

var json = await http.GetStringAsync(url);

var wv = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Wetter>>(json);

foreach (var item in wv)
{
    Console.WriteLine($"{item.temperatureC} {item.summary}");
}
