using ShippingCalculator.Models;
using ShippingCalculator.Services;
using System.Text.Json;

var inputJson = File.ReadAllText("Shipment.json");

var shipments = JsonSerializer.Deserialize<List<ShipmentDto>>(inputJson, new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
});

var service = new ShipmentService();
var results = shipments.Select(service.Calculate).ToList();

string output = JsonSerializer.Serialize(results, new JsonSerializerOptions
{
    WriteIndented = true
});

Console.WriteLine(output);
