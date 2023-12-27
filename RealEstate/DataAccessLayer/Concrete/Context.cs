using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JI387RJ\\SQLEXPRESS;database=RealEStateDB;Integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Favorite>().HasOne(x => x.Property)
               .WithMany(y => y.PropertyFavorites)
               .HasForeignKey(z => z.PropertyID)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Favorite>().HasOne(x => x.AppUser)
                .WithMany(y => y.AppUserFavoriteProperties)
                .HasForeignKey(z => z.AppUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Message>().HasOne(x => x.SenderUser)
               .WithMany(y => y.SenderMessage)
               .HasForeignKey(z => z.SenderUserId)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Message>().HasOne(x => x.ReceiverUser)
                .WithMany(y => y.ReceiveMessage)
                .HasForeignKey(z => z.ReceiverUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }

        public DbSet<About1> About1s{ get; set; }
        public DbSet<About2> About2s{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<ContactMessage>ContactMessages{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Property> Properties{ get; set; }
        public DbSet<PropertyStatus> PropertyStatuses{ get; set; }
        public DbSet<PropertyType> PropertyTypes{ get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications{ get; set; }


    }
}
