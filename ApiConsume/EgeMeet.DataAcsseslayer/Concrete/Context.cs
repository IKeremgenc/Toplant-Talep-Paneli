using EgeMeet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeMeet.DataAcsseslayer.Concrete
{ 
     public  class Context:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KEREMGENCPC\\SQLEXPRESS;initial catalog=EgeMeet;integrated security=true");

        }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<HowToUs> HowToUs { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingRequest> meetingRequests { get; set; }

    }
}
