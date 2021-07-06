using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome2.ViewModel
{
    public class VmRegister
    {
        [MaxLength(30),Required]
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string SurName { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(50), Required]
        public string Password { get; set; }
        [MaxLength(50), Required]
        public string ConiformPassword { get; set; }
    }
}
