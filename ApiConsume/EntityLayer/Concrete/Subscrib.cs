using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Subscrib
    {
        [Key]
        public int SubscribId { get; set; }
        public string Email { get; set; }
    }
}
