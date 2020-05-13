using System.Data.Entity;

namespace Models
{
    public class PIDbContext : DbContext
    {
        public PIDbContext() : base("PIDbContext")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<PasswordGroup> PasswordGroups { set; get; }
    }
}
