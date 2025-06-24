using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
