using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.Staff
{
    public class StaffViewModel
    {
        [Key]
        public int StaffId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

    }
}
