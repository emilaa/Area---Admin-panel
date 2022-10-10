using Microsoft.EntityFrameworkCore;
using OneTwoMany_Fiorello.Models;
using OneTwoMany_Fiorello.Models.Accordion;
using OneTwoMany_Fiorello.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SliderDetail> SliderDetail { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ExpertTitle> ExpertTitle { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<BlogTitle> BlogTitle { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Say> Says { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }

        public DbSet<AccordionTitle> AccordionTitle { get; set; }
        public DbSet<AccordionDetail> AccordionDetails { get; set; }

    }
}
