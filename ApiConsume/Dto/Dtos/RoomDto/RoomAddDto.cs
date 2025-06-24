using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Dtos.RoomDto
{
    public class RoomAddDto
    {

        [Required(ErrorMessage ="Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        public string Title { get; set; }
        public int View { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı  giriniz")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı  giriniz")]
        public int BoatCount { get; set; }
        public bool Wifi { get; set; }
        [Required(ErrorMessage ="Lütefn oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        public string RecoverImage { get; set; }
    }
}
