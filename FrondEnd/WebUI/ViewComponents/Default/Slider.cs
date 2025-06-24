using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class Slider:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
