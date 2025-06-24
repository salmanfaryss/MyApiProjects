using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebUI.Dtos;
using WebUI.Dtos.SubscribDto;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Render()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SubscribPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _SubscribPartial(CreateSubcribDto createSubcribDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonDate = JsonConvert.SerializeObject(createSubcribDto);
            StringContent stringContent = new StringContent(jsonDate,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5200/api/Subscrib", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
            
        }
    }
}
