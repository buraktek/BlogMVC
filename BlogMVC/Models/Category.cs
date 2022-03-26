using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string KategoriAdi{ get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
