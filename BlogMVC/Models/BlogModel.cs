namespace BlogMVC.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
