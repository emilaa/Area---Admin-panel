using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OneTwoMany_Fiorello.Data;
using OneTwoMany_Fiorello.Models;
using OneTwoMany_Fiorello.Models.Accordion;
using OneTwoMany_Fiorello.Models.Home;
using OneTwoMany_Fiorello.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            SliderDetail sliderDetail = await _context.SliderDetail.FirstOrDefaultAsync();
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.Where(m => m.IsDeleted == false).ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.ProductImages).ToListAsync();
            About about = await _context.Abouts.FirstOrDefaultAsync();
            ExpertTitle expertTitle = await _context.ExpertTitle.FirstOrDefaultAsync();
            IEnumerable<Expert> experts = await _context.Experts.ToListAsync();
            Subscribe subscribe = await _context.Subscribe.FirstOrDefaultAsync();
            BlogTitle blogTitle = await _context.BlogTitle.FirstOrDefaultAsync();
            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();
            IEnumerable<Say> says = await _context.Says.ToListAsync();
            IEnumerable<Instagram> instagrams = await _context.Instagrams.ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                SliderDetail = sliderDetail,
                Sliders = sliders,
                Categories = categories,
                Products = products,
                About = about,
                ExpertTitle = expertTitle,
                Experts = experts,
                Subscribe = subscribe,
                BlogTitle = blogTitle,
                Blogs = blogs,
                Says = says,
                Instagrams = instagrams
            };

            return View(homeVM);
        }
    }
}
