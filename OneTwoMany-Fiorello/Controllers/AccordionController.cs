using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneTwoMany_Fiorello.Data;
using OneTwoMany_Fiorello.Models;
using OneTwoMany_Fiorello.Models.Accordion;
using OneTwoMany_Fiorello.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.Controllers
{
    public class AccordionController : Controller
    {
        private readonly AppDbContext _context;
        public AccordionController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AccordionTitle accordionTitle = await _context.AccordionTitle.FirstOrDefaultAsync();
            IEnumerable<AccordionDetail> accordionDetails = await _context.AccordionDetails.ToListAsync();

            AccordionVM accordionVM = new AccordionVM
            {
                AccordionTitle = accordionTitle,
                AccordionDetails = accordionDetails
            };

            return View(accordionVM);
        }
    }
}
