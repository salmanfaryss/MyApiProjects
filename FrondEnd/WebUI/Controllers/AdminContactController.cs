using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using WebUI.Dtos.ContactDto;
using WebUI.Dtos.RoomDto;
using WebUI.Dtos.SendMessageDto;

namespace WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var messageResponse = await client.GetAsync("http://localhost:5200/api/Contact");

            //ContactMesajlar sayısı
            var client2 = _httpClientFactory.CreateClient();
            var messageResponse2 = await client2.GetAsync("http://localhost:5200/api/Contact/GetContactCount");
            var jsonData2 = await messageResponse2.Content.ReadAsStringAsync();
            ViewBag.ContactMessageCount = jsonData2;
            //SendMesajlar sayısı
            var client3 = _httpClientFactory.CreateClient();
            var messageResponse3 = await client3.GetAsync("http://localhost:5200/api/SendMessage/SendMessageCount");
            var jsonData3 = await messageResponse3.Content.ReadAsStringAsync();
            ViewBag.SendMessageCount = jsonData3;

            var jsonData = await messageResponse.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
            return View(values);
        }
        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5200/api/SendMessage");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);

            return View(values);
        }
        public async Task<IActionResult> ReadInboxMessage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5200/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<InboxContactDto>(JsonData);
                return View(value);
            }
            return View();
        }
        public async Task<IActionResult> ReadSendBoxMessage(int id)
        {


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5200/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var JsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<GetMessageById>(JsonData);
                return View(value);
            }
            return View();
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(NewMessageDto newMessageDto)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Kimden Gittiğini
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "projekurss@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            //Kime Gitiğini
            MailboxAddress mailboxAddressTo = new MailboxAddress("Misafir",newMessageDto.ReceiverEMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //Message İçeriğini

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = newMessageDto.MessageContent;
            //Mesaj içeriğini
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            //Mesaj konusu
            mimeMessage.Subject = newMessageDto.Subject;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com",587,false);
            smtpClient.Authenticate("projekurss@gmail.com", "eiekrqeombzkipdz");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

           

            newMessageDto.SenderEmail = "admin@gmail.com";
            newMessageDto.SenderName = "admin";
            newMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(newMessageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5200/api/SendMessage", stringContent);
            //var client = _httpClientFactory.CreateClient();
            //var jsonData = JsonConvert.SerializeObject(newMessageDto);
            //StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            //var responseMessage = await client.PostAsync("http://localhost:5200/api/SendMessage", stringContent);
            return RedirectToAction("SendBox","AdminContact");

           
        }

        public PartialViewResult SideBarAdminContact()
        {
            return PartialView();
        }
    }
}
