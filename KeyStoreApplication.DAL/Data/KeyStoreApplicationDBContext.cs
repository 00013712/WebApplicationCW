using Microsoft.EntityFrameworkCore;
using KeyStoreApplication.Models;

namespace KeyStoreApplication.Data
{
    public class KeyStoreApplicationDBContext : DbContext
    {
        public KeyStoreApplicationDBContext(DbContextOptions<KeyStoreApplicationDBContext> options) : base(options) { }

        public DbSet<KeyStore> Keystore { get; set; }
        public DbSet<UserStore> Userstore { get; set; }
    }
}
