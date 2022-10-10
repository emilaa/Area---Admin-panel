using OneTwoMany_Fiorello.Models;
using OneTwoMany_Fiorello.Models.Accordion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneTwoMany_Fiorello.ViewModels
{
    public class AccordionVM
    {
        public AccordionTitle AccordionTitle { get; set; }
        public IEnumerable<AccordionDetail> AccordionDetails { get; set; }
    }
}
