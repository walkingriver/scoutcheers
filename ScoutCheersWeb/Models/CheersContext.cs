using System.Data.Entity;

namespace ScoutCheersWeb.Models
{
    public class CheersContext : DbContext
    {
        static CheersContext()
        {
            Database.SetInitializer(new CheersInitializer());
        }
        public DbSet<Cheer> Cheers
        {
            get { return Set<Cheer>(); }
        }

        public DbSet<UserProfile> Users
        {
            get { return Set<UserProfile>(); }
        }
    }
}