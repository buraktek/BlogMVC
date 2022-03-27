using System.Data.Entity;

namespace BlogMVC.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category()  {KategoriAdi="C#"},
                new Category()  {KategoriAdi="Asp.net MVC"},
                new Category()  {KategoriAdi="Asp.net Webform"},
                new Category()  {KategoriAdi="C++"},
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog()  {Baslik="C# Delegates Hakkında1 C# Delegates Hakkında1 C# Delegates Hakkında1 C# Delegates Hakkında1 C# Delegates Hakkında1C# Delegates Hakkında1C# Delegates Hakkında1C# Delegates Hakkında1C# Delegates Hakkında1C# Delegates Hakkında1",Aciklama="Delegates Hakkında1Delegates Hakkında1Delegates Hakkında1Delegates Hakkında1Delegates Hakkında1Delegates Hakkında1",EklemeTarihi=DateTime.Now.AddDays(-10) , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=1},
                new Blog()  {Baslik="C# Delegates Hakkında1",Aciklama="Delegates Hakkında1",EklemeTarihi=DateTime.Now.AddDays(-10) , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=1},
                new Blog()  {Baslik="C# Delegates Hakkında2",Aciklama="Delegates Hakkında2",EklemeTarihi=DateTime.Now.AddDays(-5)  , Resim="1.jpg", Anasayfa = true, Onay = false,CategoryId=2},
                new Blog()  {Baslik="C# Delegates Hakkında2",Aciklama="Delegates Hakkında2",EklemeTarihi=DateTime.Now.AddDays(-5)  , Resim="1.jpg", Anasayfa = true, Onay = false,CategoryId=2},
                new Blog()  {Baslik="C# Delegates Hakkında3",Aciklama="Delegates Hakkında3",EklemeTarihi=DateTime.Now.AddDays(-4)  , Resim="1.jpg", Anasayfa = false, Onay = true,CategoryId=3},
                new Blog()  {Baslik="C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3C# Delegates Hakkında3",Aciklama="Delegates Hakkında3",EklemeTarihi=DateTime.Now.AddDays(-4)  , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=3},
                new Blog()  {Baslik="C# Delegates Hakkında4",Aciklama="Delegates Hakkında4",EklemeTarihi=DateTime.Now.AddDays(-3)  , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=4},
                new Blog()  {Baslik="C# Delegates Hakkında4",Aciklama="Delegates Hakkında4",EklemeTarihi=DateTime.Now.AddDays(-3)  , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=4},
                new Blog()  {Baslik="C# Delegates Hakkında4",Aciklama="Delegates Hakkında4",EklemeTarihi=DateTime.Now.AddDays(-3)  , Resim="1.jpg", Anasayfa = true, Onay = true,CategoryId=4},
            };
            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
