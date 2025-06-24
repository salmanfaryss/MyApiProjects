using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.Dtos.AboutDto;
using WebUI.Dtos.RoomDto;

namespace WebUI.ViewComponents.Default
{
    public class OurRooms:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OurRooms(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/Room2");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(value);
            }
            return View();
            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("http://localhost:5200/api/Room");
            //if(responseMessage.IsSuccessStatusCode)
            //{
            //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //    var value = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
            //    return View(value);
            //}

           
        }
    }
}
