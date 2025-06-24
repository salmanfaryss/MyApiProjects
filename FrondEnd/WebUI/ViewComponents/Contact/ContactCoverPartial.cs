using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Contact
{
    public class ContactCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
