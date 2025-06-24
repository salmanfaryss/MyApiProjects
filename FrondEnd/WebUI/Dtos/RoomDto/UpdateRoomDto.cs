namespace WebUI.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomId { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int View { get; set; }
        public int BedCount { get; set; }
        public int BoatCount { get; set; }
        public bool Wifi { get; set; }
        public string RoomNumber { get; set; }
        public string RecoverImage { get; set; }
    }
}
