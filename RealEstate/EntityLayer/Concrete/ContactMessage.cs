using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactMessage
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen ad alanını doldurunuz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen mail alanını doldurunuz.")]

        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen konu alanını doldurunuz.")]

        public string Subject { get; set; }
        [Required(ErrorMessage = "Lütfen mesaj alanını doldurunuz.")]

        public string Message { get; set; }
    }
}
