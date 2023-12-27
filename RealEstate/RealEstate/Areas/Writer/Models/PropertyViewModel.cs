using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Areas.Writer.Models
{
    public class PropertyViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Price { get; set; }
        public string Street { get; set; }
        public string Bet { get; set; }
        public string Bath { get; set; }
        public string Sqft { get; set; }
        public IFormFile ImageProperty { get; set; }
        public int PropertyStatusId { get; set; }
        public int PropertyTypeId { get; set; }
        public int AppUserId { get; set; }
    }
}
