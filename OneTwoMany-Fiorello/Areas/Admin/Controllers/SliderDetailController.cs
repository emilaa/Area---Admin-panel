using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneTwoMany_Fiorello.Data;
using OneTwoMany_Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderDetailController : Controller
    {
        private readonly AppDbContext _context;

        public SliderDetailController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            SliderDetail sliderDetail = await _context.SliderDetail.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            return View(sliderDetail);
        }
    }
}
