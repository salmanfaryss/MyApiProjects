using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class Rezervation:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
