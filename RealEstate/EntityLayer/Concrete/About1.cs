using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About1
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Article1 { get; set; }
        public string Article2 { get; set; }
        public string Article3 { get; set; }
        public string Image { get; set; }
    }
}
