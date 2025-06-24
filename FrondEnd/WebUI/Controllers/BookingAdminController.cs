using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebUI.Dtos.BookingDto;

namespace WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client  = _httpClientFactory.CreateClient();
            var messageResponse = await client.GetAsync("http://localhost:5200/api/Booking");
            if (messageResponse.IsSuccessStatusCode)
            {
                var jsonData = await messageResponse.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(value);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation2(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5200/api/Booking/BookingAproved?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","BookingAdmin");
            }
            return View();
        }
        public async Task<IActionResult> BookingCancel(int id)
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5200/api/Booking/BookingCancel?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "BookingAdmin");
            }
            return View();
        }
        public async Task<IActionResult> BookingAwait(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5200/api/Booking/BookingAwait?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "BookingAdmin");
            }
            return View();
        }
    }
}
