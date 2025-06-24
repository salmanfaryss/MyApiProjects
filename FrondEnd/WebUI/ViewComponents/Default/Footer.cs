using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
