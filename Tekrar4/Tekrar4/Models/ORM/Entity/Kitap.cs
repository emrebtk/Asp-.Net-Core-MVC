namespace Tekrar4.Models.ORM.Entity
{
    public class Kitap
    {
        public int ID { get; set; }

        public string KitapAdi { get; set; }

        public string KitapYazari { get; set; }

        public string KitapTuru { get; set; }

        public int SayfaSayisi { get; set; }

        public bool Okundu { get; set; }

        public int KategoriID { get; set; }
    }
}
