using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int ID { get; set; }
        public string Subject { get; set; }
        public string NotiContent { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public bool Status{ get; set; }
    }
}
