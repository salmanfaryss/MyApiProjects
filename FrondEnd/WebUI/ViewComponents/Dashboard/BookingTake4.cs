using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebUI.Dtos.DashboardDto;

namespace WebUI.ViewComponents.Dashboard
{
    public class BookingTake4:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingTake4(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/Dashboard/BookinkTake4");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<BookingList>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
