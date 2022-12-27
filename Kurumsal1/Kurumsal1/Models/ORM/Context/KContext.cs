using Kurumsal1.Models.ORM.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal1.Models.ORM.Context
{
    public class KContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WEBICRO\SQLEXPRESS;Database=Kurumsal1;Trusted_Connection=True;
");
        }


        public DbSet<Porftoy> Porftoylar { get; set; }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Ayarlar> Ayarlar { get; set; }
        public DbSet<Slider> Sliderlar { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
    }
}
