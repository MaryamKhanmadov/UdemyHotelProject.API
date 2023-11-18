using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {
            if (!string.IsNullOrEmpty(cityID))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={cityID}&search_type=CITY&arrival_date=2024-12-16&departure_date=2024-12-30&adults=2&children_age=0%2C17&room_qty=1&page_number=1&languagecode=en-us&currency_code=EUR"),
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
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.data.hotels.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-1456928&search_type=CITY&arrival_date=2024-12-16&departure_date=2024-12-30&adults=2&children_age=0%2C17&room_qty=1&page_number=1&languagecode=en-us&currency_code=EUR"),
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
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.data.hotels.ToList());
                }
            }
        }
    }
}
