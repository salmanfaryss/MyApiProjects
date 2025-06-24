using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MessageCategory
    {
        [Key]
        public int MessageCategoryId { get; set; }
        public string MessageCategoryName { get; set; }

        public List<Contact> contacts { get; set; }
            
    }
}
