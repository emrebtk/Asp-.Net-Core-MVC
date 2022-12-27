using Microsoft.EntityFrameworkCore;
using Tekrar4.Models.ORM.Entity;

namespace Tekrar4.Models.ORM.Context
{
    public class KutuphaneContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WEBICRO\SQLEXPRESS;Database=KutuphaneOtomasyonu;Trusted_Connection=True;");
        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
