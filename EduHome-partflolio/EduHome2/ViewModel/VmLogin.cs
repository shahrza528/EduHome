using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.ViewModel
{
    public class VmLogin
    {
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(50), Required]
        public string Password { get; set; }

    }
}
