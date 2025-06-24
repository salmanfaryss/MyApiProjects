using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebUI.Dtos.DashboardDto;

namespace WebUI.ViewComponents.Dashboard
{
    public class Last4StaffList:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Last4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/Dashboard/StaffTake4");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<LastStaffList>>(jsonData);
                return View(value);
            }

            return View();
        }
    }
}
