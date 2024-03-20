using Microsoft.EntityFrameworkCore;
using KeyStoreApplication.Models;

namespace KeyStoreApplication.Data
{
    //Made by Wiut student 00013712
    public class KeyStoreApplicationDBContext : DbContext
    {
        public KeyStoreApplicationDBContext(DbContextOptions<KeyStoreApplicationDBContext> options) : base(options) { }

        public DbSet<KeyStore> Keystore { get; set; }
        public DbSet<UserStore> Userstore { get; set; }
    }

    //Made by Wiut student 00013712
}
