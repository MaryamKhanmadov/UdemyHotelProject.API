﻿using HotelProject.WebUI.Dtos.BookingDtos;
using HotelProject.WebUI.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5278/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
