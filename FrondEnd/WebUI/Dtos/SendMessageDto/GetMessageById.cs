namespace WebUI.Dtos.SendMessageDto
{
    public class GetMessageById
    {
        public int SendMessageId { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverEMail { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
