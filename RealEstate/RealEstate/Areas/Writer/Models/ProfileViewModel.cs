using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Areas.Writer.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
        public string Password { get; set; }
    }
}
