﻿using Microsoft.AspNetCore.Mvc;
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

    public class SliderController : Controller
    {
        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.IsDeleted).ToListAsync();

            return View(sliders);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
