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
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SALMANFARYSS; initial catalog=ApiDb;integrated security = true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Subscrib> subscribs { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Contact> contacts  { get; set; }
        public DbSet<Guest> guests  { get; set; }
        public DbSet<MessageCategory> messageCategories  { get; set; }
        public DbSet<SendMessage> sendMessages  { get; set; }
        public DbSet<WorkLocation> workLocations  { get; set; }
    }
}
