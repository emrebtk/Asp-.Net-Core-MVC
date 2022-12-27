using hepsiburada.Entity;
using hepsiburada.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace hepsiburada.DataAccess

{
    public class HContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EMRES-HP\SQLEXPRESS;Database=emre;Trusted_Connection=True;");
        }
        public DbSet<aks> akst { get; set; }
        public DbSet<phone> phonet { get; set; }
        public DbSet<oem> oemt { get; set; }
        public DbSet<pc> pct { get; set; }
        public DbSet<Sepet> Sepett { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
