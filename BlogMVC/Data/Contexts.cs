#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogMVC.Models;

namespace BlogMVC.Data
{
    public class Contexts : DbContext
    {
        public Contexts (DbContextOptions<Contexts> options)
            : base(options)
        {
        }

        public DbSet<BlogMVC.Models.Category> Category { get; set; }

        public DbSet<BlogMVC.Models.Blog> Blog { get; set; }
    }
}
