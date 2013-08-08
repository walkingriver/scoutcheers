using System.Data.Entity;

namespace ScoutCheersWeb.Models
{
    public class CheersContext : DbContext
    {
        // Todo: Put this initializer in web.config
        static CheersContext()
        {
            Database.SetInitializer(new CheersInitializer());
        }

        public CheersContext()
            : base("DefaultConnection")
        {
        }

        public CheersContext(string connection)
            : base(connection)
        {
        }

        public DbSet<Cheer> Cheers
        {
            get { return Set<Cheer>(); }
        }

        public DbSet<UserProfile> UserProfiles
        {
            get
            {
                return Set<UserProfile>();
            }
        }

    }
}