using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.StaffDto;

namespace WebUI.ViewComponents.Default
{
    public class Team : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Team(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonDate = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonDate);
               return View(value);
            }
            return View();
        }
    }
}
