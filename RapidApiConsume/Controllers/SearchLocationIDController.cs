using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/api/v1/hotels/searchDestination?query={cityName}"),
                    Headers =
    {
        { "X-RapidAPI-Key", "b4a6fd5babmsh4969ad21cd87737p1630a1jsn160a8d9fc099" },
        { "X-RapidAPI-Host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiSearchLocationViewModel>(body);
                    return View(values.data.Take(1).ToList());
                }
            }
            else
            {
                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=paris"),
                    Headers =
    {
        { "X-RapidAPI-Key", "b4a6fd5babmsh4969ad21cd87737p1630a1jsn160a8d9fc099" },
        { "X-RapidAPI-Host", "booking-com15.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiSearchLocationViewModel>(body);
                    return View(values.data.Take(1).ToList());
                }
            }
        }
    }
}
