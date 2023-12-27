using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public virtual List<Property> Properties{ get; set; }
        public virtual List<Favorite> AppUserFavoriteProperties { get; set; }
        public virtual List<Message> SenderMessage{ get; set; }
        public virtual List<Message> ReceiveMessage{ get; set; }
    }
}
