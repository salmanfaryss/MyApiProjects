using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class Spinner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
