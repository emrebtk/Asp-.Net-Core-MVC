namespace Kurumsal1.Models.ORM.Entity
{
    public class Blog:BaseEntity
    {
        public int ID { get; set; }

        public int OkunmaSayisi { get; set; }

        public DateTime Tarih { get; set; }
    }
}
