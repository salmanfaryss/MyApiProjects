using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class Scripte:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
