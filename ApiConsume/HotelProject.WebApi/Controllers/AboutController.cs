using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            return Ok(_aboutService.TGetList());
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(string id)
        {
            _aboutService.TDelete(await _aboutService.TGetByID(int.Parse(id)));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            return Ok(_aboutService.TGetByID(id));
        }
    }
}
