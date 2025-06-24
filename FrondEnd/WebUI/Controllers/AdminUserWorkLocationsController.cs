using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.AppUserDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.WorkLocationDto;

namespace WebUI.Controllers
{
    public class AdminUserWorkLocationsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUserWorkLocationsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/AppUserWorkLocation");
            if (responseMessage.IsSuccessStatusCode)
            {

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAppUserWithWorkLocation>>(jsonData);
                return View(values);
            }
            return View();
            
        }
    }
}
