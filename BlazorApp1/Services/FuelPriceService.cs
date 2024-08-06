using System.Net.Http.Json;
using BlazorApp1.Models;

namespace BlazorApp1.Services;

public class FuelPriceService
{
    private readonly HttpClient _httpClient;

    public FuelPriceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<FuelPrice>> GetMiles95Prices()
    {
        return await _httpClient.GetFromJsonAsync<List<FuelPrice>>("https://magsapi.onrender.com/api/miles95");
    }

    public async Task<List<FuelPrice>> GetDieselPrices()
    {
        return await _httpClient.GetFromJsonAsync<List<FuelPrice>>("https://magsapi.onrender.com/api/diesel");
    }
}