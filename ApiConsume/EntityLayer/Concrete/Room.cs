using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int Price  { get; set; }
        public string Title { get; set; }
        public int View {  get; set; }
        public int BedCount { get; set; }
        public int BoatCount {  get; set; }
        public bool Wifi {  get; set; }
        public string RoomNumber { get; set; }
        
        public string RecoverImage { get; set; }

    }
}
