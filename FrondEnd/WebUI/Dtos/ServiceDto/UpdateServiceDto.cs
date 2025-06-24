using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Hizmet icon link giriniz!")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz!")]
        [StringLength(100, ErrorMessage = "100 karakterden fazla giremezsin")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
