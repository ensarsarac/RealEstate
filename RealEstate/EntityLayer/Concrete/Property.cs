using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Property
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Bet { get; set; }
        public string Bath { get; set; }
        public string Sqft { get; set; }
        public string Image { get; set; }

        public int PropertyTypeId { get; set; }
        public virtual PropertyType PropertyType { get; set; }

        public int PropertyStatusId { get; set; }
        public virtual PropertyStatus PropertyStatus { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser{ get; set; }

        public bool Status { get; set; }

        public DateTime Date { get; set; }

        public virtual List<Favorite> PropertyFavorites{ get; set; }

    }
}
