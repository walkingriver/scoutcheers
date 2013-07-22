using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScoutCheersWeb.Models
{
    public class Cheer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Votes { get; set; }
        public String Description { get; set; }
        public UserProfile SubmittedBy { get; set; }
        public int UserProfileId { get; set; }
    }

    public class CheersContext : DbContext
    {
        public DbSet<Cheer> Cheers { get; set; }
        public DbSet<UserProfile> Users { get; set; } 
    }
}
