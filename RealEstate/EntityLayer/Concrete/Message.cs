using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int ID { get; set; }

        public int SenderUserId { get; set; }
        public virtual AppUser SenderUser { get; set; }

        public int ReceiverUserId { get; set; }
        public virtual AppUser ReceiverUser { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
