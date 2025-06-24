using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebUI.Models.Mail;

namespace WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Gönderen(Kimden gittiğini)
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "projekurss@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            //Alıcı(Kime Gittiği)
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",model.ReciverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //Message
            var BodyBuilder = new BodyBuilder();
            BodyBuilder.TextBody = model.Body;
            mimeMessage.Body = BodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com",587,false);
            smtpClient.Authenticate("projekurss@gmail.com", "eiekrqeombzkipdz");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }
    }
}
